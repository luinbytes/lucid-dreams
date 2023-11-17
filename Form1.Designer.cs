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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.protectionCard = new MaterialSkin.Controls.MaterialCard();
            this.setProtectionButton = new MaterialSkin.Controls.MaterialButton();
            this.protectionCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.infoCard = new MaterialSkin.Controls.MaterialCard();
            this.regLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fidLabel = new MaterialSkin.Controls.MaterialLabel();
            this.postsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.scoreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.messagesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.alertsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loginCard = new MaterialSkin.Controls.MaterialCard();
            this.syncButton = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.protectionCard.SuspendLayout();
            this.infoCard.SuspendLayout();
            this.loginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(138, 51);
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
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.keyTextBox.AnimateReadOnly = false;
            this.keyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.keyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.keyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyTextBox.Depth = 0;
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keyTextBox.HideSelection = true;
            this.keyTextBox.Hint = "User Key";
            this.keyTextBox.LeadingIcon = null;
            this.keyTextBox.Location = new System.Drawing.Point(18, 5);
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
            this.keyTextBox.Size = new System.Drawing.Size(203, 36);
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
            this.tabSelector.Size = new System.Drawing.Size(929, 50);
            this.tabSelector.TabIndex = 3;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 117);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(929, 540);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.protectionCard);
            this.tabPage1.Controls.Add(this.infoCard);
            this.tabPage1.Controls.Add(this.loginCard);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // protectionCard
            // 
            this.protectionCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.protectionCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.protectionCard.Controls.Add(this.setProtectionButton);
            this.protectionCard.Controls.Add(this.protectionCombo);
            this.protectionCard.Depth = 0;
            this.protectionCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.protectionCard.Location = new System.Drawing.Point(699, 425);
            this.protectionCard.Margin = new System.Windows.Forms.Padding(14);
            this.protectionCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.protectionCard.Name = "protectionCard";
            this.protectionCard.Padding = new System.Windows.Forms.Padding(14);
            this.protectionCard.Size = new System.Drawing.Size(205, 79);
            this.protectionCard.TabIndex = 8;
            // 
            // setProtectionButton
            // 
            this.setProtectionButton.AutoSize = false;
            this.setProtectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setProtectionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.setProtectionButton.Depth = 0;
            this.setProtectionButton.HighEmphasis = true;
            this.setProtectionButton.Icon = null;
            this.setProtectionButton.Location = new System.Drawing.Point(17, 51);
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
            this.protectionCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.protectionCombo.Location = new System.Drawing.Point(17, 7);
            this.protectionCombo.MaxDropDownItems = 4;
            this.protectionCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.protectionCombo.Name = "protectionCombo";
            this.protectionCombo.Size = new System.Drawing.Size(171, 35);
            this.protectionCombo.StartIndex = 0;
            this.protectionCombo.TabIndex = 0;
            this.protectionCombo.UseTallSize = false;
            // 
            // infoCard
            // 
            this.infoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoCard.Controls.Add(this.regLabel);
            this.infoCard.Controls.Add(this.fidLabel);
            this.infoCard.Controls.Add(this.postsLabel);
            this.infoCard.Controls.Add(this.scoreLabel);
            this.infoCard.Controls.Add(this.messagesLabel);
            this.infoCard.Controls.Add(this.alertsLabel);
            this.infoCard.Controls.Add(this.usernameLabel);
            this.infoCard.Depth = 0;
            this.infoCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoCard.Location = new System.Drawing.Point(13, 14);
            this.infoCard.Margin = new System.Windows.Forms.Padding(14);
            this.infoCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoCard.Name = "infoCard";
            this.infoCard.Padding = new System.Windows.Forms.Padding(14);
            this.infoCard.Size = new System.Drawing.Size(315, 155);
            this.infoCard.TabIndex = 7;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Depth = 0;
            this.regLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regLabel.Location = new System.Drawing.Point(4, 125);
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
            this.fidLabel.Location = new System.Drawing.Point(4, 106);
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
            this.postsLabel.Location = new System.Drawing.Point(4, 87);
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
            this.scoreLabel.Location = new System.Drawing.Point(4, 68);
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
            this.messagesLabel.Location = new System.Drawing.Point(4, 49);
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
            this.alertsLabel.Location = new System.Drawing.Point(4, 30);
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
            this.usernameLabel.Location = new System.Drawing.Point(3, 6);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Logged Out!";
            // 
            // loginCard
            // 
            this.loginCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginCard.Controls.Add(this.syncButton);
            this.loginCard.Controls.Add(this.keyTextBox);
            this.loginCard.Controls.Add(this.loginButton);
            this.loginCard.Depth = 0;
            this.loginCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginCard.Location = new System.Drawing.Point(13, 425);
            this.loginCard.Margin = new System.Windows.Forms.Padding(14);
            this.loginCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginCard.Name = "loginCard";
            this.loginCard.Padding = new System.Windows.Forms.Padding(14);
            this.loginCard.Size = new System.Drawing.Size(238, 79);
            this.loginCard.TabIndex = 6;
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
            this.syncButton.Location = new System.Drawing.Point(18, 50);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scripts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // avatarBox
            // 
            this.avatarBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarBox.Location = new System.Drawing.Point(840, 36);
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
            this.ClientSize = new System.Drawing.Size(929, 663);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.tabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lucid Dreams [BETA]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.protectionCard.ResumeLayout(false);
            this.infoCard.ResumeLayout(false);
            this.infoCard.PerformLayout();
            this.loginCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialTextBox2 keyTextBox;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCard loginCard;
        private MaterialSkin.Controls.MaterialCard infoCard;
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
    }
}

