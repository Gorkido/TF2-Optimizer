namespace TF2_Optimizer
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Left_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.TF2_Icon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Settings_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Auto_Opti_Button = new Guna.UI2.WinForms.Guna2Button();
            this.CustomMod_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Useful_Mods_Button = new Guna.UI2.WinForms.Guna2Button();
            this.PopHUDs_Button = new Guna.UI2.WinForms.Guna2Button();
            this.mastercomfig_Button = new Guna.UI2.WinForms.Guna2Button();
            this.About_Button = new Guna.UI2.WinForms.Guna2Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.Main_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Settings_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.set_label7 = new System.Windows.Forms.Label();
            this.languageChanger = new Guna.UI2.WinForms.Guna2ComboBox();
            this.set_label6 = new System.Windows.Forms.Label();
            this.ResetTF2_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.set_label5 = new System.Windows.Forms.Label();
            this.set_label4 = new System.Windows.Forms.Label();
            this.set_label3 = new System.Windows.Forms.Label();
            this.set_label2 = new System.Windows.Forms.Label();
            this.TF2_Location = new Guna.UI2.WinForms.Guna2TextBox();
            this.Steam_Location = new Guna.UI2.WinForms.Guna2TextBox();
            this.set_label1 = new System.Windows.Forms.Label();
            this.About_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Discord_Link = new System.Windows.Forms.PictureBox();
            this.Github_Link = new System.Windows.Forms.PictureBox();
            this.Youtube_Link = new System.Windows.Forms.PictureBox();
            this.SubTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Mastercomfig_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.msconfig_pre_label = new System.Windows.Forms.Label();
            this.msconf_preset_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Configure_mastercomf = new Guna.UI2.WinForms.Guna2Button();
            this.Custom_Install_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.OpenFileDI = new Guna.UI2.WinForms.Guna2Button();
            this.DropInstall = new System.Windows.Forms.ListBox();
            this.Custom_Install = new Guna.UI2.WinForms.Guna2Button();
            this.ci_label2 = new System.Windows.Forms.Label();
            this.ci_label1 = new System.Windows.Forms.Label();
            this.AnimateTF_Icon = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TF2_Icon)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.Settings_Panel.SuspendLayout();
            this.About_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discord_Link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github_Link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube_Link)).BeginInit();
            this.Mastercomfig_Panel.SuspendLayout();
            this.Custom_Install_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            resources.ApplyResources(this.Left_Panel, "Left_Panel");
            this.Left_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Left_Panel.Controls.Add(this.TF2_Icon);
            this.Left_Panel.Controls.Add(this.Settings_Button);
            this.Left_Panel.Controls.Add(this.Auto_Opti_Button);
            this.Left_Panel.Controls.Add(this.CustomMod_Button);
            this.Left_Panel.Controls.Add(this.Useful_Mods_Button);
            this.Left_Panel.Controls.Add(this.PopHUDs_Button);
            this.Left_Panel.Controls.Add(this.mastercomfig_Button);
            this.Left_Panel.Controls.Add(this.About_Button);
            this.Left_Panel.Controls.Add(this.MenuLabel);
            this.Left_Panel.FillColor = System.Drawing.Color.DimGray;
            this.Left_Panel.FillColor2 = System.Drawing.Color.Transparent;
            this.Left_Panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Left_Panel.Name = "Left_Panel";
            // 
            // TF2_Icon
            // 
            this.TF2_Icon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TF2_Icon, "TF2_Icon");
            this.TF2_Icon.ImageRotate = 354F;
            this.TF2_Icon.Name = "TF2_Icon";
            this.TF2_Icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TF2_Icon.TabStop = false;
            this.TF2_Icon.MouseEnter += new System.EventHandler(this.TF2_Icon_MouseEnter);
            this.TF2_Icon.MouseLeave += new System.EventHandler(this.TF2_Icon_MouseLeave);
            // 
            // Settings_Button
            // 
            this.Settings_Button.Animated = true;
            this.Settings_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Settings_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.Settings_Button, "Settings_Button");
            this.Settings_Button.FillColor = System.Drawing.Color.Transparent;
            this.Settings_Button.ForeColor = System.Drawing.Color.White;
            this.Settings_Button.Image = global::TF2_Optimizer.Properties.Resources.Settings;
            this.Settings_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings_Button.ImageOffset = new System.Drawing.Point(9, 0);
            this.Settings_Button.ImageSize = new System.Drawing.Size(45, 45);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Settings_Button.PressedDepth = 1;
            this.Settings_Button.ShadowDecoration.BorderRadius = 0;
            this.Settings_Button.ShadowDecoration.Depth = 0;
            this.Settings_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Auto_Opti_Button
            // 
            this.Auto_Opti_Button.Animated = true;
            this.Auto_Opti_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Auto_Opti_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Auto_Opti_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Auto_Opti_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Auto_Opti_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.Auto_Opti_Button, "Auto_Opti_Button");
            this.Auto_Opti_Button.FillColor = System.Drawing.Color.Transparent;
            this.Auto_Opti_Button.ForeColor = System.Drawing.Color.White;
            this.Auto_Opti_Button.Image = global::TF2_Optimizer.Properties.Resources.Automated;
            this.Auto_Opti_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Auto_Opti_Button.ImageOffset = new System.Drawing.Point(5, 0);
            this.Auto_Opti_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.Auto_Opti_Button.Name = "Auto_Opti_Button";
            this.Auto_Opti_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Auto_Opti_Button.PressedDepth = 1;
            this.Auto_Opti_Button.ShadowDecoration.BorderRadius = 0;
            this.Auto_Opti_Button.ShadowDecoration.Depth = 0;
            this.Auto_Opti_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.Auto_Opti_Button.Click += new System.EventHandler(this.Auto_Opti_Button_Click);
            // 
            // CustomMod_Button
            // 
            this.CustomMod_Button.Animated = true;
            this.CustomMod_Button.BorderColor = System.Drawing.Color.Transparent;
            this.CustomMod_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomMod_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomMod_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomMod_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.CustomMod_Button, "CustomMod_Button");
            this.CustomMod_Button.FillColor = System.Drawing.Color.Transparent;
            this.CustomMod_Button.ForeColor = System.Drawing.Color.White;
            this.CustomMod_Button.Image = global::TF2_Optimizer.Properties.Resources.Custom;
            this.CustomMod_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomMod_Button.ImageOffset = new System.Drawing.Point(10, 0);
            this.CustomMod_Button.ImageSize = new System.Drawing.Size(42, 42);
            this.CustomMod_Button.Name = "CustomMod_Button";
            this.CustomMod_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.CustomMod_Button.PressedDepth = 1;
            this.CustomMod_Button.ShadowDecoration.BorderRadius = 0;
            this.CustomMod_Button.ShadowDecoration.Depth = 0;
            this.CustomMod_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.CustomMod_Button.Click += new System.EventHandler(this.CustomMod_Button_Click);
            // 
            // Useful_Mods_Button
            // 
            this.Useful_Mods_Button.Animated = true;
            this.Useful_Mods_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Useful_Mods_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Useful_Mods_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Useful_Mods_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Useful_Mods_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.Useful_Mods_Button, "Useful_Mods_Button");
            this.Useful_Mods_Button.FillColor = System.Drawing.Color.Transparent;
            this.Useful_Mods_Button.ForeColor = System.Drawing.Color.White;
            this.Useful_Mods_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Useful_Mods_Button.ImageOffset = new System.Drawing.Point(3, 0);
            this.Useful_Mods_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.Useful_Mods_Button.Name = "Useful_Mods_Button";
            this.Useful_Mods_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Useful_Mods_Button.PressedDepth = 1;
            this.Useful_Mods_Button.ShadowDecoration.BorderRadius = 0;
            this.Useful_Mods_Button.ShadowDecoration.Depth = 0;
            this.Useful_Mods_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.Useful_Mods_Button.Click += new System.EventHandler(this.Useful_Mods_Button_Click);
            // 
            // PopHUDs_Button
            // 
            this.PopHUDs_Button.Animated = true;
            this.PopHUDs_Button.BorderColor = System.Drawing.Color.Transparent;
            this.PopHUDs_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PopHUDs_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PopHUDs_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PopHUDs_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.PopHUDs_Button, "PopHUDs_Button");
            this.PopHUDs_Button.FillColor = System.Drawing.Color.Transparent;
            this.PopHUDs_Button.ForeColor = System.Drawing.Color.White;
            this.PopHUDs_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PopHUDs_Button.ImageOffset = new System.Drawing.Point(3, 0);
            this.PopHUDs_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.PopHUDs_Button.Name = "PopHUDs_Button";
            this.PopHUDs_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.PopHUDs_Button.PressedDepth = 1;
            this.PopHUDs_Button.ShadowDecoration.BorderRadius = 0;
            this.PopHUDs_Button.ShadowDecoration.Depth = 0;
            this.PopHUDs_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.PopHUDs_Button.Click += new System.EventHandler(this.PopHUDs_Button_Click);
            // 
            // mastercomfig_Button
            // 
            this.mastercomfig_Button.Animated = true;
            this.mastercomfig_Button.BorderColor = System.Drawing.Color.Transparent;
            this.mastercomfig_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mastercomfig_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mastercomfig_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mastercomfig_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.mastercomfig_Button, "mastercomfig_Button");
            this.mastercomfig_Button.FillColor = System.Drawing.Color.Transparent;
            this.mastercomfig_Button.ForeColor = System.Drawing.Color.White;
            this.mastercomfig_Button.Image = ((System.Drawing.Image)(resources.GetObject("mastercomfig_Button.Image")));
            this.mastercomfig_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mastercomfig_Button.ImageOffset = new System.Drawing.Point(2, 0);
            this.mastercomfig_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.mastercomfig_Button.Name = "mastercomfig_Button";
            this.mastercomfig_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.mastercomfig_Button.PressedDepth = 1;
            this.mastercomfig_Button.ShadowDecoration.BorderRadius = 0;
            this.mastercomfig_Button.ShadowDecoration.Depth = 0;
            this.mastercomfig_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.mastercomfig_Button.Click += new System.EventHandler(this.mastercomfig_Button_Click);
            // 
            // About_Button
            // 
            this.About_Button.Animated = true;
            this.About_Button.BorderColor = System.Drawing.Color.Transparent;
            this.About_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.About_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.About_Button, "About_Button");
            this.About_Button.FillColor = System.Drawing.Color.Transparent;
            this.About_Button.ForeColor = System.Drawing.Color.White;
            this.About_Button.Image = global::TF2_Optimizer.Properties.Resources.Information;
            this.About_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.About_Button.ImageOffset = new System.Drawing.Point(4, 0);
            this.About_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.About_Button.Name = "About_Button";
            this.About_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.About_Button.PressedDepth = 1;
            this.About_Button.ShadowDecoration.BorderRadius = 0;
            this.About_Button.ShadowDecoration.Depth = 0;
            this.About_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // MenuLabel
            // 
            resources.ApplyResources(this.MenuLabel, "MenuLabel");
            this.MenuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLabel.Name = "MenuLabel";
            // 
            // Main_Panel
            // 
            resources.ApplyResources(this.Main_Panel, "Main_Panel");
            this.Main_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_Panel.Controls.Add(this.Settings_Panel);
            this.Main_Panel.Controls.Add(this.About_Panel);
            this.Main_Panel.Controls.Add(this.Mastercomfig_Panel);
            this.Main_Panel.Controls.Add(this.Custom_Install_Panel);
            this.Main_Panel.FillColor = System.Drawing.Color.DimGray;
            this.Main_Panel.FillColor2 = System.Drawing.Color.Transparent;
            this.Main_Panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Main_Panel.Name = "Main_Panel";
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Panel.Controls.Add(this.set_label7);
            this.Settings_Panel.Controls.Add(this.languageChanger);
            this.Settings_Panel.Controls.Add(this.set_label6);
            this.Settings_Panel.Controls.Add(this.ResetTF2_Button);
            this.Settings_Panel.Controls.Add(this.guna2Separator1);
            this.Settings_Panel.Controls.Add(this.set_label5);
            this.Settings_Panel.Controls.Add(this.set_label4);
            this.Settings_Panel.Controls.Add(this.set_label3);
            this.Settings_Panel.Controls.Add(this.set_label2);
            this.Settings_Panel.Controls.Add(this.TF2_Location);
            this.Settings_Panel.Controls.Add(this.Steam_Location);
            this.Settings_Panel.Controls.Add(this.set_label1);
            resources.ApplyResources(this.Settings_Panel, "Settings_Panel");
            this.Settings_Panel.Name = "Settings_Panel";
            // 
            // set_label7
            // 
            resources.ApplyResources(this.set_label7, "set_label7");
            this.set_label7.Name = "set_label7";
            // 
            // languageChanger
            // 
            this.languageChanger.BackColor = System.Drawing.Color.Transparent;
            this.languageChanger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.languageChanger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageChanger.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.languageChanger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.languageChanger, "languageChanger");
            this.languageChanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.languageChanger.Items.AddRange(new object[] {
            resources.GetString("languageChanger.Items"),
            resources.GetString("languageChanger.Items1")});
            this.languageChanger.Name = "languageChanger";
            this.languageChanger.SelectedIndexChanged += new System.EventHandler(this.languageChanger_SelectedIndexChanged);
            // 
            // set_label6
            // 
            resources.ApplyResources(this.set_label6, "set_label6");
            this.set_label6.Name = "set_label6";
            // 
            // ResetTF2_Button
            // 
            resources.ApplyResources(this.ResetTF2_Button, "ResetTF2_Button");
            this.ResetTF2_Button.Animated = true;
            this.ResetTF2_Button.BorderColor = System.Drawing.Color.White;
            this.ResetTF2_Button.BorderThickness = 1;
            this.ResetTF2_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetTF2_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetTF2_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetTF2_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetTF2_Button.FillColor = System.Drawing.Color.Transparent;
            this.ResetTF2_Button.ForeColor = System.Drawing.Color.White;
            this.ResetTF2_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ResetTF2_Button.ImageSize = new System.Drawing.Size(0, 0);
            this.ResetTF2_Button.Name = "ResetTF2_Button";
            this.ResetTF2_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.ResetTF2_Button.PressedDepth = 1;
            this.ResetTF2_Button.ShadowDecoration.BorderRadius = 0;
            this.ResetTF2_Button.ShadowDecoration.Depth = 0;
            this.ResetTF2_Button.Click += new System.EventHandler(this.ResetTF2_Button_Click);
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // set_label5
            // 
            resources.ApplyResources(this.set_label5, "set_label5");
            this.set_label5.Name = "set_label5";
            // 
            // set_label4
            // 
            resources.ApplyResources(this.set_label4, "set_label4");
            this.set_label4.Name = "set_label4";
            // 
            // set_label3
            // 
            resources.ApplyResources(this.set_label3, "set_label3");
            this.set_label3.Name = "set_label3";
            // 
            // set_label2
            // 
            resources.ApplyResources(this.set_label2, "set_label2");
            this.set_label2.Name = "set_label2";
            // 
            // TF2_Location
            // 
            resources.ApplyResources(this.TF2_Location, "TF2_Location");
            this.TF2_Location.Animated = true;
            this.TF2_Location.BorderColor = System.Drawing.Color.DarkOrange;
            this.TF2_Location.BorderRadius = 2;
            this.TF2_Location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TF2_Location.DefaultText = "";
            this.TF2_Location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TF2_Location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TF2_Location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TF2_Location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TF2_Location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TF2_Location.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TF2_Location.Name = "TF2_Location";
            this.TF2_Location.PasswordChar = '\0';
            this.TF2_Location.PlaceholderText = "";
            this.TF2_Location.SelectedText = "";
            this.TF2_Location.Click += new System.EventHandler(this.TF2_Location_Click);
            // 
            // Steam_Location
            // 
            resources.ApplyResources(this.Steam_Location, "Steam_Location");
            this.Steam_Location.Animated = true;
            this.Steam_Location.BorderColor = System.Drawing.Color.DarkOrange;
            this.Steam_Location.BorderRadius = 2;
            this.Steam_Location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Steam_Location.DefaultText = "";
            this.Steam_Location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Steam_Location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Steam_Location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Steam_Location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Steam_Location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Steam_Location.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Steam_Location.Name = "Steam_Location";
            this.Steam_Location.PasswordChar = '\0';
            this.Steam_Location.PlaceholderText = "";
            this.Steam_Location.SelectedText = "";
            this.Steam_Location.Click += new System.EventHandler(this.Steam_Location_Click);
            // 
            // set_label1
            // 
            resources.ApplyResources(this.set_label1, "set_label1");
            this.set_label1.Name = "set_label1";
            // 
            // About_Panel
            // 
            this.About_Panel.BackColor = System.Drawing.Color.Transparent;
            this.About_Panel.Controls.Add(this.Discord_Link);
            this.About_Panel.Controls.Add(this.Github_Link);
            this.About_Panel.Controls.Add(this.Youtube_Link);
            this.About_Panel.Controls.Add(this.SubTitle);
            this.About_Panel.Controls.Add(this.Title);
            resources.ApplyResources(this.About_Panel, "About_Panel");
            this.About_Panel.Name = "About_Panel";
            // 
            // Discord_Link
            // 
            resources.ApplyResources(this.Discord_Link, "Discord_Link");
            this.Discord_Link.Image = global::TF2_Optimizer.Properties.Resources.Discord;
            this.Discord_Link.Name = "Discord_Link";
            this.Discord_Link.TabStop = false;
            this.Discord_Link.Click += new System.EventHandler(this.Discord_Link_Click);
            // 
            // Github_Link
            // 
            resources.ApplyResources(this.Github_Link, "Github_Link");
            this.Github_Link.Image = global::TF2_Optimizer.Properties.Resources.Github;
            this.Github_Link.Name = "Github_Link";
            this.Github_Link.TabStop = false;
            this.Github_Link.Click += new System.EventHandler(this.Github_Link_Click);
            // 
            // Youtube_Link
            // 
            resources.ApplyResources(this.Youtube_Link, "Youtube_Link");
            this.Youtube_Link.Image = global::TF2_Optimizer.Properties.Resources.Youtube;
            this.Youtube_Link.Name = "Youtube_Link";
            this.Youtube_Link.TabStop = false;
            this.Youtube_Link.Click += new System.EventHandler(this.Youtube_Link_Click);
            // 
            // SubTitle
            // 
            resources.ApplyResources(this.SubTitle, "SubTitle");
            this.SubTitle.Name = "SubTitle";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // Mastercomfig_Panel
            // 
            this.Mastercomfig_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Mastercomfig_Panel.BackgroundImage = global::TF2_Optimizer.Properties.Resources.cp_badlands01;
            resources.ApplyResources(this.Mastercomfig_Panel, "Mastercomfig_Panel");
            this.Mastercomfig_Panel.Controls.Add(this.progressBar);
            this.Mastercomfig_Panel.Controls.Add(this.msconfig_pre_label);
            this.Mastercomfig_Panel.Controls.Add(this.msconf_preset_combo);
            this.Mastercomfig_Panel.Controls.Add(this.Configure_mastercomf);
            this.Mastercomfig_Panel.Name = "Mastercomfig_Panel";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Animated = true;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Minimum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.DarkOrange;
            this.progressBar.ProgressColor2 = System.Drawing.Color.Peru;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.UseTransparentBackground = true;
            // 
            // msconfig_pre_label
            // 
            resources.ApplyResources(this.msconfig_pre_label, "msconfig_pre_label");
            this.msconfig_pre_label.Name = "msconfig_pre_label";
            // 
            // msconf_preset_combo
            // 
            resources.ApplyResources(this.msconf_preset_combo, "msconf_preset_combo");
            this.msconf_preset_combo.BackColor = System.Drawing.Color.Transparent;
            this.msconf_preset_combo.BorderColor = System.Drawing.Color.DimGray;
            this.msconf_preset_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.msconf_preset_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.msconf_preset_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msconf_preset_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msconf_preset_combo.ForeColor = System.Drawing.Color.DarkOrange;
            this.msconf_preset_combo.Items.AddRange(new object[] {
            resources.GetString("msconf_preset_combo.Items"),
            resources.GetString("msconf_preset_combo.Items1"),
            resources.GetString("msconf_preset_combo.Items2"),
            resources.GetString("msconf_preset_combo.Items3"),
            resources.GetString("msconf_preset_combo.Items4"),
            resources.GetString("msconf_preset_combo.Items5"),
            resources.GetString("msconf_preset_combo.Items6")});
            this.msconf_preset_combo.Name = "msconf_preset_combo";
            this.msconf_preset_combo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            // 
            // Configure_mastercomf
            // 
            this.Configure_mastercomf.Animated = true;
            this.Configure_mastercomf.BorderColor = System.Drawing.Color.White;
            this.Configure_mastercomf.BorderThickness = 1;
            this.Configure_mastercomf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Configure_mastercomf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Configure_mastercomf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Configure_mastercomf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.Configure_mastercomf, "Configure_mastercomf");
            this.Configure_mastercomf.FillColor = System.Drawing.Color.Transparent;
            this.Configure_mastercomf.ForeColor = System.Drawing.Color.White;
            this.Configure_mastercomf.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Configure_mastercomf.ImageSize = new System.Drawing.Size(0, 0);
            this.Configure_mastercomf.Name = "Configure_mastercomf";
            this.Configure_mastercomf.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Configure_mastercomf.PressedDepth = 1;
            this.Configure_mastercomf.ShadowDecoration.BorderRadius = 0;
            this.Configure_mastercomf.ShadowDecoration.Depth = 0;
            this.Configure_mastercomf.Click += new System.EventHandler(this.Configure_mastercomf_Click);
            // 
            // Custom_Install_Panel
            // 
            this.Custom_Install_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Custom_Install_Panel.Controls.Add(this.OpenFileDI);
            this.Custom_Install_Panel.Controls.Add(this.DropInstall);
            this.Custom_Install_Panel.Controls.Add(this.Custom_Install);
            this.Custom_Install_Panel.Controls.Add(this.ci_label2);
            this.Custom_Install_Panel.Controls.Add(this.ci_label1);
            resources.ApplyResources(this.Custom_Install_Panel, "Custom_Install_Panel");
            this.Custom_Install_Panel.Name = "Custom_Install_Panel";
            // 
            // OpenFileDI
            // 
            resources.ApplyResources(this.OpenFileDI, "OpenFileDI");
            this.OpenFileDI.Animated = true;
            this.OpenFileDI.BorderColor = System.Drawing.Color.Transparent;
            this.OpenFileDI.CustomBorderColor = System.Drawing.Color.White;
            this.OpenFileDI.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.OpenFileDI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenFileDI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenFileDI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenFileDI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenFileDI.FillColor = System.Drawing.Color.Transparent;
            this.OpenFileDI.ForeColor = System.Drawing.Color.White;
            this.OpenFileDI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OpenFileDI.ImageSize = new System.Drawing.Size(0, 0);
            this.OpenFileDI.Name = "OpenFileDI";
            this.OpenFileDI.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.OpenFileDI.PressedDepth = 1;
            this.OpenFileDI.ShadowDecoration.BorderRadius = 0;
            this.OpenFileDI.ShadowDecoration.Depth = 0;
            this.OpenFileDI.Click += new System.EventHandler(this.OpenFileDI_Click);
            // 
            // DropInstall
            // 
            this.DropInstall.AllowDrop = true;
            this.DropInstall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.DropInstall, "DropInstall");
            this.DropInstall.ForeColor = System.Drawing.Color.DarkOrange;
            this.DropInstall.FormattingEnabled = true;
            this.DropInstall.Name = "DropInstall";
            this.DropInstall.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropInstall_DragDrop);
            this.DropInstall.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropInstall_DragEnter);
            // 
            // Custom_Install
            // 
            this.Custom_Install.Animated = true;
            this.Custom_Install.BorderColor = System.Drawing.Color.White;
            this.Custom_Install.BorderThickness = 1;
            this.Custom_Install.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Custom_Install.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Custom_Install.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Custom_Install.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.Custom_Install, "Custom_Install");
            this.Custom_Install.FillColor = System.Drawing.Color.Transparent;
            this.Custom_Install.ForeColor = System.Drawing.Color.White;
            this.Custom_Install.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Custom_Install.ImageSize = new System.Drawing.Size(0, 0);
            this.Custom_Install.Name = "Custom_Install";
            this.Custom_Install.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Custom_Install.PressedDepth = 1;
            this.Custom_Install.ShadowDecoration.BorderRadius = 0;
            this.Custom_Install.ShadowDecoration.Depth = 0;
            this.Custom_Install.Click += new System.EventHandler(this.Custom_Install_Click);
            // 
            // ci_label2
            // 
            resources.ApplyResources(this.ci_label2, "ci_label2");
            this.ci_label2.Name = "ci_label2";
            // 
            // ci_label1
            // 
            resources.ApplyResources(this.ci_label1, "ci_label1");
            this.ci_label1.Name = "ci_label1";
            // 
            // AnimateTF_Icon
            // 
            this.AnimateTF_Icon.Interval = 1;
            this.AnimateTF_Icon.Tick += new System.EventHandler(this.AnimateTF_Icon_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::TF2_Optimizer.Properties.Resources.tf2_background;
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.Main_Panel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Left_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TF2_Icon)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.Settings_Panel.ResumeLayout(false);
            this.Settings_Panel.PerformLayout();
            this.About_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Discord_Link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github_Link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Youtube_Link)).EndInit();
            this.Mastercomfig_Panel.ResumeLayout(false);
            this.Custom_Install_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel Left_Panel;
        private Guna.UI2.WinForms.Guna2Button Auto_Opti_Button;
        private Guna.UI2.WinForms.Guna2Button CustomMod_Button;
        private Guna.UI2.WinForms.Guna2Button Useful_Mods_Button;
        private Guna.UI2.WinForms.Guna2Button PopHUDs_Button;
        private Guna.UI2.WinForms.Guna2Button mastercomfig_Button;
        private Guna.UI2.WinForms.Guna2Button About_Button;
        private Guna.UI2.WinForms.Guna2GradientPanel Main_Panel;
        private Guna.UI2.WinForms.Guna2Button Settings_Button;
        private Guna.UI2.WinForms.Guna2Panel About_Panel;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2Panel Mastercomfig_Panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TF2_Icon;
        private System.Windows.Forms.Label MenuLabel;
        private Guna.UI2.WinForms.Guna2Button Configure_mastercomf;
        private System.Windows.Forms.Timer AnimateTF_Icon;
        private System.Windows.Forms.Label msconfig_pre_label;
        private Guna.UI2.WinForms.Guna2ComboBox msconf_preset_combo;
        private Guna.UI2.WinForms.Guna2Panel Custom_Install_Panel;
        private System.Windows.Forms.Label ci_label2;
        private System.Windows.Forms.Label ci_label1;
        private Guna.UI2.WinForms.Guna2Button Custom_Install;
        private System.Windows.Forms.ListBox DropInstall;
        private Guna.UI2.WinForms.Guna2Panel Settings_Panel;
        private System.Windows.Forms.Label set_label1;
        private Guna.UI2.WinForms.Guna2Button OpenFileDI;
        private System.Windows.Forms.Label set_label3;
        private System.Windows.Forms.Label set_label2;
        private Guna.UI2.WinForms.Guna2TextBox TF2_Location;
        private Guna.UI2.WinForms.Guna2TextBox Steam_Location;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label set_label5;
        private System.Windows.Forms.Label set_label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button ResetTF2_Button;
        private System.Windows.Forms.Label set_label6;
        private System.Windows.Forms.PictureBox Discord_Link;
        private System.Windows.Forms.PictureBox Github_Link;
        private System.Windows.Forms.PictureBox Youtube_Link;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private System.Windows.Forms.Label set_label7;
        private Guna.UI2.WinForms.Guna2ComboBox languageChanger;
    }
}

