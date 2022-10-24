namespace TF2_Mod_Installer
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
            Guna.UI2.AnimatorNS.Animation animation6 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.panelTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.AnimateTF_Icon = new System.Windows.Forms.Timer(this.components);
            this.Back_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Left_Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.CustomMod_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Useful_Mods_Button = new Guna.UI2.WinForms.Guna2Button();
            this.PopHUDs_Button = new Guna.UI2.WinForms.Guna2Button();
            this.mastercomfig_Button = new Guna.UI2.WinForms.Guna2Button();
            this.About_Button = new Guna.UI2.WinForms.Guna2Button();
            this.TF2_Icon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.Back_Panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TF2_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.panelTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.panelTransition.DefaultAnimation = animation6;
            this.panelTransition.Interval = 1;
            // 
            // AnimateTF_Icon
            // 
            this.AnimateTF_Icon.Interval = 10;
            this.AnimateTF_Icon.Tick += new System.EventHandler(this.AnimateTF_Icon_Tick);
            // 
            // Back_Panel
            // 
            this.Back_Panel.AllowDrop = true;
            this.Back_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_Panel.BackColor = System.Drawing.Color.DimGray;
            this.Back_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Panel.BackgroundImage")));
            this.Back_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Panel.Controls.Add(this.Left_Panel);
            this.panelTransition.SetDecoration(this.Back_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Back_Panel.FillColor = System.Drawing.Color.Empty;
            this.Back_Panel.FillColor2 = System.Drawing.Color.Empty;
            this.Back_Panel.FillColor3 = System.Drawing.Color.Empty;
            this.Back_Panel.FillColor4 = System.Drawing.Color.Empty;
            this.Back_Panel.ForeColor = System.Drawing.Color.Transparent;
            this.Back_Panel.Location = new System.Drawing.Point(0, 0);
            this.Back_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Back_Panel.Name = "Back_Panel";
            this.Back_Panel.Padding = new System.Windows.Forms.Padding(20);
            this.Back_Panel.Quality = 1;
            this.Back_Panel.Size = new System.Drawing.Size(1285, 766);
            this.Back_Panel.TabIndex = 0;
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Left_Panel.Controls.Add(this.guna2Button1);
            this.Left_Panel.Controls.Add(this.CustomMod_Button);
            this.Left_Panel.Controls.Add(this.Useful_Mods_Button);
            this.Left_Panel.Controls.Add(this.PopHUDs_Button);
            this.Left_Panel.Controls.Add(this.mastercomfig_Button);
            this.Left_Panel.Controls.Add(this.About_Button);
            this.Left_Panel.Controls.Add(this.TF2_Icon);
            this.Left_Panel.Controls.Add(this.MenuLabel);
            this.panelTransition.SetDecoration(this.Left_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.FillColor = System.Drawing.Color.DimGray;
            this.Left_Panel.FillColor2 = System.Drawing.Color.Transparent;
            this.Left_Panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Left_Panel.Location = new System.Drawing.Point(20, 20);
            this.Left_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Padding = new System.Windows.Forms.Padding(25);
            this.Left_Panel.Size = new System.Drawing.Size(320, 726);
            this.Left_Panel.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Hack", 14.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::TF2_Mod_Installer.Properties.Resources.automated;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(25, 494);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.guna2Button1.PressedDepth = 1;
            this.guna2Button1.Size = new System.Drawing.Size(270, 75);
            this.guna2Button1.TabIndex = 46;
            this.guna2Button1.Text = "Automated Optimization";
            this.guna2Button1.TextOffset = new System.Drawing.Point(51, 0);
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // CustomMod_Button
            // 
            this.CustomMod_Button.Animated = true;
            this.CustomMod_Button.BorderColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.CustomMod_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CustomMod_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomMod_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomMod_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomMod_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomMod_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomMod_Button.FillColor = System.Drawing.Color.Transparent;
            this.CustomMod_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.CustomMod_Button.ForeColor = System.Drawing.Color.White;
            this.CustomMod_Button.Image = global::TF2_Mod_Installer.Properties.Resources.Custom;
            this.CustomMod_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomMod_Button.ImageOffset = new System.Drawing.Point(10, 0);
            this.CustomMod_Button.ImageSize = new System.Drawing.Size(42, 42);
            this.CustomMod_Button.Location = new System.Drawing.Point(25, 419);
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
            this.panelTransition.SetDecoration(this.Useful_Mods_Button, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.Useful_Mods_Button.Location = new System.Drawing.Point(25, 344);
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
            this.panelTransition.SetDecoration(this.PopHUDs_Button, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.PopHUDs_Button.Location = new System.Drawing.Point(25, 269);
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
            this.panelTransition.SetDecoration(this.mastercomfig_Button, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.mastercomfig_Button.ImageOffset = new System.Drawing.Point(4, 0);
            this.mastercomfig_Button.ImageSize = new System.Drawing.Size(55, 55);
            this.mastercomfig_Button.Location = new System.Drawing.Point(25, 194);
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
            this.panelTransition.SetDecoration(this.About_Button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.About_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.About_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.About_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.About_Button.FillColor = System.Drawing.Color.Transparent;
            this.About_Button.Font = new System.Drawing.Font("Hack", 14.25F);
            this.About_Button.ForeColor = System.Drawing.Color.White;
            this.About_Button.Image = global::TF2_Mod_Installer.Properties.Resources.information;
            this.About_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.About_Button.ImageOffset = new System.Drawing.Point(5, 0);
            this.About_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.About_Button.Location = new System.Drawing.Point(25, 119);
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
            this.panelTransition.SetDecoration(this.TF2_Icon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TF2_Icon.Image = ((System.Drawing.Image)(resources.GetObject("TF2_Icon.Image")));
            this.TF2_Icon.ImageRotate = 355F;
            this.TF2_Icon.Location = new System.Drawing.Point(26, 25);
            this.TF2_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.TF2_Icon.Name = "TF2_Icon";
            this.TF2_Icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TF2_Icon.Size = new System.Drawing.Size(80, 80);
            this.TF2_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TF2_Icon.TabIndex = 36;
            this.TF2_Icon.TabStop = false;
            this.TF2_Icon.Click += new System.EventHandler(this.TF2_Icon_Click);
            this.TF2_Icon.MouseEnter += new System.EventHandler(this.TF2_Icon_MouseEnter);
            this.TF2_Icon.MouseLeave += new System.EventHandler(this.TF2_Icon_MouseLeave);
            // 
            // MenuLabel
            // 
            this.panelTransition.SetDecoration(this.MenuLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MenuLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLabel.Font = new System.Drawing.Font("Hack", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(25, 25);
            this.MenuLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Padding = new System.Windows.Forms.Padding(108, 23, 0, 0);
            this.MenuLabel.Size = new System.Drawing.Size(270, 94);
            this.MenuLabel.TabIndex = 38;
            this.MenuLabel.Text = "M E N U";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 766);
            this.Controls.Add(this.Back_Panel);
            this.panelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TF2 Optimizer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Back_Panel.ResumeLayout(false);
            this.Left_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TF2_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Back_Panel;
        private Guna.UI2.WinForms.Guna2GradientPanel Left_Panel;
        private Guna.UI2.WinForms.Guna2Transition panelTransition;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TF2_Icon;
        private System.Windows.Forms.Timer AnimateTF_Icon;
        private System.Windows.Forms.Label MenuLabel;
        private Guna.UI2.WinForms.Guna2Button About_Button;
        private Guna.UI2.WinForms.Guna2Button mastercomfig_Button;
        private Guna.UI2.WinForms.Guna2Button PopHUDs_Button;
        private Guna.UI2.WinForms.Guna2Button Useful_Mods_Button;
        private Guna.UI2.WinForms.Guna2Button CustomMod_Button;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

