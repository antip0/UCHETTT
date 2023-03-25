
namespace uchettt
{
    partial class authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserFio = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.labelTabName = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.bnAuthorization = new Guna.UI2.WinForms.Guna2Button();
            this.labelFioWarning = new System.Windows.Forms.Label();
            this.labelPasswordWarning = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.cbUserName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserFio
            // 
            this.labelUserFio.AutoSize = true;
            this.labelUserFio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserFio.Location = new System.Drawing.Point(13, 72);
            this.labelUserFio.Name = "labelUserFio";
            this.labelUserFio.Size = new System.Drawing.Size(58, 22);
            this.labelUserFio.TabIndex = 0;
            this.labelUserFio.Text = "ФИО";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserPassword.Location = new System.Drawing.Point(13, 136);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(80, 22);
            this.labelUserPassword.TabIndex = 1;
            this.labelUserPassword.Text = "Пароль";
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.Controls.Add(this.pbMinimize);
            this.panelTitle.Controls.Add(this.labelTabName);
            this.panelTitle.Controls.Add(this.pbExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(362, 58);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::uchettt.Properties.Resources.macos_minimize_32px;
            this.pbMinimize.Location = new System.Drawing.Point(280, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 32);
            this.pbMinimize.TabIndex = 15;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // labelTabName
            // 
            this.labelTabName.AutoSize = true;
            this.labelTabName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTabName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTabName.Location = new System.Drawing.Point(12, 17);
            this.labelTabName.Name = "labelTabName";
            this.labelTabName.Size = new System.Drawing.Size(143, 24);
            this.labelTabName.TabIndex = 14;
            this.labelTabName.Text = "Авторизация";
            this.labelTabName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::uchettt.Properties.Resources.icons8_cancel_321;
            this.pbExit.Location = new System.Drawing.Point(318, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.TabIndex = 12;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bnAuthorization
            // 
            this.bnAuthorization.CheckedState.Parent = this.bnAuthorization;
            this.bnAuthorization.CustomImages.Parent = this.bnAuthorization;
            this.bnAuthorization.FillColor = System.Drawing.Color.SteelBlue;
            this.bnAuthorization.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnAuthorization.ForeColor = System.Drawing.Color.White;
            this.bnAuthorization.HoverState.Parent = this.bnAuthorization;
            this.bnAuthorization.Location = new System.Drawing.Point(16, 249);
            this.bnAuthorization.Name = "bnAuthorization";
            this.bnAuthorization.ShadowDecoration.Parent = this.bnAuthorization;
            this.bnAuthorization.Size = new System.Drawing.Size(330, 45);
            this.bnAuthorization.TabIndex = 5;
            this.bnAuthorization.Text = "Авторизоваться";
            this.bnAuthorization.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // labelFioWarning
            // 
            this.labelFioWarning.AutoSize = true;
            this.labelFioWarning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFioWarning.ForeColor = System.Drawing.Color.Red;
            this.labelFioWarning.Location = new System.Drawing.Point(223, 136);
            this.labelFioWarning.Name = "labelFioWarning";
            this.labelFioWarning.Size = new System.Drawing.Size(124, 21);
            this.labelFioWarning.TabIndex = 8;
            this.labelFioWarning.Text = "Укажите ФИО!";
            // 
            // labelPasswordWarning
            // 
            this.labelPasswordWarning.AutoSize = true;
            this.labelPasswordWarning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordWarning.Location = new System.Drawing.Point(209, 204);
            this.labelPasswordWarning.Name = "labelPasswordWarning";
            this.labelPasswordWarning.Size = new System.Drawing.Size(138, 21);
            this.labelPasswordWarning.TabIndex = 9;
            this.labelPasswordWarning.Text = "Введите пароль!";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForgotPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelForgotPassword.Location = new System.Drawing.Point(203, 225);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(143, 21);
            this.labelForgotPassword.TabIndex = 10;
            this.labelForgotPassword.Text = "Забыли пароль?";
            this.labelForgotPassword.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbUserName
            // 
            this.cbUserName.BackColor = System.Drawing.Color.Transparent;
            this.cbUserName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbUserName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserName.FocusedColor = System.Drawing.Color.Empty;
            this.cbUserName.FocusedState.Parent = this.cbUserName;
            this.cbUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.HoverState.Parent = this.cbUserName;
            this.cbUserName.ItemHeight = 30;
            this.cbUserName.ItemsAppearance.Parent = this.cbUserName;
            this.cbUserName.Location = new System.Drawing.Point(16, 97);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.ShadowDecoration.Parent = this.cbUserName;
            this.cbUserName.Size = new System.Drawing.Size(330, 36);
            this.cbUserName.TabIndex = 14;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.cbUserName_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::uchettt.Properties.Resources.erase_36px;
            this.pictureBox4.Location = new System.Drawing.Point(268, 163);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserPassword.DefaultText = "";
            this.tbUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserPassword.DisabledState.Parent = this.tbUserPassword;
            this.tbUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserPassword.FocusedState.Parent = this.tbUserPassword;
            this.tbUserPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserPassword.HoverState.Parent = this.tbUserPassword;
            this.tbUserPassword.IconRight = global::uchettt.Properties.Resources.password_32px;
            this.tbUserPassword.IconRightSize = new System.Drawing.Size(25, 25);
            this.tbUserPassword.Location = new System.Drawing.Point(16, 163);
            this.tbUserPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '\0';
            this.tbUserPassword.PlaceholderText = "";
            this.tbUserPassword.SelectedText = "";
            this.tbUserPassword.ShadowDecoration.Parent = this.tbUserPassword;
            this.tbUserPassword.Size = new System.Drawing.Size(244, 36);
            this.tbUserPassword.TabIndex = 15;
            this.tbUserPassword.TextChanged += new System.EventHandler(this.tbUserPassword_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::uchettt.Properties.Resources.hide_36px;
            this.pictureBox2.Location = new System.Drawing.Point(310, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uchettt.Properties.Resources.eye_36px;
            this.pictureBox1.Location = new System.Drawing.Point(310, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(362, 306);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tbUserPassword);
            this.Controls.Add(this.cbUserName);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelPasswordWarning);
            this.Controls.Add(this.labelFioWarning);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnAuthorization);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserFio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserFio;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Panel panelTitle;
        private Guna.UI2.WinForms.Guna2Button bnAuthorization;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelFioWarning;
        private System.Windows.Forms.Label labelPasswordWarning;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label labelTabName;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Label labelForgotPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUserPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cbUserName;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

