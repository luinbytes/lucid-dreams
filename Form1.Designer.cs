namespace lucid_dreams
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.keyTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.protectionCard = new MaterialSkin.Controls.MaterialCard();
            this.launchUniButton = new MaterialSkin.Controls.MaterialButton();
            this.launchConButton = new MaterialSkin.Controls.MaterialButton();
            this.setProtectionButton = new MaterialSkin.Controls.MaterialButton();
            this.protectionCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.regLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fidLabel = new MaterialSkin.Controls.MaterialLabel();
            this.postsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.scoreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.messagesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.alertsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.syncButton = new MaterialSkin.Controls.MaterialButton();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.infoLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.loginCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.protectionCard.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.loginCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(149, 90);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(82, 21);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.AnimateReadOnly = false;
            this.keyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.keyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.keyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyTextBox.Depth = 0;
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keyTextBox.HideSelection = true;
            this.keyTextBox.Hint = "User Key";
            this.keyTextBox.LeadingIcon = null;
            this.keyTextBox.Location = new System.Drawing.Point(20, 45);
            this.keyTextBox.MaxLength = 19;
            this.keyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '*';
            this.keyTextBox.PrefixSuffixText = null;
            this.keyTextBox.ReadOnly = false;
            this.keyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keyTextBox.SelectedText = "";
            this.keyTextBox.SelectionLength = 0;
            this.keyTextBox.SelectionStart = 0;
            this.keyTextBox.ShortcutsEnabled = true;
            this.keyTextBox.Size = new System.Drawing.Size(211, 36);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.TabStop = false;
            this.keyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyTextBox.TrailingIcon = null;
            this.keyTextBox.UseSystemPasswordChar = false;
            this.keyTextBox.UseTallSize = false;
            // 
            // tabSelector
            // 
            this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Proper;
            this.tabSelector.Depth = 0;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(0, 64);
            this.tabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(1010, 50);
            this.tabSelector.TabIndex = 3;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabUser);
            this.tabControl.Controls.Add(this.tabConfig);
            this.tabControl.Controls.Add(this.tabScripts);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 117);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1010, 586);
            this.tabControl.TabIndex = 5;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.loginCard1);
            this.tabUser.Controls.Add(this.materialCard3);
            this.tabUser.Controls.Add(this.protectionCard);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(1002, 557);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User Control";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // protectionCard
            // 
            this.protectionCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.protectionCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.protectionCard.Controls.Add(this.launchUniButton);
            this.protectionCard.Controls.Add(this.materialLabel2);
            this.protectionCard.Controls.Add(this.launchConButton);
            this.protectionCard.Controls.Add(this.setProtectionButton);
            this.protectionCard.Controls.Add(this.protectionCombo);
            this.protectionCard.Depth = 0;
            this.protectionCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.protectionCard.Location = new System.Drawing.Point(589, 428);
            this.protectionCard.Margin = new System.Windows.Forms.Padding(14);
            this.protectionCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.protectionCard.Name = "protectionCard";
            this.protectionCard.Padding = new System.Windows.Forms.Padding(14);
            this.protectionCard.Size = new System.Drawing.Size(396, 122);
            this.protectionCard.TabIndex = 8;
            // 
            // launchUniButton
            // 
            this.launchUniButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.launchUniButton.AutoSize = false;
            this.launchUniButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.launchUniButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.launchUniButton.Depth = 0;
            this.launchUniButton.HighEmphasis = true;
            this.launchUniButton.Icon = null;
            this.launchUniButton.Location = new System.Drawing.Point(18, 88);
            this.launchUniButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.launchUniButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchUniButton.Name = "launchUniButton";
            this.launchUniButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.launchUniButton.Size = new System.Drawing.Size(176, 27);
            this.launchUniButton.TabIndex = 2;
            this.launchUniButton.Text = "Universe4";
            this.launchUniButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.launchUniButton.UseAccentColor = false;
            this.launchUniButton.UseVisualStyleBackColor = true;
            this.launchUniButton.Click += new System.EventHandler(this.launchUniButton_Click);
            // 
            // launchConButton
            // 
            this.launchConButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.launchConButton.AutoSize = false;
            this.launchConButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.launchConButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.launchConButton.Depth = 0;
            this.launchConButton.HighEmphasis = true;
            this.launchConButton.Icon = null;
            this.launchConButton.Location = new System.Drawing.Point(18, 49);
            this.launchConButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.launchConButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchConButton.Name = "launchConButton";
            this.launchConButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.launchConButton.Size = new System.Drawing.Size(176, 27);
            this.launchConButton.TabIndex = 2;
            this.launchConButton.Text = "Constellation4";
            this.launchConButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.launchConButton.UseAccentColor = false;
            this.launchConButton.UseVisualStyleBackColor = true;
            this.launchConButton.Click += new System.EventHandler(this.launchConButton_Click);
            // 
            // setProtectionButton
            // 
            this.setProtectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setProtectionButton.AutoSize = false;
            this.setProtectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setProtectionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.setProtectionButton.Depth = 0;
            this.setProtectionButton.HighEmphasis = true;
            this.setProtectionButton.Icon = null;
            this.setProtectionButton.Location = new System.Drawing.Point(207, 93);
            this.setProtectionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.setProtectionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.setProtectionButton.Name = "setProtectionButton";
            this.setProtectionButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.setProtectionButton.Size = new System.Drawing.Size(171, 22);
            this.setProtectionButton.TabIndex = 1;
            this.setProtectionButton.Text = "Set Protection";
            this.setProtectionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.setProtectionButton.UseAccentColor = false;
            this.setProtectionButton.UseVisualStyleBackColor = true;
            this.setProtectionButton.Click += new System.EventHandler(this.setProtectionButton_Click);
            // 
            // protectionCombo
            // 
            this.protectionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.protectionCombo.AutoResize = false;
            this.protectionCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.protectionCombo.Depth = 0;
            this.protectionCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.protectionCombo.DropDownHeight = 118;
            this.protectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protectionCombo.DropDownWidth = 121;
            this.protectionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.protectionCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.protectionCombo.FormattingEnabled = true;
            this.protectionCombo.Hint = "Protection";
            this.protectionCombo.IntegralHeight = false;
            this.protectionCombo.ItemHeight = 29;
            this.protectionCombo.Items.AddRange(new object[] {
            "Standard",
            "IPC/Zombie",
            "Kernel",
            "Min Usermode",
            "Min Kernel"});
            this.protectionCombo.Location = new System.Drawing.Point(207, 49);
            this.protectionCombo.MaxDropDownItems = 4;
            this.protectionCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.protectionCombo.Name = "protectionCombo";
            this.protectionCombo.Size = new System.Drawing.Size(171, 35);
            this.protectionCombo.StartIndex = 0;
            this.protectionCombo.TabIndex = 0;
            this.protectionCombo.UseTallSize = false;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Depth = 0;
            this.regLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regLabel.Location = new System.Drawing.Point(11, 157);
            this.regLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(75, 19);
            this.regLabel.TabIndex = 1;
            this.regLabel.Text = "Registered";
            // 
            // fidLabel
            // 
            this.fidLabel.AutoSize = true;
            this.fidLabel.Depth = 0;
            this.fidLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fidLabel.Location = new System.Drawing.Point(11, 138);
            this.fidLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fidLabel.Name = "fidLabel";
            this.fidLabel.Size = new System.Drawing.Size(77, 19);
            this.fidLabel.TabIndex = 1;
            this.fidLabel.Text = "Fantasy ID";
            // 
            // postsLabel
            // 
            this.postsLabel.AutoSize = true;
            this.postsLabel.Depth = 0;
            this.postsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.postsLabel.Location = new System.Drawing.Point(11, 119);
            this.postsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.postsLabel.Name = "postsLabel";
            this.postsLabel.Size = new System.Drawing.Size(41, 19);
            this.postsLabel.TabIndex = 1;
            this.postsLabel.Text = "Posts";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Depth = 0;
            this.scoreLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scoreLabel.Location = new System.Drawing.Point(11, 100);
            this.scoreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 19);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score";
            // 
            // messagesLabel
            // 
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Depth = 0;
            this.messagesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.messagesLabel.Location = new System.Drawing.Point(11, 81);
            this.messagesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(127, 19);
            this.messagesLabel.TabIndex = 1;
            this.messagesLabel.Text = "Unread Messages";
            // 
            // alertsLabel
            // 
            this.alertsLabel.AutoSize = true;
            this.alertsLabel.Depth = 0;
            this.alertsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.alertsLabel.Location = new System.Drawing.Point(11, 62);
            this.alertsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.alertsLabel.Name = "alertsLabel";
            this.alertsLabel.Size = new System.Drawing.Size(95, 19);
            this.alertsLabel.TabIndex = 1;
            this.alertsLabel.Text = "Unread Alerts";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.usernameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.usernameLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.usernameLabel.Location = new System.Drawing.Point(10, 38);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Logged Out!";
            // 
            // syncButton
            // 
            this.syncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.syncButton.AutoSize = false;
            this.syncButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.syncButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.syncButton.Depth = 0;
            this.syncButton.Enabled = false;
            this.syncButton.HighEmphasis = true;
            this.syncButton.Icon = null;
            this.syncButton.Location = new System.Drawing.Point(21, 90);
            this.syncButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.syncButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.syncButton.Name = "syncButton";
            this.syncButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.syncButton.Size = new System.Drawing.Size(82, 22);
            this.syncButton.TabIndex = 8;
            this.syncButton.Text = "Sync";
            this.syncButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.syncButton.UseAccentColor = true;
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.Location = new System.Drawing.Point(4, 25);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(986, 518);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tabScripts
            // 
            this.tabScripts.Location = new System.Drawing.Point(4, 25);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabScripts.Size = new System.Drawing.Size(986, 518);
            this.tabScripts.TabIndex = 2;
            this.tabScripts.Text = "Scripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.materialCard1);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1002, 557);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.infoLabel);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(665, 7);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(308, 543);
            this.materialCard1.TabIndex = 0;
            // 
            // avatarBox
            // 
            this.avatarBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarBox.Location = new System.Drawing.Point(936, 34);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(68, 68);
            this.avatarBox.TabIndex = 2;
            this.avatarBox.TabStop = false;
            this.avatarBox.Visible = false;
            this.avatarBox.WaitOnLoad = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.infoLabel.HighEmphasis = true;
            this.infoLabel.Location = new System.Drawing.Point(16, 14);
            this.infoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(36, 24);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Info";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.infoLabel1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(11, 56);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(286, 477);
            this.materialCard2.TabIndex = 1;
            // 
            // infoLabel1
            // 
            this.infoLabel1.Depth = 0;
            this.infoLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel1.Location = new System.Drawing.Point(6, 14);
            this.infoLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.infoLabel1.Size = new System.Drawing.Size(274, 459);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "Running Kernel mode?\r\nPlease run Lucid Dreams as admin.\r\n\r\nWhen will <feature> be" +
    " added?\r\nNo clue. I\'m not very smart.";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Depth = 0;
            this.loginLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.loginLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.loginLabel.HighEmphasis = true;
            this.loginLabel.Location = new System.Drawing.Point(16, 14);
            this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 24);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Login";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.regLabel);
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Controls.Add(this.fidLabel);
            this.materialCard3.Controls.Add(this.usernameLabel);
            this.materialCard3.Controls.Add(this.postsLabel);
            this.materialCard3.Controls.Add(this.alertsLabel);
            this.materialCard3.Controls.Add(this.scoreLabel);
            this.materialCard3.Controls.Add(this.messagesLabel);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(13, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(333, 191);
            this.materialCard3.TabIndex = 9;
            // 
            // loginCard1
            // 
            this.loginCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCard1.Controls.Add(this.syncButton);
            this.loginCard1.Controls.Add(this.loginLabel);
            this.loginCard1.Controls.Add(this.loginButton);
            this.loginCard1.Controls.Add(this.keyTextBox);
            this.loginCard1.Depth = 0;
            this.loginCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginCard1.Location = new System.Drawing.Point(13, 428);
            this.loginCard1.Margin = new System.Windows.Forms.Padding(14);
            this.loginCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginCard1.Name = "loginCard1";
            this.loginCard1.Padding = new System.Windows.Forms.Padding(14);
            this.loginCard1.Size = new System.Drawing.Size(249, 122);
            this.loginCard1.TabIndex = 10;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(10, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Forum Stats";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Software Control";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1010, 709);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.tabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lucid Dreams [BETA]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.protectionCard.ResumeLayout(false);
            this.protectionCard.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.loginCard1.ResumeLayout(false);
            this.loginCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialTextBox2 keyTextBox;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabScripts;
        private System.Windows.Forms.TabPage tabSettings;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialLabel alertsLabel;
        private MaterialSkin.Controls.MaterialLabel messagesLabel;
        private MaterialSkin.Controls.MaterialLabel regLabel;
        private MaterialSkin.Controls.MaterialLabel fidLabel;
        private MaterialSkin.Controls.MaterialLabel postsLabel;
        private MaterialSkin.Controls.MaterialLabel scoreLabel;
        private System.Windows.Forms.PictureBox avatarBox;
        private MaterialSkin.Controls.MaterialButton syncButton;
        private MaterialSkin.Controls.MaterialCard protectionCard;
        private MaterialSkin.Controls.MaterialComboBox protectionCombo;
        private MaterialSkin.Controls.MaterialButton setProtectionButton;
        private MaterialSkin.Controls.MaterialButton launchUniButton;
        private MaterialSkin.Controls.MaterialButton launchConButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel infoLabel;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel infoLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel loginLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard loginCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

