
namespace uchettt
{
    partial class Administrator
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.bnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.bnSuppliers = new Guna.UI2.WinForms.Guna2Button();
            this.panelStock = new System.Windows.Forms.Panel();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.bnStockIn = new Guna.UI2.WinForms.Guna2Button();
            this.bnStock = new Guna.UI2.WinForms.Guna2Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.bnManufacturers = new Guna.UI2.WinForms.Guna2Button();
            this.bnCategories = new Guna.UI2.WinForms.Guna2Button();
            this.bnProductList = new Guna.UI2.WinForms.Guna2Button();
            this.bnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.bnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.bnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.panelDGVPlace = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panelTabs.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelDGVPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.pbBack);
            this.panelTitle.Controls.Add(this.pbForward);
            this.panelTitle.Controls.Add(this.labelUserRole);
            this.panelTitle.Controls.Add(this.labelUserName);
            this.panelTitle.Controls.Add(this.pbMinimize);
            this.panelTitle.Controls.Add(this.pbClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1638, 58);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pbBack
            // 
            this.pbBack.Image = global::uchettt.Properties.Resources.back_43px;
            this.pbBack.Location = new System.Drawing.Point(3, 8);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(43, 43);
            this.pbBack.TabIndex = 23;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbForward
            // 
            this.pbForward.Image = global::uchettt.Properties.Resources.menu_43px;
            this.pbForward.Location = new System.Drawing.Point(5, 12);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(38, 38);
            this.pbForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForward.TabIndex = 22;
            this.pbForward.TabStop = false;
            this.pbForward.Click += new System.EventHandler(this.pbForward_Click);
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserRole.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserRole.Location = new System.Drawing.Point(49, 29);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(166, 22);
            this.labelUserRole.TabIndex = 19;
            this.labelUserRole.Text = "Администратор";
            this.labelUserRole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(49, 8);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(134, 22);
            this.labelUserName.TabIndex = 18;
            this.labelUserName.Text = "Пользователь";
            this.labelUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::uchettt.Properties.Resources.macos_minimize_32px;
            this.pbMinimize.Location = new System.Drawing.Point(1555, 11);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 32);
            this.pbMinimize.TabIndex = 17;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::uchettt.Properties.Resources.icons8_cancel_321;
            this.pbClose.Location = new System.Drawing.Point(1593, 11);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 32);
            this.pbClose.TabIndex = 16;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panelTabs
            // 
            this.panelTabs.AutoScroll = true;
            this.panelTabs.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelTabs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTabs.Controls.Add(this.bnChangePassword);
            this.panelTabs.Controls.Add(this.bnSuppliers);
            this.panelTabs.Controls.Add(this.panelStock);
            this.panelTabs.Controls.Add(this.bnStock);
            this.panelTabs.Controls.Add(this.panelProducts);
            this.panelTabs.Controls.Add(this.bnLogout);
            this.panelTabs.Controls.Add(this.bnProducts);
            this.panelTabs.Controls.Add(this.bnEmployees);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabs.Location = new System.Drawing.Point(0, 58);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(215, 578);
            this.panelTabs.TabIndex = 1;
            // 
            // bnChangePassword
            // 
            this.bnChangePassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnChangePassword.CheckedState.Parent = this.bnChangePassword;
            this.bnChangePassword.CustomImages.Parent = this.bnChangePassword;
            this.bnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnChangePassword.FillColor = System.Drawing.SystemColors.MenuBar;
            this.bnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnChangePassword.HoverState.Parent = this.bnChangePassword;
            this.bnChangePassword.Image = global::uchettt.Properties.Resources.settings_30px;
            this.bnChangePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnChangePassword.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bnChangePassword.ImageSize = new System.Drawing.Size(30, 30);
            this.bnChangePassword.Location = new System.Drawing.Point(0, 405);
            this.bnChangePassword.Name = "bnChangePassword";
            this.bnChangePassword.ShadowDecoration.Parent = this.bnChangePassword;
            this.bnChangePassword.Size = new System.Drawing.Size(213, 45);
            this.bnChangePassword.TabIndex = 24;
            this.bnChangePassword.Text = "Сменить пароль";
            this.bnChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnChangePassword.Click += new System.EventHandler(this.guna2Button13_Click);
            // 
            // bnSuppliers
            // 
            this.bnSuppliers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnSuppliers.CheckedState.Parent = this.bnSuppliers;
            this.bnSuppliers.CustomImages.Parent = this.bnSuppliers;
            this.bnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnSuppliers.FillColor = System.Drawing.SystemColors.MenuBar;
            this.bnSuppliers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnSuppliers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnSuppliers.HoverState.Parent = this.bnSuppliers;
            this.bnSuppliers.Image = global::uchettt.Properties.Resources.supplier_30px;
            this.bnSuppliers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnSuppliers.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bnSuppliers.ImageSize = new System.Drawing.Size(30, 30);
            this.bnSuppliers.Location = new System.Drawing.Point(0, 360);
            this.bnSuppliers.Name = "bnSuppliers";
            this.bnSuppliers.ShadowDecoration.Parent = this.bnSuppliers;
            this.bnSuppliers.Size = new System.Drawing.Size(213, 45);
            this.bnSuppliers.TabIndex = 21;
            this.bnSuppliers.Text = "Поставщики";
            this.bnSuppliers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnSuppliers.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.guna2Button8);
            this.panelStock.Controls.Add(this.bnStockIn);
            this.panelStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStock.Location = new System.Drawing.Point(0, 270);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(213, 90);
            this.panelStock.TabIndex = 20;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.guna2Button8.CheckedState.Parent = this.guna2Button8;
            this.guna2Button8.CustomImages.Parent = this.guna2Button8;
            this.guna2Button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button8.FillColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Button8.HoverState.Parent = this.guna2Button8;
            this.guna2Button8.Image = global::uchettt.Properties.Resources.new_moon_25px;
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.ImageOffset = new System.Drawing.Point(7, 0);
            this.guna2Button8.ImageSize = new System.Drawing.Size(10, 10);
            this.guna2Button8.Location = new System.Drawing.Point(0, 45);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.ShadowDecoration.Parent = this.guna2Button8;
            this.guna2Button8.Size = new System.Drawing.Size(213, 45);
            this.guna2Button8.TabIndex = 10;
            this.guna2Button8.Text = "Аннулирование";
            this.guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // bnStockIn
            // 
            this.bnStockIn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnStockIn.CheckedState.Parent = this.bnStockIn;
            this.bnStockIn.CustomImages.Parent = this.bnStockIn;
            this.bnStockIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnStockIn.FillColor = System.Drawing.SystemColors.ControlLight;
            this.bnStockIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnStockIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnStockIn.HoverState.Parent = this.bnStockIn;
            this.bnStockIn.Image = global::uchettt.Properties.Resources.new_moon_25px;
            this.bnStockIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnStockIn.ImageOffset = new System.Drawing.Point(7, 0);
            this.bnStockIn.ImageSize = new System.Drawing.Size(10, 10);
            this.bnStockIn.Location = new System.Drawing.Point(0, 0);
            this.bnStockIn.Name = "bnStockIn";
            this.bnStockIn.ShadowDecoration.Parent = this.bnStockIn;
            this.bnStockIn.Size = new System.Drawing.Size(213, 45);
            this.bnStockIn.TabIndex = 9;
            this.bnStockIn.Text = "Поступления";
            this.bnStockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnStockIn.TextOffset = new System.Drawing.Point(20, 0);
            this.bnStockIn.Click += new System.EventHandler(this.bnStockIn_Click);
            // 
            // bnStock
            // 
            this.bnStock.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnStock.CheckedState.Parent = this.bnStock;
            this.bnStock.CustomImages.Parent = this.bnStock;
            this.bnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnStock.FillColor = System.Drawing.SystemColors.MenuBar;
            this.bnStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnStock.HoverState.Parent = this.bnStock;
            this.bnStock.Image = global::uchettt.Properties.Resources.new_product_30px;
            this.bnStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnStock.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bnStock.ImageSize = new System.Drawing.Size(30, 30);
            this.bnStock.Location = new System.Drawing.Point(0, 225);
            this.bnStock.Name = "bnStock";
            this.bnStock.ShadowDecoration.Parent = this.bnStock;
            this.bnStock.Size = new System.Drawing.Size(213, 45);
            this.bnStock.TabIndex = 19;
            this.bnStock.Text = "Склад";
            this.bnStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnStock.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.bnManufacturers);
            this.panelProducts.Controls.Add(this.bnCategories);
            this.panelProducts.Controls.Add(this.bnProductList);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProducts.Location = new System.Drawing.Point(0, 90);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(213, 135);
            this.panelProducts.TabIndex = 18;
            // 
            // bnManufacturers
            // 
            this.bnManufacturers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnManufacturers.CheckedState.Parent = this.bnManufacturers;
            this.bnManufacturers.CustomImages.Parent = this.bnManufacturers;
            this.bnManufacturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnManufacturers.FillColor = System.Drawing.SystemColors.ControlLight;
            this.bnManufacturers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnManufacturers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnManufacturers.HoverState.Parent = this.bnManufacturers;
            this.bnManufacturers.Image = global::uchettt.Properties.Resources.new_moon_25px;
            this.bnManufacturers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnManufacturers.ImageOffset = new System.Drawing.Point(7, 0);
            this.bnManufacturers.ImageSize = new System.Drawing.Size(10, 10);
            this.bnManufacturers.Location = new System.Drawing.Point(0, 90);
            this.bnManufacturers.Name = "bnManufacturers";
            this.bnManufacturers.ShadowDecoration.Parent = this.bnManufacturers;
            this.bnManufacturers.Size = new System.Drawing.Size(213, 45);
            this.bnManufacturers.TabIndex = 9;
            this.bnManufacturers.Text = "Производители";
            this.bnManufacturers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnManufacturers.TextOffset = new System.Drawing.Point(20, 0);
            this.bnManufacturers.Click += new System.EventHandler(this.bnManufacturers_Click);
            // 
            // bnCategories
            // 
            this.bnCategories.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnCategories.CheckedState.Parent = this.bnCategories;
            this.bnCategories.CustomImages.Parent = this.bnCategories;
            this.bnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnCategories.FillColor = System.Drawing.SystemColors.ControlLight;
            this.bnCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnCategories.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnCategories.HoverState.Parent = this.bnCategories;
            this.bnCategories.Image = global::uchettt.Properties.Resources.new_moon_25px;
            this.bnCategories.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnCategories.ImageOffset = new System.Drawing.Point(7, 0);
            this.bnCategories.ImageSize = new System.Drawing.Size(10, 10);
            this.bnCategories.Location = new System.Drawing.Point(0, 45);
            this.bnCategories.Name = "bnCategories";
            this.bnCategories.ShadowDecoration.Parent = this.bnCategories;
            this.bnCategories.Size = new System.Drawing.Size(213, 45);
            this.bnCategories.TabIndex = 8;
            this.bnCategories.Text = "Категории";
            this.bnCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnCategories.TextOffset = new System.Drawing.Point(20, 0);
            this.bnCategories.Click += new System.EventHandler(this.bnCategories_Click);
            // 
            // bnProductList
            // 
            this.bnProductList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnProductList.CheckedState.Parent = this.bnProductList;
            this.bnProductList.CustomImages.Parent = this.bnProductList;
            this.bnProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnProductList.FillColor = System.Drawing.SystemColors.ControlLight;
            this.bnProductList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnProductList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnProductList.HoverState.Parent = this.bnProductList;
            this.bnProductList.Image = global::uchettt.Properties.Resources.new_moon_25px;
            this.bnProductList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnProductList.ImageOffset = new System.Drawing.Point(7, 0);
            this.bnProductList.ImageSize = new System.Drawing.Size(10, 10);
            this.bnProductList.Location = new System.Drawing.Point(0, 0);
            this.bnProductList.Name = "bnProductList";
            this.bnProductList.ShadowDecoration.Parent = this.bnProductList;
            this.bnProductList.Size = new System.Drawing.Size(213, 45);
            this.bnProductList.TabIndex = 7;
            this.bnProductList.Text = "Номенклатура";
            this.bnProductList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnProductList.TextOffset = new System.Drawing.Point(20, 0);
            this.bnProductList.Click += new System.EventHandler(this.bnProductList_Click);
            // 
            // bnLogout
            // 
            this.bnLogout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnLogout.CheckedState.Parent = this.bnLogout;
            this.bnLogout.CustomImages.Parent = this.bnLogout;
            this.bnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnLogout.FillColor = System.Drawing.Color.SteelBlue;
            this.bnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.bnLogout.HoverState.Parent = this.bnLogout;
            this.bnLogout.Image = global::uchettt.Properties.Resources.logout_30px;
            this.bnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnLogout.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.bnLogout.Location = new System.Drawing.Point(0, 531);
            this.bnLogout.Name = "bnLogout";
            this.bnLogout.ShadowDecoration.Parent = this.bnLogout;
            this.bnLogout.Size = new System.Drawing.Size(213, 45);
            this.bnLogout.TabIndex = 17;
            this.bnLogout.Text = "Выйти";
            this.bnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnLogout.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // bnProducts
            // 
            this.bnProducts.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnProducts.CheckedState.Parent = this.bnProducts;
            this.bnProducts.CustomImages.Parent = this.bnProducts;
            this.bnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnProducts.FillColor = System.Drawing.SystemColors.MenuBar;
            this.bnProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnProducts.HoverState.Parent = this.bnProducts;
            this.bnProducts.Image = global::uchettt.Properties.Resources.tasklist_30px;
            this.bnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnProducts.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bnProducts.ImageSize = new System.Drawing.Size(30, 30);
            this.bnProducts.Location = new System.Drawing.Point(0, 45);
            this.bnProducts.Name = "bnProducts";
            this.bnProducts.ShadowDecoration.Parent = this.bnProducts;
            this.bnProducts.Size = new System.Drawing.Size(213, 45);
            this.bnProducts.TabIndex = 3;
            this.bnProducts.Text = "Товары";
            this.bnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnProducts.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // bnEmployees
            // 
            this.bnEmployees.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bnEmployees.CheckedState.Parent = this.bnEmployees;
            this.bnEmployees.CustomImages.Parent = this.bnEmployees;
            this.bnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnEmployees.FillColor = System.Drawing.SystemColors.MenuBar;
            this.bnEmployees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnEmployees.HoverState.Parent = this.bnEmployees;
            this.bnEmployees.Image = global::uchettt.Properties.Resources.user_groups_30px;
            this.bnEmployees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnEmployees.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bnEmployees.ImageSize = new System.Drawing.Size(30, 30);
            this.bnEmployees.Location = new System.Drawing.Point(0, 0);
            this.bnEmployees.Name = "bnEmployees";
            this.bnEmployees.ShadowDecoration.Parent = this.bnEmployees;
            this.bnEmployees.Size = new System.Drawing.Size(213, 45);
            this.bnEmployees.TabIndex = 1;
            this.bnEmployees.Text = "Сотрудники";
            this.bnEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnEmployees.Click += new System.EventHandler(this.bnEmployees_Click);
            // 
            // panelDGVPlace
            // 
            this.panelDGVPlace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDGVPlace.Controls.Add(this.label2);
            this.panelDGVPlace.Controls.Add(this.label1);
            this.panelDGVPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDGVPlace.Location = new System.Drawing.Point(215, 58);
            this.panelDGVPlace.Name = "panelDGVPlace";
            this.panelDGVPlace.Size = new System.Drawing.Size(1423, 578);
            this.panelDGVPlace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(6, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(829, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите желаемый пункт меню\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1638, 636);
            this.Controls.Add(this.panelDGVPlace);
            this.Controls.Add(this.panelTabs);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainFormAdmin_MouseClick);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panelTabs.ResumeLayout(false);
            this.panelStock.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelDGVPlace.ResumeLayout(false);
            this.panelDGVPlace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelTabs;
        private Guna.UI2.WinForms.Guna2Button bnEmployees;
        private Guna.UI2.WinForms.Guna2Button bnProducts;
        private Guna.UI2.WinForms.Guna2Button bnLogout;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private Guna.UI2.WinForms.Guna2Button bnSuppliers;
        private System.Windows.Forms.Panel panelStock;
        private Guna.UI2.WinForms.Guna2Button bnStock;
        private System.Windows.Forms.Panel panelProducts;
        private Guna.UI2.WinForms.Guna2Button bnChangePassword;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button bnStockIn;
        private Guna.UI2.WinForms.Guna2Button bnManufacturers;
        private Guna.UI2.WinForms.Guna2Button bnCategories;
        private Guna.UI2.WinForms.Guna2Button bnProductList;
        private System.Windows.Forms.PictureBox pbForward;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Panel panelDGVPlace;
        public System.Windows.Forms.Label labelUserRole;
        public System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}