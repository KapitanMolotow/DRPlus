namespace PlayStationSharp.TestApp
{
	partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnLogin = new System.Windows.Forms.Button();
            this.UserId = new System.Windows.Forms.Label();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.lblFriends = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.colorBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.btnBackgroundImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 22);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login with PlayStation";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.ForeColor = System.Drawing.Color.White;
            this.UserId.Location = new System.Drawing.Point(12, 11);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(69, 16);
            this.UserId.TabIndex = 1;
            this.UserId.Text = "Username";
            this.UserId.Visible = false;
            // 
            // lstFriends
            // 
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.Location = new System.Drawing.Point(361, 28);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(138, 238);
            this.lstFriends.TabIndex = 2;
            this.lstFriends.Visible = false;
            this.lstFriends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFriends_MouseDoubleClick);
            // 
            // lblFriends
            // 
            this.lblFriends.AutoSize = true;
            this.lblFriends.Location = new System.Drawing.Point(358, 12);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(41, 13);
            this.lblFriends.TabIndex = 3;
            this.lblFriends.Text = "Friends";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(12, 243);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(151, 23);
            this.btnBackgroundColor.TabIndex = 4;
            this.btnBackgroundColor.Text = "Background Color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Visible = false;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnBackgroundImage
            // 
            this.btnBackgroundImage.Location = new System.Drawing.Point(204, 243);
            this.btnBackgroundImage.Name = "btnBackgroundImage";
            this.btnBackgroundImage.Size = new System.Drawing.Size(151, 23);
            this.btnBackgroundImage.TabIndex = 5;
            this.btnBackgroundImage.Text = "Background Image";
            this.btnBackgroundImage.UseVisualStyleBackColor = true;
            this.btnBackgroundImage.Click += new System.EventHandler(this.btnBackgroundImage_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(511, 278);
            this.Controls.Add(this.btnBackgroundImage);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.lblFriends);
            this.Controls.Add(this.lstFriends);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "DRPlus";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label UserId;
		private System.Windows.Forms.ListBox lstFriends;
		private System.Windows.Forms.Label lblFriends;
		private System.Windows.Forms.Button btnBackgroundColor;
		private System.Windows.Forms.ColorDialog colorBackgroundColor;
		private System.Windows.Forms.Button btnBackgroundImage;
	}
}

