
namespace uchettt
{
    partial class AddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassRepeat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.tbUserWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 58);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(12, 18);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(198, 22);
            this.labelUserName.TabIndex = 19;
            this.labelUserName.Text = "Создание аккаунта";
            this.labelUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelUserName_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "ФИО сотрудника";
            // 
            // tbFullname
            // 
            this.tbFullname.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFullname.BorderRadius = 10;
            this.tbFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFullname.DefaultText = "";
            this.tbFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFullname.DisabledState.Parent = this.tbFullname;
            this.tbFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFullname.FocusedState.Parent = this.tbFullname;
            this.tbFullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFullname.HoverState.Parent = this.tbFullname;
            this.tbFullname.Location = new System.Drawing.Point(17, 96);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.PasswordChar = '\0';
            this.tbFullname.PlaceholderText = "";
            this.tbFullname.SelectedText = "";
            this.tbFullname.ShadowDecoration.Parent = this.tbFullname;
            this.tbFullname.Size = new System.Drawing.Size(316, 27);
            this.tbFullname.TabIndex = 40;
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbRole.BorderRadius = 10;
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FocusedColor = System.Drawing.Color.Empty;
            this.cbRole.FocusedState.Parent = this.cbRole;
            this.cbRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.HoverState.Parent = this.cbRole;
            this.cbRole.ItemHeight = 16;
            this.cbRole.Items.AddRange(new object[] {
            "Администратор",
            "Кассир"});
            this.cbRole.ItemsAppearance.Parent = this.cbRole;
            this.cbRole.Location = new System.Drawing.Point(17, 152);
            this.cbRole.Name = "cbRole";
            this.cbRole.ShadowDecoration.Parent = this.cbRole;
            this.cbRole.Size = new System.Drawing.Size(316, 22);
            this.cbRole.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Роль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Повторите пароль";
            // 
            // tbPassRepeat
            // 
            this.tbPassRepeat.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPassRepeat.BorderRadius = 10;
            this.tbPassRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassRepeat.DefaultText = "";
            this.tbPassRepeat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassRepeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassRepeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassRepeat.DisabledState.Parent = this.tbPassRepeat;
            this.tbPassRepeat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassRepeat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassRepeat.FocusedState.Parent = this.tbPassRepeat;
            this.tbPassRepeat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassRepeat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPassRepeat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassRepeat.HoverState.Parent = this.tbPassRepeat;
            this.tbPassRepeat.Location = new System.Drawing.Point(15, 321);
            this.tbPassRepeat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPassRepeat.Name = "tbPassRepeat";
            this.tbPassRepeat.PasswordChar = '*';
            this.tbPassRepeat.PlaceholderText = "";
            this.tbPassRepeat.SelectedText = "";
            this.tbPassRepeat.ShadowDecoration.Parent = this.tbPassRepeat;
            this.tbPassRepeat.Size = new System.Drawing.Size(254, 27);
            this.tbPassRepeat.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Пароль";
            // 
            // tbPass
            // 
            this.tbPass.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPass.BorderRadius = 10;
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.DefaultText = "";
            this.tbPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPass.DisabledState.Parent = this.tbPass;
            this.tbPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPass.FocusedState.Parent = this.tbPass;
            this.tbPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPass.HoverState.Parent = this.tbPass;
            this.tbPass.Location = new System.Drawing.Point(16, 263);
            this.tbPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.PlaceholderText = "";
            this.tbPass.SelectedText = "";
            this.tbPass.ShadowDecoration.Parent = this.tbPass;
            this.tbPass.Size = new System.Drawing.Size(253, 27);
            this.tbPass.TabIndex = 48;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(15, 387);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(317, 37);
            this.guna2Button1.TabIndex = 52;
            this.guna2Button1.Text = "Создать аккаунт";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Coral;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(17, 430);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(273, 37);
            this.guna2Button2.TabIndex = 53;
            this.guna2Button2.Text = "Отмена";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // tbUserWord
            // 
            this.tbUserWord.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUserWord.BorderRadius = 10;
            this.tbUserWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserWord.DefaultText = "";
            this.tbUserWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserWord.DisabledState.Parent = this.tbUserWord;
            this.tbUserWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserWord.FocusedState.Parent = this.tbUserWord;
            this.tbUserWord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUserWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserWord.HoverState.Parent = this.tbUserWord;
            this.tbUserWord.Location = new System.Drawing.Point(15, 205);
            this.tbUserWord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbUserWord.Name = "tbUserWord";
            this.tbUserWord.PasswordChar = '\0';
            this.tbUserWord.PlaceholderText = "";
            this.tbUserWord.SelectedText = "";
            this.tbUserWord.ShadowDecoration.Parent = this.tbUserWord;
            this.tbUserWord.Size = new System.Drawing.Size(317, 27);
            this.tbUserWord.TabIndex = 59;
            this.tbUserWord.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Ключевое слово/фраза";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uchettt.Properties.Resources.erase_36px;
            this.pictureBox1.Location = new System.Drawing.Point(296, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(15, 356);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 25);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Активировать аккаунт";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(349, 482);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUserWord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassRepeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудников";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2ComboBox cbRole;
        public Guna.UI2.WinForms.Guna2TextBox tbFullname;
        public Guna.UI2.WinForms.Guna2TextBox tbPassRepeat;
        public Guna.UI2.WinForms.Guna2TextBox tbPass;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox tbUserWord;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}