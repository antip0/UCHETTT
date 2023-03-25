
namespace uchettt
{
    partial class PassRecovery
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
            this.labelTabName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUserWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUserPass1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUserPass2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbDone3 = new System.Windows.Forms.PictureBox();
            this.pbDone2 = new System.Windows.Forms.PictureBox();
            this.pbDone1 = new System.Windows.Forms.PictureBox();
            this.pbDone = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTabName
            // 
            this.labelTabName.AutoSize = true;
            this.labelTabName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTabName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTabName.Location = new System.Drawing.Point(12, 19);
            this.labelTabName.Name = "labelTabName";
            this.labelTabName.Size = new System.Drawing.Size(271, 24);
            this.labelTabName.TabIndex = 14;
            this.labelTabName.Text = "Восстановление пароля";
            this.labelTabName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите кодовое слово/фразу:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Введите новый пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(20, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Подтвердите введённый пароль:";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.Controls.Add(this.labelTabName);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(487, 58);
            this.panelTitle.TabIndex = 26;
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите ваше ФИО:";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUserName.BorderRadius = 10;
            this.TextBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserName.DefaultText = "";
            this.TextBoxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserName.DisabledState.Parent = this.TextBoxUserName;
            this.TextBoxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserName.FocusedState.Parent = this.TextBoxUserName;
            this.TextBoxUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserName.HoverState.Parent = this.TextBoxUserName;
            this.TextBoxUserName.Location = new System.Drawing.Point(26, 101);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.PasswordChar = '\0';
            this.TextBoxUserName.PlaceholderText = "";
            this.TextBoxUserName.SelectedText = "";
            this.TextBoxUserName.ShadowDecoration.Parent = this.TextBoxUserName;
            this.TextBoxUserName.Size = new System.Drawing.Size(393, 35);
            this.TextBoxUserName.TabIndex = 48;
            this.TextBoxUserName.TextChanged += new System.EventHandler(this.TextBoxUserName_TextChanged);
            // 
            // TextBoxUserWord
            // 
            this.TextBoxUserWord.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUserWord.BorderRadius = 10;
            this.TextBoxUserWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserWord.DefaultText = "";
            this.TextBoxUserWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUserWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUserWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserWord.DisabledState.Parent = this.TextBoxUserWord;
            this.TextBoxUserWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserWord.FocusedState.Parent = this.TextBoxUserWord;
            this.TextBoxUserWord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUserWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUserWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserWord.HoverState.Parent = this.TextBoxUserWord;
            this.TextBoxUserWord.Location = new System.Drawing.Point(26, 177);
            this.TextBoxUserWord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxUserWord.Name = "TextBoxUserWord";
            this.TextBoxUserWord.PasswordChar = '\0';
            this.TextBoxUserWord.PlaceholderText = "";
            this.TextBoxUserWord.SelectedText = "";
            this.TextBoxUserWord.ShadowDecoration.Parent = this.TextBoxUserWord;
            this.TextBoxUserWord.Size = new System.Drawing.Size(393, 35);
            this.TextBoxUserWord.TabIndex = 49;
            this.TextBoxUserWord.TextChanged += new System.EventHandler(this.TextBoxUserWord_TextChanged);
            // 
            // TextBoxUserPass1
            // 
            this.TextBoxUserPass1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUserPass1.BorderRadius = 10;
            this.TextBoxUserPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserPass1.DefaultText = "";
            this.TextBoxUserPass1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUserPass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUserPass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserPass1.DisabledState.Parent = this.TextBoxUserPass1;
            this.TextBoxUserPass1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserPass1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserPass1.FocusedState.Parent = this.TextBoxUserPass1;
            this.TextBoxUserPass1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUserPass1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUserPass1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserPass1.HoverState.Parent = this.TextBoxUserPass1;
            this.TextBoxUserPass1.Location = new System.Drawing.Point(26, 251);
            this.TextBoxUserPass1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxUserPass1.Name = "TextBoxUserPass1";
            this.TextBoxUserPass1.PasswordChar = '\0';
            this.TextBoxUserPass1.PlaceholderText = "";
            this.TextBoxUserPass1.SelectedText = "";
            this.TextBoxUserPass1.ShadowDecoration.Parent = this.TextBoxUserPass1;
            this.TextBoxUserPass1.Size = new System.Drawing.Size(393, 35);
            this.TextBoxUserPass1.TabIndex = 50;
            this.TextBoxUserPass1.TextChanged += new System.EventHandler(this.TextBoxUserPass1_TextChanged);
            // 
            // TextBoxUserPass2
            // 
            this.TextBoxUserPass2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUserPass2.BorderRadius = 10;
            this.TextBoxUserPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserPass2.DefaultText = "";
            this.TextBoxUserPass2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUserPass2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUserPass2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserPass2.DisabledState.Parent = this.TextBoxUserPass2;
            this.TextBoxUserPass2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUserPass2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserPass2.FocusedState.Parent = this.TextBoxUserPass2;
            this.TextBoxUserPass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxUserPass2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUserPass2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUserPass2.HoverState.Parent = this.TextBoxUserPass2;
            this.TextBoxUserPass2.Location = new System.Drawing.Point(26, 325);
            this.TextBoxUserPass2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxUserPass2.Name = "TextBoxUserPass2";
            this.TextBoxUserPass2.PasswordChar = '\0';
            this.TextBoxUserPass2.PlaceholderText = "";
            this.TextBoxUserPass2.SelectedText = "";
            this.TextBoxUserPass2.ShadowDecoration.Parent = this.TextBoxUserPass2;
            this.TextBoxUserPass2.Size = new System.Drawing.Size(393, 35);
            this.TextBoxUserPass2.TabIndex = 51;
            this.TextBoxUserPass2.TextChanged += new System.EventHandler(this.TextBoxUserPass2_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // bnCheck
            // 
            this.bnCheck.BorderRadius = 10;
            this.bnCheck.CheckedState.Parent = this.bnCheck;
            this.bnCheck.CustomImages.Parent = this.bnCheck;
            this.bnCheck.FillColor = System.Drawing.Color.SteelBlue;
            this.bnCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnCheck.ForeColor = System.Drawing.Color.White;
            this.bnCheck.HoverState.Parent = this.bnCheck;
            this.bnCheck.Location = new System.Drawing.Point(26, 371);
            this.bnCheck.Name = "bnCheck";
            this.bnCheck.ShadowDecoration.Parent = this.bnCheck;
            this.bnCheck.Size = new System.Drawing.Size(237, 35);
            this.bnCheck.TabIndex = 53;
            this.bnCheck.Text = "Проверить";
            this.bnCheck.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pbClear
            // 
            this.pbClear.Image = global::uchettt.Properties.Resources.erase_36px;
            this.pbClear.Location = new System.Drawing.Point(427, 371);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(35, 35);
            this.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClear.TabIndex = 54;
            this.pbClear.TabStop = false;
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // pbDone3
            // 
            this.pbDone3.Image = global::uchettt.Properties.Resources.done_43px;
            this.pbDone3.Location = new System.Drawing.Point(427, 325);
            this.pbDone3.Name = "pbDone3";
            this.pbDone3.Size = new System.Drawing.Size(35, 35);
            this.pbDone3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDone3.TabIndex = 32;
            this.pbDone3.TabStop = false;
            // 
            // pbDone2
            // 
            this.pbDone2.Image = global::uchettt.Properties.Resources.done_43px;
            this.pbDone2.Location = new System.Drawing.Point(427, 251);
            this.pbDone2.Name = "pbDone2";
            this.pbDone2.Size = new System.Drawing.Size(35, 35);
            this.pbDone2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDone2.TabIndex = 31;
            this.pbDone2.TabStop = false;
            // 
            // pbDone1
            // 
            this.pbDone1.Image = global::uchettt.Properties.Resources.done_43px;
            this.pbDone1.Location = new System.Drawing.Point(427, 177);
            this.pbDone1.Name = "pbDone1";
            this.pbDone1.Size = new System.Drawing.Size(35, 35);
            this.pbDone1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDone1.TabIndex = 30;
            this.pbDone1.TabStop = false;
            // 
            // pbDone
            // 
            this.pbDone.Image = global::uchettt.Properties.Resources.done_43px;
            this.pbDone.Location = new System.Drawing.Point(427, 101);
            this.pbDone.Name = "pbDone";
            this.pbDone.Size = new System.Drawing.Size(35, 35);
            this.pbDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDone.TabIndex = 29;
            this.pbDone.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Coral;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(269, 371);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(152, 35);
            this.guna2Button1.TabIndex = 55;
            this.guna2Button1.Text = "Отмена";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // PassRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(487, 419);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.bnCheck);
            this.Controls.Add(this.TextBoxUserPass2);
            this.Controls.Add(this.TextBoxUserPass1);
            this.Controls.Add(this.TextBoxUserWord);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.pbDone3);
            this.Controls.Add(this.pbDone2);
            this.Controls.Add(this.pbDone1);
            this.Controls.Add(this.pbDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление пароля";
            this.Load += new System.EventHandler(this.passRecovery_Load);
            this.Shown += new System.EventHandler(this.passRecovery_Shown);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTabName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDone;
        private System.Windows.Forms.PictureBox pbDone3;
        private System.Windows.Forms.PictureBox pbDone2;
        private System.Windows.Forms.PictureBox pbDone1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUserName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUserWord;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUserPass1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUserPass2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button bnCheck;
        private System.Windows.Forms.PictureBox pbClear;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}