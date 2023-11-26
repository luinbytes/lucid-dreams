using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace lucid_dreams
{
    public partial class MainForm : MaterialForm
    {
        public static string GlobalUserKey;
        public static string GlobalUsername = "Logged Out!";
        // public static string GlobalKeyLink;
        // public static string GlobalKeyStop;
        public static string GlobalLevel;
        public static string GlobalProtection;
        public static string GlobalFid;
        public static string GlobalUnreadConversations;
        public static string GlobalUnreadAlerts;
        public static string GlobalRegisterDate;
        public static string GlobalPosts;
        public static string GlobalScore;
        public static string AvatarURL;
        public static string GlobalConfig;
        public static string SessionHistory;

        private StringBuilder outputBuilder = new StringBuilder();
        private StringBuilder errorBuilder = new StringBuilder();

        string userKey;
        bool loggedIn = false;
        bool autoKey;
        bool curSync;
        bool syncFinished;
        bool showSync = false;
        bool syncTextReset = false;
        int textTimeOut = 3000; // 3 Seconds
        string VERSION = "0.1.2";

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
            versionLabel.Text = $"v{VERSION}";

            // Key check
            string keyDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.txt");
            if (File.Exists(keyDir))
            {
                userKey = File.ReadAllText(keyDir);
                keyTextBox.Text = userKey;
                autoKey = true;
                // Forces a full webAPI refresh
                fullUpdate();
            }
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
                    if (!autoKey)
                    {
                        userKey = keyTextBox.Text;
                    }
                    // Check if there is already a sync task running. If not, start one.
                    if (!curSync)
                    {
                        curSync = true;
                        syncButton.Text = "Syncing";
                        syncButton.Enabled = false;

                        /** We need to check if the key is a valid format before running the API request.
                        *   This is ESSENTIAL to ensure users wont get false API banned. **/
                        Regex regex = new Regex(@"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$");
                        if (!regex.IsMatch(userKey))
                        {
                            MessageBox.Show("Your key was an invalid format! Wanted format: ABCD-EFGH-IJKL-MNOP.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Timer for sync button text to reset back to normal.
                        System.Windows.Forms.Timer syncButtonTimer = new System.Windows.Forms.Timer();
                        syncButtonTimer.Interval = 5000;
                        syncButtonTimer.Tick += (s, ea) =>
                        {
                            syncButton.Text = "Sync";
                            syncButton.Enabled = true;
                            syncTextReset = true;
                            syncButtonTimer.Stop();
                        };
                        syncButtonTimer.Start();

                        // Base URL is the main APi request here. It grabs ALL user info except sessions, so we need to run a request for that seperately.
                        string baseUrl = $"https://constelia.ai/api.php?key={userKey}";
                        HttpResponseMessage globalResponse = await client.GetAsync(baseUrl);
                        HttpResponseMessage sessionResponse = await client.GetAsync($"https://constelia.ai/api.php?key={userKey}&cmd=getMember&history");

                        // Check if both responses are good.
                        if (globalResponse.IsSuccessStatusCode && sessionResponse.IsSuccessStatusCode)
                        {
                            // Converting both results right to strings makes this process a lot simpler.
                            string globalResult = await globalResponse.Content.ReadAsStringAsync();
                            string sessionResult = await sessionResponse.Content.ReadAsStringAsync();
                            
                            // Ensure the GlobalUserKey is stored for future use.
                            GlobalUserKey = userKey;

                            // Parsing both results and getting their root.
                            var globalJson = JsonDocument.Parse(globalResult);
                            var sessionJson = JsonDocument.Parse(sessionResult);
                            var globalRoot = globalJson.RootElement;
                            var sessionRoot = sessionJson.RootElement;

                            // Store json parsing results into their globals.
                            if (globalRoot.TryGetProperty("username", out var memberProperty) && memberProperty.ValueKind == JsonValueKind.String)
                            {
                                GlobalUsername = memberProperty.GetString();
                            }
                            else
                            {
                                GlobalUsername = "Logged out!";
                            }

                            if (globalRoot.TryGetProperty("level", out var levelProperty) && levelProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalLevel = levelProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalLevel = "0";
                            }

                            if (globalRoot.TryGetProperty("protection", out var protectionProperty) && protectionProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalProtection = protectionProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalProtection = "0";
                            }

                            if (globalRoot.TryGetProperty("fid", out var fidProperty) && fidProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalFid = fidProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalFid = "0";
                            }

                            if (globalRoot.TryGetProperty("unread_conversations", out var unreadConversationsProperty) && unreadConversationsProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalUnreadConversations = unreadConversationsProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalUnreadConversations = "0";
                            }

                            if (globalRoot.TryGetProperty("unread_alerts", out var unreadAlertsProperty) && unreadAlertsProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalUnreadAlerts = unreadAlertsProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalUnreadAlerts = "0";
                            }

                            if (globalRoot.TryGetProperty("register_date", out var registerDateProperty) && registerDateProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalRegisterDate = DateTimeOffset.FromUnixTimeSeconds(registerDateProperty.GetInt64()).DateTime.ToString();
                            }
                            else
                            {
                                GlobalRegisterDate = DateTime.Now.ToString();
                            }

                            if (globalRoot.TryGetProperty("posts", out var postsProperty) && postsProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalPosts = postsProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalPosts = "0";
                            }

                            if (globalRoot.TryGetProperty("score", out var scoreProperty) && scoreProperty.ValueKind == JsonValueKind.Number)
                            {
                                GlobalScore = scoreProperty.GetInt32().ToString();
                            }
                            else
                            {
                                GlobalScore = "0";
                            }

                            if (globalRoot.TryGetProperty("avatar", out var avatarURLProperty) && avatarURLProperty.ValueKind == JsonValueKind.String)
                            {
                                AvatarURL = avatarURLProperty.GetString();
                            }
                            else
                            {
                                AvatarURL = "null";
                            }

                            if (globalRoot.TryGetProperty("configuration", out var configProperty) && configProperty.ValueKind == JsonValueKind.Object)
                            {
                                GlobalConfig = configProperty.GetRawText();
                            }
                            else
                            {
                                GlobalConfig = "{}";
                            }

                            if (sessionRoot.TryGetProperty("session_history", out var sessionProperty) && sessionProperty.ValueKind == JsonValueKind.Object)
                            {
                                SessionHistory = sessionProperty.GetRawText();
                            }
                            else
                            {
                                SessionHistory = "{}";
                            }

                            // Update UI
                            // Info Panels
                            usernameLabel.Text = $"Welcome {GlobalUsername}";
                            alertsLabel.Text = $"Unread Alerts: {GlobalUnreadAlerts}";
                            messagesLabel.Text = $"Unread Messages: {GlobalUnreadConversations}";
                            scoreLabel.Text = $"Score: {GlobalScore}";
                            postsLabel.Text = $"Posts: {GlobalPosts}";
                            fidLabel.Text = $"Fantasy ID: {GlobalFid}";
                            regLabel.Text = $"Registered: {GlobalRegisterDate}";

                            // Set Avatar Box Elements
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            gp.AddEllipse(0, 0, avatarBox.Width - 4, avatarBox.Height - 4);
                            Region rg = new Region(gp);
                            avatarBox.Region = rg;
                            avatarBox.Visible = true;
                            avatarBox.Size = new Size(68, 68);
                            avatarBox.ImageLocation = AvatarURL;
                            avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;

                            // Protection
                            protectionCombo.SelectedIndex = Int32.Parse(GlobalProtection);

                            // Sync
                            syncFinished = true;
                            showSync = true;
                            if (showSync)
                            {
                                loginButton.Enabled = false;
                                keyTextBox.Enabled = false;
                            }
                            curSync = false;
                            if (!loggedIn)
                            {
                                syncButton.Enabled = false;
                            }
                            else
                            {
                                syncButton.Enabled = true;
                            }

                            // Config
                            JsonDocument config = JsonDocument.Parse(GlobalConfig);
                            string formattedConfig = System.Text.Json.JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                            configTextBox.Text = formattedConfig;
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
                                            MessageBox.Show($"Unable to download file from {launchBatUrl}", "Fatal Error", MessageBoxButtons.OK);
                                            return;
                                        }
                                    }
                                    if (File.Exists(launchBatPath))
                                    {
                                        Process.Start("cmd.exe", $"/c start \"\" \"{launchBatPath}\"");
                                    }
                                    else
                                    {
                                        MessageBox.Show("launch.bat does not exist.", "Fatal Error", MessageBoxButtons.OK);
                                    }
                                }
                                /** We need to remember to set the sync var to false whenever a sync is not in process!
                                 *  Especially when stopped due to unexpected errors. **/
                                curSync = false;
                            }
                            else
                            {
                                MessageBox.Show($"{globalResponse.StatusCode}");
                            }
                        }
                        // Once again, making sure we remember to update this var when needed.
                        curSync = false;
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
                string fullConfig = configTextBox.Text;
                string encodedConfig = HttpUtility.UrlEncode(fullConfig);
                HttpClient configClient = new HttpClient();
                StringContent configContent = new StringContent($"value={encodedConfig}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage saveResponse = await configClient.PostAsync($"https://constelia.ai/api.php?key={userKey}&cmd=setConfiguration", configContent);

                if (saveResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Config Saved!\n\n{configContent}");
                } 
                else
                {
                    MessageBox.Show($"Config failed to save!\n\n {saveResponse.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception caught. Please contact developer.\n\n{ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void loginButton_click(object sender, EventArgs e)
        {
            // If the login button was clicked and there isn't currently a sync task running then run a full update.
            if (!curSync)
            {
                fullUpdate();
            }
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            // Same as login but for the sync button :)
            if (!curSync)
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
                HttpResponseMessage httpProtClientResponse = await httpProtClient.GetAsync($"https://constelia.ai/api.php?key={userKey}&cmd=setProtection&protection={protectionCombo.SelectedIndex}");

                if (httpProtClientResponse.IsSuccessStatusCode)
                {
                    setProtectionButton.Text = "Protection Set!";
                    System.Windows.Forms.Timer protectionTextTimer = new System.Windows.Forms.Timer();
                    protectionTextTimer.Interval = textTimeOut;
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
            // Find where the lucid dreams exe is currently stored and grab the full path.
            string conBatchPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "constellation.bat");
            // Pull a new constellation.bat straight from the site.
            string conBatchUrl = "https://constelia.ai/constellation.bat";

            // Write the bytes mf
            using (HttpClient conBatchClient = new HttpClient())
            {
                var conBatchResponce = await conBatchClient.GetAsync(conBatchUrl);
                if (conBatchResponce.IsSuccessStatusCode)
                {
                    var conBatchContents = await conBatchResponce.Content.ReadAsByteArrayAsync();
                    File.WriteAllBytes(conBatchPath, conBatchContents);
                }
                else
                {
                    MessageBox.Show($"Unable to download constellation.bat from {conBatchUrl}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // RUN THAT BIHHHHHHHHHHH
            //you can really see how my attention span disappeared while writing these.
            if (File.Exists(conBatchPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start \"\" \"{conBatchPath}\"",
                    UseShellExecute = true
                });
            }
        }

        // Same as above tbh
        private async void launchUniButton_Click(object sender, EventArgs e)
        {
            string uniBatchPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "launch.bat");
            string uniBatchUrl = "https://constelia.ai/launch.bat";

            using (HttpClient uniBatchClient = new HttpClient())
            {
                var uniBatchResponce = await uniBatchClient.GetAsync(uniBatchUrl);
                if (uniBatchResponce.IsSuccessStatusCode)
                {
                    var conBatchContents = await uniBatchResponce.Content.ReadAsByteArrayAsync();
                    File.WriteAllBytes(uniBatchPath, conBatchContents);
                }
                else
                {
                    MessageBox.Show($"Unable to download constellation.bat from {uniBatchUrl}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (File.Exists(uniBatchPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start \"\" \"{uniBatchPath}\"",
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
            System.Diagnostics.Process.Start("https://constelia.ai/divinity.php");
        }

        private void gitButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/luinbytes/lucid-dreams/");
        }

        private void loadConfigButton_Click(object sender, EventArgs e)
        {
            fullUpdate(); // Might aswell update EVERYTHING in the background aswell as the config contents.
            // Prob not best practice?
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            setConfig();
        }
    }
}