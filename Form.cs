using Octokit;
using System;
using System.Drawing;
using System.Drawing.Text;

namespace TF2_Optimizer
{
    public partial class Form : System.Windows.Forms.Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private readonly PrivateFontCollection fonts = new PrivateFontCollection();
        private readonly Font tf2_font_regular;
        private readonly Font tf2_font_small;
        private readonly Font tf2_font_bold;

        public Form()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.tf2build;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.tf2build.Length);
            _ = AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.tf2build.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            tf2_font_regular = new Font(fonts.Families[0], 14.25F, FontStyle.Regular);
            tf2_font_small = new Font(fonts.Families[0], 12.25F, FontStyle.Regular);
            tf2_font_bold = new Font(fonts.Families[0], 20.25F, FontStyle.Bold);

            MenuLabel.Font = tf2_font_bold;
            Title.Font = tf2_font_bold;
            SubTitle.Font = tf2_font_small;
            About_Button.Font = tf2_font_regular;
            mastercomfig_Button.Font = tf2_font_regular;
            PopHUDs_Button.Font = tf2_font_regular;
            Useful_Mods_Button.Font = tf2_font_regular;
            CustomMod_Button.Font = tf2_font_regular;
            Auto_Opti_Button.Font = tf2_font_regular;
            Settings_Button.Font = tf2_font_regular;
        }

        #region Strings
        private readonly string tf2 = "C:\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\custom";
        private readonly string hitkillsounds = "C:\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\custom\\hitsound\\sound\\ui";
        private readonly string customcfg = "C:\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\cfg";
        private readonly string downloadstring = "https://gamebanana.com/dl/";
        private readonly GitHubClient client = new(new ProductHeaderValue("LatestRelease"));
        private bool LPanel_Expand;

        private readonly string[] MasterComfig =
        {
            "/mastercomfig-very-low-preset.vpk",
            "/mastercomfig-low-preset.vpk",
            "/mastercomfig-medium-low-preset.vpk",
            "/mastercomfig-medium-high-preset.vpk",
            "/mastercomfig-high-preset.vpk",
            "/mastercomfig-ultra-preset.vpk"
        };

        private string GetLatestMCRelease(string RepoOwner, string RepoName, byte MCFG)
        {
            return client.Repository.Release.GetLatest(RepoOwner, RepoName).Result.HtmlUrl + MasterComfig[MCFG];
        }

        private readonly string[] AllHUDs =
        {

        };
        #endregion

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void SearchTF2Folder()
        {

        }

        private void ResetTF2()
        {

        }

        private void TF2_Icon_Click(object sender, EventArgs e)
        {
            if (Left_Panel.Width != 132)
            {
                Left_Panel.Hide();
                LPanel_Expand = true;
                MenuLabel.Text = "";
                About_Button.Text = "";
                mastercomfig_Button.Text = "";
                PopHUDs_Button.Text = "";
                Useful_Mods_Button.Text = "";
                CustomMod_Button.Text = "";
                Auto_Opti_Button.Text = "";
                Settings_Button.Text = "";
                Main_Panel.Left = 173;
                Main_Panel.Width = 1091;
                Left_Panel.Width = 132;
                guna2Transition1.ShowSync(Left_Panel);
            }
            else
            {
                Left_Panel.Hide();
                MenuLabel.Text = "M E N U";
                About_Button.Text = "About";
                mastercomfig_Button.Text = "mastercomfig";
                PopHUDs_Button.Text = "Populer HUDs";
                Useful_Mods_Button.Text = "Useful Mods";
                CustomMod_Button.Text = "Custom Install";
                Auto_Opti_Button.Text = "Automated Optimization";
                Settings_Button.Text = "Settings";
                Main_Panel.Left = 362;
                Main_Panel.Width = 902;
                Left_Panel.Width = 320;
                guna2Transition1.ShowSync(Left_Panel);
            }
            //LeftPanel_Timer.Start();
        }

        private void AnimateTF_Icon_Tick(object sender, EventArgs e)
        {
            TF2_Icon.ImageRotate += 1;
        }

        private void TF2_Icon_MouseEnter(object sender, EventArgs e)
        {
            AnimateTF_Icon.Start();
        }

        private void TF2_Icon_MouseLeave(object sender, EventArgs e)
        {
            AnimateTF_Icon.Stop();
        }

        private void LeftPanel_Timer_Tick(object sender, EventArgs e)
        {
            if (LPanel_Expand)
            {
                Left_Panel.Width -= 10;
                Main_Panel.Left -= 10;
                Main_Panel.Width += 10;
                if (Left_Panel.Width == 132)
                {
                    LPanel_Expand = false;
                    LeftPanel_Timer.Stop();
                }
            }
            else
            {
                Left_Panel.Width += 10;
                Main_Panel.Left += 10;
                Main_Panel.Width -= 10;
                if (Left_Panel.Width == 320)
                {
                    LPanel_Expand = true;
                    LeftPanel_Timer.Stop();
                }
            }
        }
    }
}