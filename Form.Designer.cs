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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Left_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Settings_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Auto_Opti_Button = new Guna.UI2.WinForms.Guna2Button();
            this.CustomMod_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Useful_Mods_Button = new Guna.UI2.WinForms.Guna2Button();
            this.PopHUDs_Button = new Guna.UI2.WinForms.Guna2Button();
            this.mastercomfig_Button = new Guna.UI2.WinForms.Guna2Button();
            this.About_Button = new Guna.UI2.WinForms.Guna2Button();
            this.TF2_Icon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.Main_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.AnimateTF_Icon = new System.Windows.Forms.Timer(this.components);
            this.LeftPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.Title = new System.Windows.Forms.Label();
            this.SubTitle = new System.Windows.Forms.Label();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TF2_Icon)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.guna2Transition1.SetDecoration(this.Left_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Left_Panel.FillColor = System.Drawing.Color.DimGray;
            this.Left_Panel.FillColor2 = System.Drawing.Color.Transparent;
            this.Left_Panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Left_Panel.Location = new System.Drawing.Point(20, 20);
            this.Left_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Left_Panel.MaximumSize = new System.Drawing.Size(320, 1000000000);
            this.Left_Panel.MinimumSize = new System.Drawing.Size(132, 726);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Padding = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.Left_Panel.Size = new System.Drawing.Size(320, 726);
            this.Left_Panel.TabIndex = 1;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Animated = true;
            this.Settings_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Settings_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Settings_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Button.FillColor = System.Drawing.Color.Transparent;
            this.Settings_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.Settings_Button.ForeColor = System.Drawing.Color.White;
            this.Settings_Button.Image = global::TF2_Optimizer.Properties.Resources.settings;
            this.Settings_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings_Button.ImageOffset = new System.Drawing.Point(9, 0);
            this.Settings_Button.ImageSize = new System.Drawing.Size(45, 45);
            this.Settings_Button.Location = new System.Drawing.Point(25, 568);
            this.Settings_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Settings_Button.PressedDepth = 1;
            this.Settings_Button.Size = new System.Drawing.Size(270, 75);
            this.Settings_Button.TabIndex = 47;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.Settings_Button.UseTransparentBackground = true;
            // 
            // Auto_Opti_Button
            // 
            this.Auto_Opti_Button.Animated = true;
            this.Auto_Opti_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Auto_Opti_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Auto_Opti_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Auto_Opti_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Auto_Opti_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Auto_Opti_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Auto_Opti_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Auto_Opti_Button.FillColor = System.Drawing.Color.Transparent;
            this.Auto_Opti_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.Auto_Opti_Button.ForeColor = System.Drawing.Color.White;
            this.Auto_Opti_Button.Image = global::TF2_Optimizer.Properties.Resources.automated;
            this.Auto_Opti_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Auto_Opti_Button.ImageOffset = new System.Drawing.Point(5, 0);
            this.Auto_Opti_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.Auto_Opti_Button.Location = new System.Drawing.Point(25, 493);
            this.Auto_Opti_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Auto_Opti_Button.Name = "Auto_Opti_Button";
            this.Auto_Opti_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Auto_Opti_Button.PressedDepth = 1;
            this.Auto_Opti_Button.Size = new System.Drawing.Size(270, 75);
            this.Auto_Opti_Button.TabIndex = 46;
            this.Auto_Opti_Button.Text = "Automated Optimization";
            this.Auto_Opti_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.Auto_Opti_Button.UseTransparentBackground = true;
            // 
            // CustomMod_Button
            // 
            this.CustomMod_Button.Animated = true;
            this.CustomMod_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.CustomMod_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CustomMod_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomMod_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomMod_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomMod_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomMod_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomMod_Button.FillColor = System.Drawing.Color.Transparent;
            this.CustomMod_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.CustomMod_Button.ForeColor = System.Drawing.Color.White;
            this.CustomMod_Button.Image = global::TF2_Optimizer.Properties.Resources.Custom;
            this.CustomMod_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomMod_Button.ImageOffset = new System.Drawing.Point(10, 0);
            this.CustomMod_Button.ImageSize = new System.Drawing.Size(42, 42);
            this.CustomMod_Button.Location = new System.Drawing.Point(25, 418);
            this.CustomMod_Button.Margin = new System.Windows.Forms.Padding(0);
            this.CustomMod_Button.Name = "CustomMod_Button";
            this.CustomMod_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.CustomMod_Button.PressedDepth = 1;
            this.CustomMod_Button.Size = new System.Drawing.Size(270, 75);
            this.CustomMod_Button.TabIndex = 45;
            this.CustomMod_Button.Text = "Custom Install";
            this.CustomMod_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.CustomMod_Button.UseTransparentBackground = true;
            // 
            // Useful_Mods_Button
            // 
            this.Useful_Mods_Button.Animated = true;
            this.Useful_Mods_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Useful_Mods_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Useful_Mods_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Useful_Mods_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Useful_Mods_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Useful_Mods_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Useful_Mods_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Useful_Mods_Button.FillColor = System.Drawing.Color.Transparent;
            this.Useful_Mods_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.Useful_Mods_Button.ForeColor = System.Drawing.Color.White;
            this.Useful_Mods_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Useful_Mods_Button.ImageOffset = new System.Drawing.Point(3, 0);
            this.Useful_Mods_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.Useful_Mods_Button.Location = new System.Drawing.Point(25, 343);
            this.Useful_Mods_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Useful_Mods_Button.Name = "Useful_Mods_Button";
            this.Useful_Mods_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.Useful_Mods_Button.PressedDepth = 1;
            this.Useful_Mods_Button.Size = new System.Drawing.Size(270, 75);
            this.Useful_Mods_Button.TabIndex = 44;
            this.Useful_Mods_Button.Text = "Useful Mods";
            this.Useful_Mods_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.Useful_Mods_Button.UseTransparentBackground = true;
            // 
            // PopHUDs_Button
            // 
            this.PopHUDs_Button.Animated = true;
            this.PopHUDs_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.PopHUDs_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PopHUDs_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PopHUDs_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PopHUDs_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PopHUDs_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PopHUDs_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.PopHUDs_Button.FillColor = System.Drawing.Color.Transparent;
            this.PopHUDs_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.PopHUDs_Button.ForeColor = System.Drawing.Color.White;
            this.PopHUDs_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PopHUDs_Button.ImageOffset = new System.Drawing.Point(3, 0);
            this.PopHUDs_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.PopHUDs_Button.Location = new System.Drawing.Point(25, 268);
            this.PopHUDs_Button.Margin = new System.Windows.Forms.Padding(0);
            this.PopHUDs_Button.Name = "PopHUDs_Button";
            this.PopHUDs_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.PopHUDs_Button.PressedDepth = 1;
            this.PopHUDs_Button.Size = new System.Drawing.Size(270, 75);
            this.PopHUDs_Button.TabIndex = 43;
            this.PopHUDs_Button.Text = "Fresh HUDs";
            this.PopHUDs_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.PopHUDs_Button.UseTransparentBackground = true;
            // 
            // mastercomfig_Button
            // 
            this.mastercomfig_Button.Animated = true;
            this.mastercomfig_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.mastercomfig_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mastercomfig_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mastercomfig_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mastercomfig_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mastercomfig_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mastercomfig_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.mastercomfig_Button.FillColor = System.Drawing.Color.Transparent;
            this.mastercomfig_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.mastercomfig_Button.ForeColor = System.Drawing.Color.White;
            this.mastercomfig_Button.Image = ((System.Drawing.Image)(resources.GetObject("mastercomfig_Button.Image")));
            this.mastercomfig_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mastercomfig_Button.ImageOffset = new System.Drawing.Point(2, 0);
            this.mastercomfig_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.mastercomfig_Button.Location = new System.Drawing.Point(25, 193);
            this.mastercomfig_Button.Margin = new System.Windows.Forms.Padding(0);
            this.mastercomfig_Button.Name = "mastercomfig_Button";
            this.mastercomfig_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.mastercomfig_Button.PressedDepth = 1;
            this.mastercomfig_Button.Size = new System.Drawing.Size(270, 75);
            this.mastercomfig_Button.TabIndex = 42;
            this.mastercomfig_Button.Text = "mastercomfig";
            this.mastercomfig_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.mastercomfig_Button.UseTransparentBackground = true;
            // 
            // About_Button
            // 
            this.About_Button.Animated = true;
            this.About_Button.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.About_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.About_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.About_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.About_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.About_Button.FillColor = System.Drawing.Color.Transparent;
            this.About_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.About_Button.ForeColor = System.Drawing.Color.White;
            this.About_Button.Image = global::TF2_Optimizer.Properties.Resources.information;
            this.About_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.About_Button.ImageOffset = new System.Drawing.Point(4, 0);
            this.About_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.About_Button.Location = new System.Drawing.Point(25, 118);
            this.About_Button.Margin = new System.Windows.Forms.Padding(0);
            this.About_Button.Name = "About_Button";
            this.About_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.About_Button.PressedDepth = 1;
            this.About_Button.Size = new System.Drawing.Size(270, 75);
            this.About_Button.TabIndex = 41;
            this.About_Button.Text = "About";
            this.About_Button.TextOffset = new System.Drawing.Point(51, 0);
            this.About_Button.UseTransparentBackground = true;
            // 
            // TF2_Icon
            // 
            this.TF2_Icon.BackColor = System.Drawing.Color.Transparent;
            this.TF2_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Transition1.SetDecoration(this.TF2_Icon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TF2_Icon.Image = ((System.Drawing.Image)(resources.GetObject("TF2_Icon.Image")));
            this.TF2_Icon.ImageRotate = 354F;
            this.TF2_Icon.Location = new System.Drawing.Point(15, 16);
            this.TF2_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.TF2_Icon.Name = "TF2_Icon";
            this.TF2_Icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TF2_Icon.Size = new System.Drawing.Size(100, 100);
            this.TF2_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TF2_Icon.TabIndex = 36;
            this.TF2_Icon.TabStop = false;
            this.TF2_Icon.Click += new System.EventHandler(this.TF2_Icon_Click);
            this.TF2_Icon.MouseEnter += new System.EventHandler(this.TF2_Icon_MouseEnter);
            this.TF2_Icon.MouseLeave += new System.EventHandler(this.TF2_Icon_MouseLeave);
            // 
            // MenuLabel
            // 
            this.guna2Transition1.SetDecoration(this.MenuLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MenuLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLabel.Font = new System.Drawing.Font("Hack", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(25, 10);
            this.MenuLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Padding = new System.Windows.Forms.Padding(110, 40, 0, 0);
            this.MenuLabel.Size = new System.Drawing.Size(270, 108);
            this.MenuLabel.TabIndex = 38;
            this.MenuLabel.Text = "M E N U";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_Panel.Controls.Add(this.SubTitle);
            this.Main_Panel.Controls.Add(this.Title);
            this.guna2Transition1.SetDecoration(this.Main_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Main_Panel.FillColor = System.Drawing.Color.DimGray;
            this.Main_Panel.FillColor2 = System.Drawing.Color.Transparent;
            this.Main_Panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Main_Panel.Location = new System.Drawing.Point(362, 20);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Panel.MinimumSize = new System.Drawing.Size(902, 726);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Padding = new System.Windows.Forms.Padding(25);
            this.Main_Panel.Size = new System.Drawing.Size(902, 726);
            this.Main_Panel.TabIndex = 2;
            // 
            // AnimateTF_Icon
            // 
            this.AnimateTF_Icon.Interval = 10;
            this.AnimateTF_Icon.Tick += new System.EventHandler(this.AnimateTF_Icon_Tick);
            // 
            // LeftPanel_Timer
            // 
            this.LeftPanel_Timer.Interval = 1;
            this.LeftPanel_Timer.Tick += new System.EventHandler(this.LeftPanel_Timer_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // Title
            // 
            this.guna2Transition1.SetDecoration(this.Title, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(25, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(852, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "TF2 Optimizer/Mod Installer";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTitle
            // 
            this.guna2Transition1.SetDecoration(this.SubTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubTitle.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitle.Location = new System.Drawing.Point(25, 55);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(852, 30);
            this.SubTitle.TabIndex = 1;
            this.SubTitle.Text = "An application to optimize tf2 and install mods.";
            this.SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::TF2_Optimizer.Properties.Resources.tf2_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 766);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.Main_Panel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TF2 Optimizer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Left_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TF2_Icon)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer AnimateTF_Icon;
        private Guna.UI2.WinForms.Guna2GradientPanel Left_Panel;
        private Guna.UI2.WinForms.Guna2Button Auto_Opti_Button;
        private Guna.UI2.WinForms.Guna2Button CustomMod_Button;
        private Guna.UI2.WinForms.Guna2Button Useful_Mods_Button;
        private Guna.UI2.WinForms.Guna2Button PopHUDs_Button;
        private Guna.UI2.WinForms.Guna2Button mastercomfig_Button;
        private Guna.UI2.WinForms.Guna2Button About_Button;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TF2_Icon;
        private System.Windows.Forms.Label MenuLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel Main_Panel;
        private System.Windows.Forms.Timer LeftPanel_Timer;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Button Settings_Button;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubTitle;
    }
}

