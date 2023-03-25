
namespace uchettt
{
    partial class AddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCritical = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbManuf = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.tbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 58);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(12, 18);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(266, 22);
            this.labelUserName.TabIndex = 19;
            this.labelUserName.Text = "Создание записи о товаре";
            this.labelUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelUserName_MouseMove);
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
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Штрих-код";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbBarcode
            // 
            this.tbBarcode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBarcode.BorderRadius = 10;
            this.tbBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBarcode.DefaultText = "";
            this.tbBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBarcode.DisabledState.Parent = this.tbBarcode;
            this.tbBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBarcode.FocusedState.Parent = this.tbBarcode;
            this.tbBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBarcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBarcode.HoverState.Parent = this.tbBarcode;
            this.tbBarcode.Location = new System.Drawing.Point(16, 154);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.PasswordChar = '\0';
            this.tbBarcode.PlaceholderText = "";
            this.tbBarcode.SelectedText = "";
            this.tbBarcode.ShadowDecoration.Parent = this.tbBarcode;
            this.tbBarcode.Size = new System.Drawing.Size(344, 27);
            this.tbBarcode.TabIndex = 6;
            this.tbBarcode.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Описание";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbDescription.BorderRadius = 10;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.DefaultText = "";
            this.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.DisabledState.Parent = this.tbDescription;
            this.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.FocusedState.Parent = this.tbDescription;
            this.tbDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.HoverState.Parent = this.tbDescription;
            this.tbDescription.Location = new System.Drawing.Point(16, 212);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PlaceholderText = "";
            this.tbDescription.SelectedText = "";
            this.tbDescription.ShadowDecoration.Parent = this.tbDescription;
            this.tbDescription.Size = new System.Drawing.Size(423, 27);
            this.tbDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Критический уровень";
            // 
            // tbCritical
            // 
            this.tbCritical.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbCritical.BorderRadius = 10;
            this.tbCritical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCritical.DefaultText = "";
            this.tbCritical.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCritical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCritical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCritical.DisabledState.Parent = this.tbCritical;
            this.tbCritical.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCritical.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCritical.FocusedState.Parent = this.tbCritical;
            this.tbCritical.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCritical.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCritical.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCritical.HoverState.Parent = this.tbCritical;
            this.tbCritical.Location = new System.Drawing.Point(18, 484);
            this.tbCritical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCritical.Name = "tbCritical";
            this.tbCritical.PasswordChar = '\0';
            this.tbCritical.PlaceholderText = "";
            this.tbCritical.SelectedText = "";
            this.tbCritical.ShadowDecoration.Parent = this.tbCritical;
            this.tbCritical.Size = new System.Drawing.Size(218, 27);
            this.tbCritical.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Розничная цена";
            // 
            // cbManuf
            // 
            this.cbManuf.BackColor = System.Drawing.Color.Transparent;
            this.cbManuf.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbManuf.BorderRadius = 10;
            this.cbManuf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbManuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManuf.FocusedColor = System.Drawing.Color.Empty;
            this.cbManuf.FocusedState.Parent = this.cbManuf;
            this.cbManuf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbManuf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbManuf.FormattingEnabled = true;
            this.cbManuf.HoverState.Parent = this.cbManuf;
            this.cbManuf.ItemHeight = 16;
            this.cbManuf.ItemsAppearance.Parent = this.cbManuf;
            this.cbManuf.Location = new System.Drawing.Point(17, 317);
            this.cbManuf.Name = "cbManuf";
            this.cbManuf.ShadowDecoration.Parent = this.cbManuf;
            this.cbManuf.Size = new System.Drawing.Size(343, 22);
            this.cbManuf.TabIndex = 18;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbCategory.BorderRadius = 10;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.FocusedState.Parent = this.cbCategory;
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.HoverState.Parent = this.cbCategory;
            this.cbCategory.ItemHeight = 16;
            this.cbCategory.ItemsAppearance.Parent = this.cbCategory;
            this.cbCategory.Location = new System.Drawing.Point(17, 268);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.Parent = this.cbCategory;
            this.cbCategory.Size = new System.Drawing.Size(343, 22);
            this.cbCategory.TabIndex = 19;
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
            this.guna2Button1.Location = new System.Drawing.Point(16, 519);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(423, 37);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Создать";
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
            this.guna2Button2.Location = new System.Drawing.Point(17, 605);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(380, 37);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.Text = "Отмена";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPrice.BorderRadius = 10;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(18, 426);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(217, 27);
            this.tbPrice.TabIndex = 23;
            this.tbPrice.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(17, 562);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(423, 37);
            this.guna2Button3.TabIndex = 24;
            this.guna2Button3.Text = "Изменить";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // tbId
            // 
            this.tbId.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbId.BorderRadius = 10;
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.DefaultText = "";
            this.tbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbId.DisabledState.Parent = this.tbId;
            this.tbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbId.FocusedState.Parent = this.tbId;
            this.tbId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbId.HoverState.Parent = this.tbId;
            this.tbId.Location = new System.Drawing.Point(16, 96);
            this.tbId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.PlaceholderText = "";
            this.tbId.SelectedText = "";
            this.tbId.ShadowDecoration.Parent = this.tbId;
            this.tbId.Size = new System.Drawing.Size(218, 27);
            this.tbId.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Идентификатор";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uchettt.Properties.Resources.erase_36px;
            this.pictureBox1.Location = new System.Drawing.Point(403, 605);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(18, 368);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(217, 27);
            this.guna2TextBox1.TabIndex = 29;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Закупочная цена";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(453, 656);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbManuf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCritical);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товаров";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2Button guna2Button3;
        public Guna.UI2.WinForms.Guna2TextBox tbId;
        public Guna.UI2.WinForms.Guna2TextBox tbBarcode;
        public Guna.UI2.WinForms.Guna2TextBox tbDescription;
        public Guna.UI2.WinForms.Guna2TextBox tbCritical;
        public Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        public Guna.UI2.WinForms.Guna2ComboBox cbManuf;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2TextBox tbPrice;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label8;
    }
}