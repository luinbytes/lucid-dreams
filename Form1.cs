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
        bool autoKey;
        bool curSync;
        bool syncFinished;
        bool showSync = false;
        bool syncTextReset = false;
        int textTimeOut = 3000; // 3 Seconds
        string VERSION = "0.1.1";

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Sizable = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple200, Primary.Purple300, Primary.Purple500, Accent.DeepPurple400, TextShade.WHITE);

            string keyDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.txt");
            if (File.Exists(keyDir))
            {
                userKey = File.ReadAllText(keyDir);
                keyTextBox.Text = userKey;
                autoKey = true;
                fullUpdate();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Functions
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

        private async void fullUpdate()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (!autoKey)
                    {
                        userKey = keyTextBox.Text;
                    }
                    if (!curSync)
                    {
                        curSync = true;
                        syncButton.Text = "Syncing";
                        syncButton.Enabled = false;
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

                        Regex regex = new Regex(@"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$");
                        if (!regex.IsMatch(userKey))
                        {
                            MessageBox.Show("Your key was an invalid format! Wanted format: ABCD-EFGH-IJKL-MNOP.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string baseUrl = $"https://constelia.ai/api.php?key={userKey}";
                        HttpResponseMessage globalResponse = await client.GetAsync(baseUrl);
                        HttpResponseMessage sessionResponse = await client.GetAsync($"https://constelia.ai/api.php?key={userKey}&cmd=getMember&history");

                        if (globalResponse.IsSuccessStatusCode && sessionResponse.IsSuccessStatusCode)
                        {
                            string globalResult = await globalResponse.Content.ReadAsStringAsync();
                            string sessionResult = await sessionResponse.Content.ReadAsStringAsync();
                            GlobalUserKey = userKey;

                            var globalJson = JsonDocument.Parse(globalResult);
                            var sessionJson = JsonDocument.Parse(sessionResult);
                            var globalRoot = globalJson.RootElement;
                            var sessionRoot = sessionJson.RootElement;

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

                            //Update UI
                            //Info Panels
                            usernameLabel.Text = $"Welcome {GlobalUsername}";
                            alertsLabel.Text = $"Unread Alerts: {GlobalUnreadAlerts}";
                            messagesLabel.Text = $"Unread Messages: {GlobalUnreadConversations}";
                            scoreLabel.Text = $"Score: {GlobalScore}";
                            postsLabel.Text = $"Posts: {GlobalPosts}";
                            fidLabel.Text = $"Fantasy ID: {GlobalFid}";
                            regLabel.Text = $"Registered: {GlobalRegisterDate}";

                            //Set Avatar Box Elements
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            gp.AddEllipse(0, 0, avatarBox.Width - 4, avatarBox.Height - 4);
                            Region rg = new Region(gp);
                            avatarBox.Region = rg;
                            avatarBox.Visible = true;
                            avatarBox.Size = new Size(68, 68);
                            avatarBox.ImageLocation = AvatarURL;
                            avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;

                            //Protection
                            protectionCombo.SelectedIndex = Int32.Parse(GlobalProtection);

                            //TO-DO Update rest of the UI elements
                            syncFinished = true;
                            showSync = true;
                            if (showSync)
                            {
                                loginButton.Enabled = false;
                                keyTextBox.Enabled = false;
                            }
                            curSync = false;
                        }
                        else
                        {
                            if (globalResponse.StatusCode == HttpStatusCode.Unauthorized)
                            {
                                DialogResult runLaunchbat = MessageBox.Show("This either means you don't have an active session or your hash is missmatched.\n\nRun launch.bat to set a session?", "Error Unauthorized", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
                                curSync = false;
                            }
                            else
                            {
                                MessageBox.Show($"{globalResponse.StatusCode}");
                            }
                        }
                        curSync = false;
                    }
                }
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

        private async void loginButton_click(object sender, EventArgs e)
        {
            if (!curSync)
            {
                fullUpdate();
            }
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            if (!curSync)
            {
                fullUpdate();
            }
        }

        private async void setProtectionButton_Click(object sender, EventArgs e)
        {
            try
            {
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
            string conBatchPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "constellation.bat");
            string conBatchUrl = "https://constelia.ai/constellation.bat";

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
    }
}