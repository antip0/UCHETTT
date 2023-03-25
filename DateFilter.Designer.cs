
namespace uchettt
{
    partial class DateFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фильтровать по дате с:";
            // 
            // dtp1
            // 
            this.dtp1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtp1.BorderRadius = 10;
            this.dtp1.CheckedState.Parent = this.dtp1;
            this.dtp1.CustomFormat = "yyyy-MM-dd";
            this.dtp1.FillColor = System.Drawing.Color.White;
            this.dtp1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.HoverState.Parent = this.dtp1;
            this.dtp1.Location = new System.Drawing.Point(210, 73);
            this.dtp1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShadowDecoration.Parent = this.dtp1;
            this.dtp1.Size = new System.Drawing.Size(151, 27);
            this.dtp1.TabIndex = 50;
            this.dtp1.Value = new System.DateTime(2023, 3, 21, 9, 23, 1, 741);
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(367, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "по:";
            // 
            // dtp2
            // 
            this.dtp2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtp2.BorderRadius = 10;
            this.dtp2.CheckedState.Parent = this.dtp2;
            this.dtp2.CustomFormat = "yyyy-MM-dd";
            this.dtp2.FillColor = System.Drawing.Color.White;
            this.dtp2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.HoverState.Parent = this.dtp2;
            this.dtp2.Location = new System.Drawing.Point(407, 73);
            this.dtp2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.ShadowDecoration.Parent = this.dtp2;
            this.dtp2.Size = new System.Drawing.Size(151, 27);
            this.dtp2.TabIndex = 52;
            this.dtp2.Value = new System.DateTime(2023, 3, 21, 9, 23, 1, 741);
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
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
            this.guna2Button1.Location = new System.Drawing.Point(564, 73);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(181, 27);
            this.guna2Button1.TabIndex = 57;
            this.guna2Button1.Text = "Показать";
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
            this.guna2Button2.Location = new System.Drawing.Point(751, 73);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(158, 27);
            this.guna2Button2.TabIndex = 58;
            this.guna2Button2.Text = "Отмена";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 58);
            this.panel1.TabIndex = 59;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(12, 18);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(200, 22);
            this.labelUserName.TabIndex = 19;
            this.labelUserName.Text = "Фильтрация по дате";
            this.labelUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelUserName_MouseMove);
            // 
            // DateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(921, 119);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтрация по дате";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserName;
    }
}