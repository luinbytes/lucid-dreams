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
            this.aiCard = new MaterialSkin.Controls.MaterialCard();
            this.aiSendButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.aiInputTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.aiMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.loginCard1 = new MaterialSkin.Controls.MaterialCard();
            this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.divinityButton = new MaterialSkin.Controls.MaterialButton();
            this.forumButton = new MaterialSkin.Controls.MaterialButton();
            this.syncButton = new MaterialSkin.Controls.MaterialButton();
            this.regLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.fidLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.postsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.alertsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.scoreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.messagesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.protectionCard = new MaterialSkin.Controls.MaterialCard();
            this.launchUniButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.launchConButton = new MaterialSkin.Controls.MaterialButton();
            this.setProtectionButton = new MaterialSkin.Controls.MaterialButton();
            this.protectionCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.resetConfigButton = new MaterialSkin.Controls.MaterialButton();
            this.saveConfigButton = new MaterialSkin.Controls.MaterialButton();
            this.loadConfigButton = new MaterialSkin.Controls.MaterialButton();
            this.configTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.quickDebugButton = new MaterialSkin.Controls.MaterialButton();
            this.gitButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.versionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.infoLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.aiCard.SuspendLayout();
            this.loginCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.protectionCard.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
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
            this.loginButton.Location = new System.Drawing.Point(20, 90);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(211, 21);
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
            this.tabSelector.Size = new System.Drawing.Size(1171, 50);
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
            this.tabControl.Size = new System.Drawing.Size(1171, 694);
            this.tabControl.TabIndex = 5;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.aiCard);
            this.tabUser.Controls.Add(this.loginCard1);
            this.tabUser.Controls.Add(this.materialCard3);
            this.tabUser.Controls.Add(this.protectionCard);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(0);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(1163, 665);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User Control";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // aiCard
            // 
            this.aiCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aiCard.AutoScroll = true;
            this.aiCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aiCard.Controls.Add(this.aiSendButton);
            this.aiCard.Controls.Add(this.aiInputTextBox);
            this.aiCard.Controls.Add(this.aiMultiLineTextBox);
            this.aiCard.Depth = 0;
            this.aiCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aiCard.Location = new System.Drawing.Point(755, 14);
            this.aiCard.Margin = new System.Windows.Forms.Padding(14);
            this.aiCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.aiCard.Name = "aiCard";
            this.aiCard.Padding = new System.Windows.Forms.Padding(14);
            this.aiCard.Size = new System.Drawing.Size(396, 497);
            this.aiCard.TabIndex = 11;
            // 
            // aiSendButton
            // 
            this.aiSendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aiSendButton.Depth = 0;
            this.aiSendButton.Icon = ((System.Drawing.Image)(resources.GetObject("aiSendButton.Icon")));
            this.aiSendButton.Location = new System.Drawing.Point(342, 504);
            this.aiSendButton.Mini = true;
            this.aiSendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aiSendButton.Name = "aiSendButton";
            this.aiSendButton.Size = new System.Drawing.Size(43, 43);
            this.aiSendButton.TabIndex = 2;
            this.aiSendButton.Text = "send";
            this.aiSendButton.UseVisualStyleBackColor = true;
            // 
            // aiInputTextBox
            // 
            this.aiInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aiInputTextBox.AnimateReadOnly = false;
            this.aiInputTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aiInputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.aiInputTextBox.Depth = 0;
            this.aiInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.aiInputTextBox.HideSelection = true;
            this.aiInputTextBox.Hint = "Ask Constelia...";
            this.aiInputTextBox.LeadingIcon = null;
            this.aiInputTextBox.Location = new System.Drawing.Point(17, 444);
            this.aiInputTextBox.MaxLength = 32767;
            this.aiInputTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.aiInputTextBox.Name = "aiInputTextBox";
            this.aiInputTextBox.PasswordChar = '\0';
            this.aiInputTextBox.PrefixSuffixText = null;
            this.aiInputTextBox.ReadOnly = false;
            this.aiInputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aiInputTextBox.SelectedText = "";
            this.aiInputTextBox.SelectionLength = 0;
            this.aiInputTextBox.SelectionStart = 0;
            this.aiInputTextBox.ShortcutsEnabled = true;
            this.aiInputTextBox.Size = new System.Drawing.Size(361, 36);
            this.aiInputTextBox.TabIndex = 1;
            this.aiInputTextBox.TabStop = false;
            this.aiInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aiInputTextBox.TrailingIcon = null;
            this.aiInputTextBox.UseAccent = false;
            this.aiInputTextBox.UseSystemPasswordChar = false;
            this.aiInputTextBox.UseTallSize = false;
            // 
            // aiMultiLineTextBox
            // 
            this.aiMultiLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aiMultiLineTextBox.AnimateReadOnly = true;
            this.aiMultiLineTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aiMultiLineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.aiMultiLineTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.aiMultiLineTextBox.Depth = 0;
            this.aiMultiLineTextBox.HideSelection = true;
            this.aiMultiLineTextBox.Location = new System.Drawing.Point(17, 18);
            this.aiMultiLineTextBox.MaxLength = 32767;
            this.aiMultiLineTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.aiMultiLineTextBox.Name = "aiMultiLineTextBox";
            this.aiMultiLineTextBox.PasswordChar = '\0';
            this.aiMultiLineTextBox.ReadOnly = true;
            this.aiMultiLineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aiMultiLineTextBox.SelectedText = "";
            this.aiMultiLineTextBox.SelectionLength = 0;
            this.aiMultiLineTextBox.SelectionStart = 0;
            this.aiMultiLineTextBox.ShortcutsEnabled = true;
            this.aiMultiLineTextBox.Size = new System.Drawing.Size(361, 412);
            this.aiMultiLineTextBox.TabIndex = 0;
            this.aiMultiLineTextBox.TabStop = false;
            this.aiMultiLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aiMultiLineTextBox.UseSystemPasswordChar = false;
            // 
            // loginCard1
            // 
            this.loginCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCard1.Controls.Add(this.loginLabel);
            this.loginCard1.Controls.Add(this.loginButton);
            this.loginCard1.Controls.Add(this.keyTextBox);
            this.loginCard1.Depth = 0;
            this.loginCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginCard1.Location = new System.Drawing.Point(13, 526);
            this.loginCard1.Margin = new System.Windows.Forms.Padding(14);
            this.loginCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginCard1.Name = "loginCard1";
            this.loginCard1.Padding = new System.Windows.Forms.Padding(14);
            this.loginCard1.Size = new System.Drawing.Size(249, 122);
            this.loginCard1.TabIndex = 10;
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
            this.materialCard3.Controls.Add(this.divinityButton);
            this.materialCard3.Controls.Add(this.forumButton);
            this.materialCard3.Controls.Add(this.syncButton);
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
            this.materialCard3.Size = new System.Drawing.Size(302, 212);
            this.materialCard3.TabIndex = 9;
            // 
            // divinityButton
            // 
            this.divinityButton.AutoSize = false;
            this.divinityButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divinityButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.divinityButton.Depth = 0;
            this.divinityButton.HighEmphasis = true;
            this.divinityButton.Icon = null;
            this.divinityButton.Location = new System.Drawing.Point(202, 182);
            this.divinityButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.divinityButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.divinityButton.Name = "divinityButton";
            this.divinityButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.divinityButton.Size = new System.Drawing.Size(86, 22);
            this.divinityButton.TabIndex = 8;
            this.divinityButton.Text = "Divinity";
            this.divinityButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.divinityButton.UseAccentColor = false;
            this.divinityButton.UseVisualStyleBackColor = true;
            this.divinityButton.Click += new System.EventHandler(this.divinityButton_Click);
            // 
            // forumButton
            // 
            this.forumButton.AutoSize = false;
            this.forumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forumButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.forumButton.Depth = 0;
            this.forumButton.HighEmphasis = true;
            this.forumButton.Icon = null;
            this.forumButton.Location = new System.Drawing.Point(108, 182);
            this.forumButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.forumButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.forumButton.Name = "forumButton";
            this.forumButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.forumButton.Size = new System.Drawing.Size(86, 22);
            this.forumButton.TabIndex = 8;
            this.forumButton.Text = "Forums";
            this.forumButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.forumButton.UseAccentColor = false;
            this.forumButton.UseVisualStyleBackColor = true;
            this.forumButton.Click += new System.EventHandler(this.forumButton_Click);
            // 
            // syncButton
            // 
            this.syncButton.AutoSize = false;
            this.syncButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.syncButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.syncButton.Depth = 0;
            this.syncButton.Enabled = false;
            this.syncButton.HighEmphasis = true;
            this.syncButton.Icon = null;
            this.syncButton.Location = new System.Drawing.Point(14, 182);
            this.syncButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.syncButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.syncButton.Name = "syncButton";
            this.syncButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.syncButton.Size = new System.Drawing.Size(86, 22);
            this.syncButton.TabIndex = 8;
            this.syncButton.Text = "Sync";
            this.syncButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.syncButton.UseAccentColor = true;
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
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
            this.protectionCard.Location = new System.Drawing.Point(755, 526);
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
            this.setProtectionButton.Location = new System.Drawing.Point(207, 88);
            this.setProtectionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.setProtectionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.setProtectionButton.Name = "setProtectionButton";
            this.setProtectionButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.setProtectionButton.Size = new System.Drawing.Size(171, 27);
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
            this.protectionCombo.Location = new System.Drawing.Point(207, 45);
            this.protectionCombo.MaxDropDownItems = 4;
            this.protectionCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.protectionCombo.Name = "protectionCombo";
            this.protectionCombo.Size = new System.Drawing.Size(171, 35);
            this.protectionCombo.StartIndex = 0;
            this.protectionCombo.TabIndex = 0;
            this.protectionCombo.UseTallSize = false;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.materialCard6);
            this.tabConfig.Controls.Add(this.configTextBox);
            this.tabConfig.Location = new System.Drawing.Point(4, 25);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1163, 665);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.resetConfigButton);
            this.materialCard6.Controls.Add(this.saveConfigButton);
            this.materialCard6.Controls.Add(this.loadConfigButton);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(20, 551);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(1114, 61);
            this.materialCard6.TabIndex = 3;
            // 
            // resetConfigButton
            // 
            this.resetConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetConfigButton.AutoSize = false;
            this.resetConfigButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetConfigButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetConfigButton.Depth = 0;
            this.resetConfigButton.HighEmphasis = true;
            this.resetConfigButton.Icon = null;
            this.resetConfigButton.Location = new System.Drawing.Point(832, 11);
            this.resetConfigButton.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.resetConfigButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetConfigButton.Name = "resetConfigButton";
            this.resetConfigButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetConfigButton.Size = new System.Drawing.Size(268, 36);
            this.resetConfigButton.TabIndex = 0;
            this.resetConfigButton.Text = "Reset Config";
            this.resetConfigButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetConfigButton.UseAccentColor = false;
            this.resetConfigButton.UseVisualStyleBackColor = true;
            this.resetConfigButton.Click += new System.EventHandler(this.resetConfigButton_Click);
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveConfigButton.AutoSize = false;
            this.saveConfigButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveConfigButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveConfigButton.Depth = 0;
            this.saveConfigButton.HighEmphasis = true;
            this.saveConfigButton.Icon = null;
            this.saveConfigButton.Location = new System.Drawing.Point(440, 11);
            this.saveConfigButton.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.saveConfigButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveConfigButton.Size = new System.Drawing.Size(263, 36);
            this.saveConfigButton.TabIndex = 0;
            this.saveConfigButton.Text = "Save Config";
            this.saveConfigButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveConfigButton.UseAccentColor = false;
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // loadConfigButton
            // 
            this.loadConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loadConfigButton.AutoSize = false;
            this.loadConfigButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadConfigButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loadConfigButton.Depth = 0;
            this.loadConfigButton.HighEmphasis = true;
            this.loadConfigButton.Icon = null;
            this.loadConfigButton.Location = new System.Drawing.Point(14, 11);
            this.loadConfigButton.Margin = new System.Windows.Forms.Padding(0);
            this.loadConfigButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadConfigButton.Name = "loadConfigButton";
            this.loadConfigButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loadConfigButton.Size = new System.Drawing.Size(268, 36);
            this.loadConfigButton.TabIndex = 0;
            this.loadConfigButton.Text = "Load Config";
            this.loadConfigButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadConfigButton.UseAccentColor = false;
            this.loadConfigButton.UseVisualStyleBackColor = true;
            this.loadConfigButton.Click += new System.EventHandler(this.loadConfigButton_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configTextBox.AnimateReadOnly = false;
            this.configTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.configTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.configTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.configTextBox.Depth = 0;
            this.configTextBox.HideSelection = true;
            this.configTextBox.Location = new System.Drawing.Point(20, 6);
            this.configTextBox.MaxLength = 32767;
            this.configTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.PasswordChar = '\0';
            this.configTextBox.ReadOnly = false;
            this.configTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.configTextBox.SelectedText = "";
            this.configTextBox.SelectionLength = 0;
            this.configTextBox.SelectionStart = 0;
            this.configTextBox.ShortcutsEnabled = true;
            this.configTextBox.Size = new System.Drawing.Size(1114, 536);
            this.configTextBox.TabIndex = 2;
            this.configTextBox.TabStop = false;
            this.configTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.configTextBox.UseAccent = false;
            this.configTextBox.UseSystemPasswordChar = false;
            // 
            // tabScripts
            // 
            this.tabScripts.Location = new System.Drawing.Point(4, 25);
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabScripts.Size = new System.Drawing.Size(1163, 665);
            this.tabScripts.TabIndex = 2;
            this.tabScripts.Text = "Scripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.materialCard4);
            this.tabSettings.Controls.Add(this.materialCard1);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1163, 665);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialCard5);
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(17, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(308, 588);
            this.materialCard4.TabIndex = 2;
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.quickDebugButton);
            this.materialCard5.Controls.Add(this.gitButton);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(11, 56);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(286, 517);
            this.materialCard5.TabIndex = 1;
            // 
            // quickDebugButton
            // 
            this.quickDebugButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quickDebugButton.AutoSize = false;
            this.quickDebugButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quickDebugButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.quickDebugButton.Depth = 0;
            this.quickDebugButton.HighEmphasis = true;
            this.quickDebugButton.Icon = null;
            this.quickDebugButton.Location = new System.Drawing.Point(18, 62);
            this.quickDebugButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quickDebugButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quickDebugButton.Name = "quickDebugButton";
            this.quickDebugButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.quickDebugButton.Size = new System.Drawing.Size(250, 32);
            this.quickDebugButton.TabIndex = 0;
            this.quickDebugButton.Text = "Quick Debug";
            this.quickDebugButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.quickDebugButton.UseAccentColor = false;
            this.quickDebugButton.UseVisualStyleBackColor = true;
            this.quickDebugButton.Click += new System.EventHandler(this.quickDebugButton_Click);
            // 
            // gitButton
            // 
            this.gitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitButton.AutoSize = false;
            this.gitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gitButton.Depth = 0;
            this.gitButton.HighEmphasis = true;
            this.gitButton.Icon = null;
            this.gitButton.Location = new System.Drawing.Point(18, 18);
            this.gitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gitButton.Name = "gitButton";
            this.gitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gitButton.Size = new System.Drawing.Size(250, 32);
            this.gitButton.TabIndex = 0;
            this.gitButton.Text = "Github";
            this.gitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gitButton.UseAccentColor = false;
            this.gitButton.UseVisualStyleBackColor = true;
            this.gitButton.Click += new System.EventHandler(this.gitButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(16, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Utilities";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.versionLabel);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.infoLabel);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(822, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(308, 588);
            this.materialCard1.TabIndex = 0;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Depth = 0;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.versionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.versionLabel.Location = new System.Drawing.Point(17, 589);
            this.versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(50, 17);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version";
            this.versionLabel.UseAccent = true;
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
            this.materialCard2.Size = new System.Drawing.Size(286, 290);
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
            this.infoLabel1.Size = new System.Drawing.Size(274, 412);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = resources.GetString("infoLabel1.Text");
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
            // avatarBox
            // 
            this.avatarBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarBox.Location = new System.Drawing.Point(1097, 34);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(68, 68);
            this.avatarBox.TabIndex = 2;
            this.avatarBox.TabStop = false;
            this.avatarBox.Visible = false;
            this.avatarBox.WaitOnLoad = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1171, 811);
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
            this.aiCard.ResumeLayout(false);
            this.loginCard1.ResumeLayout(false);
            this.loginCard1.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.protectionCard.ResumeLayout(false);
            this.protectionCard.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton forumButton;
        private MaterialSkin.Controls.MaterialButton divinityButton;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton gitButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 configTextBox;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialButton loadConfigButton;
        private MaterialSkin.Controls.MaterialButton resetConfigButton;
        private MaterialSkin.Controls.MaterialButton saveConfigButton;
        private MaterialSkin.Controls.MaterialLabel versionLabel;
        private MaterialSkin.Controls.MaterialCard aiCard;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 aiMultiLineTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 aiInputTextBox;
        private MaterialSkin.Controls.MaterialFloatingActionButton aiSendButton;
        private MaterialSkin.Controls.MaterialButton quickDebugButton;
    }
}

