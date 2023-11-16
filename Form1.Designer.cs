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
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.infoCard = new MaterialSkin.Controls.MaterialCard();
            this.regLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fidLabel = new MaterialSkin.Controls.MaterialLabel();
            this.postsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.scoreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.messagesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.alertsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loginCard = new MaterialSkin.Controls.MaterialCard();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.syncButton = new MaterialSkin.Controls.MaterialButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.infoCard.SuspendLayout();
            this.loginCard.SuspendLayout();
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
            this.loginButton.Location = new System.Drawing.Point(161, 10);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(67, 48);
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
            this.keyTextBox.Location = new System.Drawing.Point(5, 10);
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
            this.keyTextBox.Size = new System.Drawing.Size(142, 48);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.TabStop = false;
            this.keyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyTextBox.TrailingIcon = null;
            this.keyTextBox.UseSystemPasswordChar = false;
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
            this.tabSelector.Size = new System.Drawing.Size(1054, 50);
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
            this.tabControl.Size = new System.Drawing.Size(1054, 560);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.syncButton);
            this.tabPage1.Controls.Add(this.avatarBox);
            this.tabPage1.Controls.Add(this.infoCard);
            this.tabPage1.Controls.Add(this.loginCard);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // avatarBox
            // 
            this.avatarBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.avatarBox.Location = new System.Drawing.Point(13, 347);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(100, 100);
            this.avatarBox.TabIndex = 2;
            this.avatarBox.TabStop = false;
            this.avatarBox.WaitOnLoad = true;
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
            this.loginCard.Controls.Add(this.keyTextBox);
            this.loginCard.Controls.Add(this.loginButton);
            this.loginCard.Depth = 0;
            this.loginCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginCard.Location = new System.Drawing.Point(13, 453);
            this.loginCard.Margin = new System.Windows.Forms.Padding(14);
            this.loginCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginCard.Name = "loginCard";
            this.loginCard.Padding = new System.Windows.Forms.Padding(14);
            this.loginCard.Size = new System.Drawing.Size(239, 64);
            this.loginCard.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(973, 682);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scripts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // syncButton
            // 
            this.syncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.syncButton.AutoSize = false;
            this.syncButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.syncButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.syncButton.Depth = 0;
            this.syncButton.HighEmphasis = true;
            this.syncButton.Icon = null;
            this.syncButton.Location = new System.Drawing.Point(120, 411);
            this.syncButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.syncButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.syncButton.Name = "syncButton";
            this.syncButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.syncButton.Size = new System.Drawing.Size(75, 36);
            this.syncButton.TabIndex = 8;
            this.syncButton.Text = "Sync";
            this.syncButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.syncButton.UseAccentColor = false;
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 683);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lucid Dreams [BETA]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.infoCard.ResumeLayout(false);
            this.infoCard.PerformLayout();
            this.loginCard.ResumeLayout(false);
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
    }
}

