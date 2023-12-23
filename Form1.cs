using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Text.Json;

namespace lucid_dreams
{
    public partial class MainForm : MaterialForm
    {
        public class Perks
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class Scripts
        {
            public int id { get; set; }
            public int software { get; set; }
            public string name { get; set; }
            public string author { get; set; }
            public int last_update { get; set; }
            public string update_notes { get; set; }
            public string script_contents { get; set; } 
        }

        public class Session
        {
            public string directory { get; set; }
            public int started { get; set; }
            public int expire { get; set; }
        }

        public class Steam
        {
            public string id { get; set; }
            public string name { get; set; }
            public string persona { get; set; }
            public int time { get; set; }
        }

        // Globals
        public class Global
        {
            public string username { get; set; }
            public string key { get; set; }
            public int key_link { get; set; }
            public int key_stop { get; set; }
            public string level { get; set; }
            public string protection { get; set; }
            public string buddy { get; set; }
            public string xp { get; set; }
            public string perk_points { get; set; }
            public  List<Perks> perks { get; set; } // Current user perks.
            public List<Perks> perks_list { get; set; } // All available perks.
            public string sign { get; set; }
            public string fid { get; set; }
            public string unread_conversations { get; set; }
            public string unread_alerts { get; set; }
            public string last_activity { get; set; }
            public string register_date { get; set; }
            public string posts { get; set; }
            public string score { get; set; }
            public string custom_title { get; set; }
            public string groups { get; set; }
            public string avatar { get; set; }
            public List<Session> session { get; set; }
            public List<Steam> steam { get; set; }
            public string configuration { get; set; }

            // Lucid Dreams Globals
            public string quick_debug_path { get; set; }
            public string con_batch_path { get; set; }
            public string uni_batch_path { get; set; }
            public bool logged_in { get; set; }
            public bool auto_key { get; set; }
            public bool cur_sync { get; set; }
            public bool sync_finished { get; set; }
            public bool show_sync { get; set; }
            public bool sync_text_reset { get; set; }
            public string last_sync { get; set; }
            public int text_timeout = 4000;
            public int reset_config_count { get; set; }
            public string VER = "0.3.5";
        }

        Global Globals = new Global();

        public MainForm()
        {
            InitializeComponent();
            
            // Force non-resizable window
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Sizable = false;

            // Theme Manager Setup
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple200, Primary.Purple300, Primary.Purple500, Accent.DeepPurple400, TextShade.WHITE);
            
            // Version global
            versionLabel.Text = $"v{Globals.VER}";

            // Key check
            string keyDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.txt");
            if (File.Exists(keyDir))
            {
                Globals.key = File.ReadAllText(keyDir);
                keyTextBox.Text = Globals.key;
                Globals.auto_key = true;
                // Forces a full webAPI refresh
                fullUpdate();
            }

            // Path setup
            Globals.quick_debug_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ld_debug_{Globals.VER}.txt");
            Globals.con_batch_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "constellation.bat");
            Globals.uni_batch_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "launch.bat");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Functions
       
        // Rounds any image. Not the best implementation.
        public Image RoundCorners(Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);

            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Brush brush = new TextureBrush(StartImage);

                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);

                return RoundedImage;
            }
        }

        // Runs the main constelia.ai API request and stores the restults in their respective global values.
        private async void fullUpdate()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // If the key wasn't automatically found, grab it from the text field and store it.
                    if (!Globals.auto_key)
                    {
                        Globals.key = keyTextBox.Text;
                    }
                    // Check if there is already a sync task running. If not, start one.
                    if (!Globals.cur_sync)
                    {
                        Globals.cur_sync = true;
                        syncButton.Text = "Syncing";
                        syncButton.Enabled = false;

                        /** We need to check if the key is a valid format before running the API request.
                        *   This is ESSENTIAL to ensure users wont get false API banned. **/
                        Regex regex = new Regex(@"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$");
                        if (!regex.IsMatch(Globals.key))
                        {
                            MessageBox.Show("Your key was an invalid format! Wanted format: ABCD-EFGH-IJKL-MNOP.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Timer for sync button text to reset back to normal.
                        System.Windows.Forms.Timer syncButtonTimer = new System.Windows.Forms.Timer();
                        syncButtonTimer.Interval = Globals.text_timeout;
                        syncButtonTimer.Tick += (s, ea) =>
                        {
                            syncButton.Text = "Sync";
                            syncButton.Enabled = true;
                            Globals.sync_text_reset = true;
                            syncButtonTimer.Stop();
                        };
                        syncButtonTimer.Start();

                        // Base URL is the main APi request here. It grabs ALL user info except sessions, so we need to run a request for that seperately.
                        string baseUrl = $"https://constelia.ai/api.php?key={Globals.key}";
                        HttpResponseMessage globalResponse = await client.GetAsync(baseUrl);
                        HttpResponseMessage sessionResponse = await client.GetAsync($"https://constelia.ai/api.php?key={Globals.key}&cmd=getMember&history");
                        HttpResponseMessage perksResponse = await client.GetAsync($"https://constelia.ai/api.php?key={Globals.key}&cmd=listPerks");

                        // Check if both responses are good.
                        if (globalResponse.IsSuccessStatusCode && sessionResponse.IsSuccessStatusCode && perksResponse.IsSuccessStatusCode)
                        {
                            // Converting both results right to strings makes this process a lot simpler.
                            string globalResult = await globalResponse.Content.ReadAsStringAsync();
                            string sessionResult = await sessionResponse.Content.ReadAsStringAsync();
                            string perksResult = await perksResponse.Content.ReadAsStringAsync();
                            

                            // Parsing both results and getting their root.
                            var globalJson = JsonDocument.Parse(globalResult);
                            var sessionJson = JsonDocument.Parse(sessionResult);
                            var perksJson = JsonDocument.Parse(perksResult);
                            var globalRoot = globalJson.RootElement;
                            var sessionRoot = sessionJson.RootElement;
                            var perksRoot = perksJson.RootElement;

                            // Store json parsing results into their globals.
                            if (globalRoot.TryGetProperty("username", out var memberProperty) && memberProperty.ValueKind == JsonValueKind.String)
                            {
                                Globals.username = memberProperty.GetString();
                            }
                            else
                            {
                                Globals.username = "Logged out!";
                            }

                            if (globalRoot.TryGetProperty("level", out var levelProperty) && levelProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.level = levelProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.level = "0";
                            }

                            if (globalRoot.TryGetProperty("protection", out var protectionProperty) && protectionProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.protection = protectionProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.protection = "0";
                            }

                            if (globalRoot.TryGetProperty("fid", out var fidProperty) && fidProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.fid = fidProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.fid = "0";
                            }

                            if (globalRoot.TryGetProperty("unread_conversations", out var unreadConversationsProperty) && unreadConversationsProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.unread_conversations = unreadConversationsProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.unread_conversations = "0";
                            }

                            if (globalRoot.TryGetProperty("unread_alerts", out var unreadAlertsProperty) && unreadAlertsProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.unread_alerts = unreadAlertsProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.unread_alerts = "0";
                            }

                            if (globalRoot.TryGetProperty("register_date", out var registerDateProperty) && registerDateProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.register_date = DateTimeOffset.FromUnixTimeSeconds(registerDateProperty.GetInt64()).DateTime.ToString();
                            }
                            else
                            {
                                Globals.register_date = DateTime.Now.ToString();
                            }

                            if (globalRoot.TryGetProperty("posts", out var postsProperty) && postsProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.posts = postsProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.posts = "0";
                            }

                            if (globalRoot.TryGetProperty("score", out var scoreProperty) && scoreProperty.ValueKind == JsonValueKind.Number)
                            {
                                Globals.score = scoreProperty.GetInt32().ToString();
                            }
                            else
                            {
                                Globals.score = "0";
                            }

                            if (globalRoot.TryGetProperty("avatar", out var avatarURLProperty) && avatarURLProperty.ValueKind == JsonValueKind.String)
                            {
                                Globals.avatar = avatarURLProperty.GetString();
                            }
                            else
                            {
                                Globals.avatar = "null";
                            }

                            if (globalRoot.TryGetProperty("configuration", out var configProperty) && configProperty.ValueKind == JsonValueKind.Object)
                            {
                                Globals.configuration = configProperty.GetRawText();
                            }
                            else
                            {
                                Globals.configuration = "{}";
                            }

                            if (globalRoot.TryGetProperty("perk_points", out var perkPointsProperty) && perkPointsProperty.ValueKind == JsonValueKind.Number) 
                            {
                                Globals.perk_points = perkPointsProperty.GetInt32().ToString();
                            }

                            if (globalRoot.TryGetProperty("perks", out var perksProperty) && perksProperty.ValueKind == JsonValueKind.Array)
                            {
                                Globals.perks = JsonConvert.DeserializeObject<List<Perks>>(perksProperty.ToString());
                            }

                            if (sessionRoot.TryGetProperty("session", out var sessionProperty) && sessionProperty.ValueKind == JsonValueKind.Array)
                            {
                                var sessionList = new List<Session>();
                                var sessionRaw = sessionProperty.GetRawText();
                                sessionList = JsonConvert.DeserializeObject<List<Session>>(sessionRaw);
                                Globals.session = sessionList;
                            }
                            else
                            {
                                Globals.session = null;
                            }

                            // Perk List
                            Globals.perks_list = JsonConvert.DeserializeObject<List<Perks>>(perksResult);

                            // Steam Info
                            if (globalRoot.TryGetProperty("steam", out var steamProperty) && steamProperty.ValueKind == JsonValueKind.Object)
                            {
                                var steamList = new List<Steam>();

                                foreach (var steamAccount in steamProperty.EnumerateObject())
                                {
                                    var account = steamAccount.Value;
                                    var steamData = new Steam
                                    {
                                        id = account.GetProperty("id").GetString(),
                                        name = account.GetProperty("name").GetString(),
                                        persona = account.GetProperty("persona").GetString(),
                                        time = account.GetProperty("time").GetInt32()
                                    };

                                    steamList.Add(steamData);
                                }

                                // Now, steamList contains each Steam account information as objects in a list
                                Globals.steam = steamList;
                            }
                            else
                            {
                                MessageBox.Show("Failed to grab steam info!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // Update UI
                            // Info Panels
                            usernameLabel.Text = $"Welcome {Globals.username}";
                            alertsLabel.Text = $"Unread Alerts: {Globals.unread_alerts}";
                            messagesLabel.Text = $"Unread Messages: {Globals.unread_conversations}";
                            scoreLabel.Text = $"Score: {Globals.score}";
                            postsLabel.Text = $"Posts: {Globals.posts}";
                            fidLabel.Text = $"Fantasy ID: {Globals.fid}";
                            regLabel.Text = $"Registered: {Globals.register_date}";

                            // Update perk combo with latest perk names.
                            foreach (Perks perks in Globals.perks_list)
                            {
                                perkCombo.Items.Add(perks.Name);
                            }

                            // Update steam combo with grabbed steam accounts.
                            foreach (var steamAccount in Globals.steam)
                            {
                                steamAccountComboBox.Items.Add(steamAccount.name);
                            }
                            steamAccountComboBox.SelectedIndex = 0;

                            // Set Avatar Box Elements
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            gp.AddEllipse(0, 0, avatarBox.Width - 4, avatarBox.Height - 4);
                            Region rg = new Region(gp);
                            avatarBox.Region = rg;
                            avatarBox.Visible = true;
                            avatarBox.Size = new Size(68, 68);
                            avatarBox.ImageLocation = Globals.avatar;
                            avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;

                            // Protection
                            protectionCombo.SelectedIndex = Int32.Parse(Globals.protection);

                            // Sync
                            Globals.sync_finished = true;
                            Globals.show_sync = true;
                            if (Globals.show_sync)
                            {
                                loginButton.Enabled = false;
                                keyTextBox.Enabled = false;
                            }
                            Globals.cur_sync = false;
                            if (!Globals.logged_in)
                            {
                                syncButton.Enabled = false;
                            }
                            else
                            {
                                syncButton.Enabled = true;
                            }

                            // Config
                            loadConfigButton.Enabled = false;
                            JsonDocument config = JsonDocument.Parse(Globals.configuration);
                            string formattedConfig = System.Text.Json.JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                            configTextBox.Text = formattedConfig;
                            loadConfigButton.Text = "Loaded";

                            // Timer for load config button text to reset back to normal.
                            System.Windows.Forms.Timer loadButtonTimer = new System.Windows.Forms.Timer();
                            loadButtonTimer.Interval = Globals.text_timeout;
                            loadButtonTimer.Tick += (s, ea) =>
                            {
                                loadConfigButton.Text = "Load Config";
                                loadConfigButton.Enabled = true;
                                loadButtonTimer.Stop();
                            };
                            loadButtonTimer.Start();
                            var curTime = DateTime.Now;
                            Globals.last_sync = curTime.ToString("dd/MM/yyyy - hh:mm:ss");

                        }
                        else
                        {
                            // Handle users that haven't set a session or have an invalid session hash.
                            if (globalResponse.StatusCode == HttpStatusCode.Unauthorized)
                            {
                                DialogResult runLaunchbat = MessageBox.Show("This either means you don't have an active session or your hash is missmatched.\n\nRun launch.bat to set a session?", "Error Unauthorized", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                // Grab latest launch.bat and run it so the user can set a valid session.
                                if (runLaunchbat == DialogResult.Yes)
                                {
                                    string launchBatPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "launch.bat");
                                    string launchBatUrl = "https://constelia.ai/launch.bat";

                                    using (HttpClient client_2 = new HttpClient())
                                    {
                                        var launchBatUrlResponse = await client_2.GetAsync(launchBatUrl);

                                        if (launchBatUrlResponse.IsSuccessStatusCode)
                                        {
                                            var content = await launchBatUrlResponse.Content.ReadAsByteArrayAsync();
                                            File.WriteAllBytes(launchBatPath, content);
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Unable to download file from {launchBatUrl}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    if (File.Exists(launchBatPath))
                                    {
                                        Process.Start("cmd.exe", $"/c start \"\" \"{launchBatPath}\"");
                                    }
                                    else
                                    {
                                        MessageBox.Show("launch.bat does not exist.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                /** We need to remember to set the sync var to false whenever a sync is not in process!
                                 *  Especially when stopped due to unexpected errors. **/
                                Globals.cur_sync = false;
                            }
                            else
                            {
                                MessageBox.Show($"{globalResponse.StatusCode}");
                            }
                        }
                        // Once again, making sure we remember to update this var when needed.
                        Globals.cur_sync = false;
                    }
                }
                // Exception handling.
                catch (KeyNotFoundException knfEx)
                {
                    MessageBox.Show($"Exception caught. Please contact developer.\n\nKey not found: {knfEx.Message}\nException Source: {knfEx.Source}\nException Stack Trace: {knfEx.StackTrace}", "Fatal Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception caught. Please contact developer.\n\nException: {ex.Message}\nException Source: {ex.Source}\nException Stack Trace: {ex.StackTrace}", "Fatal Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Saves whatevers in the current configText buffer to be set as the user config. (sets the config xaxaxa)
        private async void setConfig()
        {
            try
            {
                saveConfigButton.Enabled = false;
                string fullConfig = configTextBox.Text;
                string encodedConfig = HttpUtility.UrlEncode(fullConfig);
                HttpClient configClient = new HttpClient();
                StringContent configContent = new StringContent($"value={encodedConfig}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage saveResponse = await configClient.PostAsync($"https://constelia.ai/api.php?key={Globals.key}&cmd=setConfiguration", configContent);

                if (saveResponse.IsSuccessStatusCode)
                {
                    saveConfigButton.Text = "Config Saved!";
                    System.Windows.Forms.Timer saveTimer = new System.Windows.Forms.Timer();
                    saveTimer.Interval = Globals.text_timeout;
                    saveTimer.Tick += (s, ea) =>
                    {
                        saveConfigButton.Text = "Save Config";
                        saveConfigButton.Enabled = true;
                        saveTimer.Stop();
                    };
                    saveTimer.Start();
                } 
                else
                {
                    MessageBox.Show($"Config failed to save!\n\n {saveResponse.StatusCode}");
                    saveConfigButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception caught. Please contact developer.\n\n{ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveConfigButton.Enabled = true;
            }
        }

        private async void loginButton_click(object sender, EventArgs e)
        {
            // If the login button was clicked and there isn't currently a sync task running then run a full update.
            if (!Globals.cur_sync)
            {
                fullUpdate();
            }
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            // Same as login but for the sync button :)
            if (!Globals.cur_sync)
            {
                fullUpdate();
            }
        }

        private async void setProtectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                /** New http client for the API request.
                 *  Grabbing the current wanted protection value from the combo. **/
                HttpClient httpProtClient = new HttpClient();
                HttpResponseMessage httpProtClientResponse = await httpProtClient.GetAsync($"https://constelia.ai/api.php?key={Globals.key}&cmd=setProtection&protection={protectionCombo.SelectedIndex}");

                if (httpProtClientResponse.IsSuccessStatusCode)
                {
                    setProtectionButton.Text = "Protection Set!";
                    System.Windows.Forms.Timer protectionTextTimer = new System.Windows.Forms.Timer();
                    protectionTextTimer.Interval = Globals.text_timeout;
                    protectionTextTimer.Tick += (s, ea) =>
                    {
                        setProtectionButton.Text = "Set Protection";
                        protectionTextTimer.Stop();
                    };
                    protectionTextTimer.Start();
                }
                else
                {
                    MessageBox.Show("Failed to set protection.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception thrown. Please contact developer.\n\nException:\n{ex.Message}", "Fatal Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void launchConButton_Click(object sender, EventArgs e)
        {
            // Pull a new constellation.bat straight from the site.
            string conBatchUrl = "https://constelia.ai/constellation.bat";

            // Write the bytes mf
            using (HttpClient conBatchClient = new HttpClient())
            {
                var conBatchResponce = await conBatchClient.GetAsync(conBatchUrl);
                if (conBatchResponce.IsSuccessStatusCode)
                {
                    var conBatchContents = await conBatchResponce.Content.ReadAsByteArrayAsync();
                    File.WriteAllBytes(Globals.con_batch_path, conBatchContents);
                }
                else
                {
                    MessageBox.Show($"Unable to download constellation.bat from {conBatchUrl}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // RUN THAT BIHHHHHHHHHHH
            //you can really see how my attention span disappeared while writing these.
            if (File.Exists(Globals.con_batch_path))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start \"\" \"{Globals.con_batch_path}\"",
                    UseShellExecute = true
                });
            }
        }

        // Same as above tbh
        private async void launchUniButton_Click(object sender, EventArgs e)
        {
            string uniBatchUrl = "https://constelia.ai/launch.bat";

            using (HttpClient uniBatchClient = new HttpClient())
            {
                var uniBatchResponce = await uniBatchClient.GetAsync(uniBatchUrl);
                if (uniBatchResponce.IsSuccessStatusCode)
                {
                    var conBatchContents = await uniBatchResponce.Content.ReadAsByteArrayAsync();
                    File.WriteAllBytes(Globals.uni_batch_path, conBatchContents);
                }
                else
                {
                    MessageBox.Show($"Unable to download constellation.bat from {uniBatchUrl}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (File.Exists(Globals.uni_batch_path))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start \"\" \"{Globals.uni_batch_path}\"",
                    UseShellExecute = true
                });
            }
        }

        // Open forums/divinity/github
        private void forumButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://constelia.ai/forums/index.php");
        }

        private void divinityButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://constelia.ai/divinity/");
        }

        private void gitButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/luinbytes/lucid-dreams/");
        }

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
            loadConfigButton.Enabled = false;
            fullUpdate(); // Might aswell update EVERYTHING in the background aswell as the config contents.
            // Prob not best practice?
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            setConfig();
        }

        private async void resetConfigButton_Click(object sender, EventArgs e)
        {
            Globals.reset_config_count++;
            resetConfigButton.Text = $"Are you sure? ({Globals.reset_config_count}/5)";

            if (Globals.reset_config_count >= 5)
            {
                string baseConfig = @"{
                ""bones"": [4, 7, 10],
                ""constelia.lua"": null,
                ""constellation.lua"": {
                    ""esp"": false,
                    ""esp_fov"": 10,
                    ""esp_sonar"": false,
                    ""esp_surround"": true,
                    ""humanizer"": true,
                    ""humanizer_debug"": true,
                    ""humanizer_mouse_threshold"": 32,
                    ""humanizer_range_max"": 10,
                    ""humanizer_range_min"": 0.6,
                    ""iterations"": 1
                },
                ""fc2.lua"": {
                    ""anti_aliasing"": false,
                    ""change_compositor"": true,
                    ""fps_lock"": false,
                    ""linux_sound_command"": ""play -q"",
                    ""multicore"": null,
                    ""no_base"": false,
                    ""xdotool"": true,
                    ""zombie"": ""explorer.exe"",
                    ""zombie_mm"": true
                }
            }";

                HttpClient resetClient = new HttpClient();
                HttpResponseMessage resetClientResposne = await resetClient.GetAsync($"https://constelia.ai/api.php?key={Globals.key}&cmd=resetConfiguration");

                if (resetClientResposne.IsSuccessStatusCode)
                {
                    Globals.reset_config_count = 0;
                    resetConfigButton.Text = "Config Reset!";
                    configTextBox.Text = baseConfig;
                    System.Windows.Forms.Timer resetTimer = new System.Windows.Forms.Timer();
                    resetTimer.Interval = Globals.text_timeout;
                    resetTimer.Tick += (s, ea) =>
                    {
                        resetConfigButton.Text = "Reset Config";
                        resetTimer.Stop();
                    };
                    resetTimer.Start();
                }
                else
                {
                    MessageBox.Show("Failed to reset config.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 1 Button debugging for end users.
        private void quickDebugButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Setup for debug output.
                var curTime = DateTime.Now;
                string formattedTime = curTime.ToString("dd/MM/yyyy - hh:mm:ss");

                JsonDocument config = JsonDocument.Parse(Globals.configuration);
                string formattedConfig = System.Text.Json.JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });

                bool keyFormatted;
                Regex regex = new Regex(@"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$");
                if (!regex.IsMatch(Globals.key))
                {
                    keyFormatted = false;
                } 
                else
                {
                    keyFormatted = true;
                }

                using (StreamWriter debugWriter = new StreamWriter(Globals.quick_debug_path))
                {
                    debugWriter.WriteLine("------------------------------------");
                    debugWriter.WriteLine($"Lucid Dreams {Globals.VER} Quick Debug Log");
                    debugWriter.WriteLine($"Date/Time: {formattedTime}");
                    debugWriter.WriteLine("------------------------------------");
                    debugWriter.WriteLine("");
                    debugWriter.WriteLine("// User info:");
                    debugWriter.WriteLine($"Username : {Globals.username}");
                    debugWriter.WriteLine($"Is Key Formatted : {keyFormatted}");
                    debugWriter.WriteLine($"FID : {Globals.fid}");
                    debugWriter.WriteLine($"Avatar URL : {Globals.avatar}");
                    debugWriter.WriteLine($"Level : {Globals.level}");
                    debugWriter.WriteLine("");
                    debugWriter.WriteLine("// Software info:");
                    debugWriter.WriteLine($"Protection : {Globals.protection} - {protectionCombo.Text}");
                    debugWriter.WriteLine($"Last Sync : {Globals.last_sync}");
                    debugWriter.WriteLine($"Cur Sync : {Globals.cur_sync}");
                    debugWriter.WriteLine($"Sync Text Reset : {Globals.sync_text_reset}");
                    debugWriter.WriteLine($"Text Timeout : {Globals.text_timeout}");
                    debugWriter.WriteLine($"Logged In : {Globals.logged_in}");
                    debugWriter.WriteLine("");
                    debugWriter.WriteLine("// Raw config:");
                    debugWriter.WriteLine($"{Globals.configuration}");
                    debugWriter.WriteLine("");
                    debugWriter.WriteLine("// Formatted config:");
                    debugWriter.WriteLine($"{formattedConfig}");
                }

                quickDebugButton.Text = "Writing log...";
                System.Windows.Forms.Timer debugTimer = new System.Windows.Forms.Timer();
                debugTimer.Interval = Globals.text_timeout;
                debugTimer.Tick += (s, ea) =>
                {
                    quickDebugButton.Text = "Quick Debug";
                    debugTimer.Stop();
                };
                debugTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File writing failed.\n\n{ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle perk selection and desc updating.
        private void perkCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = perkCombo.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < Globals.perks_list.Count)
            {
                Perks perks = Globals.perks_list[selectedIndex];
                perkDescriptionTextBox.Text = perks.Description;
            }
        }

        private void buyPerkButton_Click(object sender, EventArgs e)
        {

        }

        private void steamAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUsername = steamAccountComboBox.SelectedItem.ToString();
            Steam selectedAccount = Globals.steam.FirstOrDefault(account => account.name == selectedUsername);

            if (selectedAccount != null)
            {
                string formattedTime = DateTimeOffset.FromUnixTimeSeconds(selectedAccount.time).DateTime.ToString();
                steamAccountTextBox.Text = $"Username: {selectedAccount.name}\nPersona: {selectedAccount.persona}\nID: {selectedAccount.id}\nLast Used: {formattedTime}";
            }
        }
    }
}