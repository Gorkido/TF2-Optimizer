using Octokit;
using System;

namespace TF2_Mod_Installer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        #region Strings
        private readonly string tf2 = "C:\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\custom";
        private readonly string hitkillsounds = "C:\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\custom\\hitsound\\sound\\ui";
        private readonly string customcfg = "C:\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\cfg";
        private readonly string downloadstring = "https://gamebanana.com/dl/";
        private readonly GitHubClient client = new GitHubClient(new ProductHeaderValue("LatestRelease"));

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

        private void Form_Load(object sender, System.EventArgs e)
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
            if (Left_Panel.Width == 320)
            {
                Left_Panel.Visible = false;
                About_Button.Text = "";
                mastercomfig_Button.Text = "";
                PopHUDs_Button.Text = "";
                Useful_Mods_Button.Text = "";
                CustomMod_Button.Text = "";
                Left_Panel.Width = 132;
                panelTransition.ShowSync(Left_Panel);
            }
            else
            {
                Left_Panel.Visible = false;
                About_Button.Text = "About";
                mastercomfig_Button.Text = "mastercomfig";
                PopHUDs_Button.Text = "Populer HUDs";
                Useful_Mods_Button.Text = "Useful Mods";
                CustomMod_Button.Text = "Custom Install";
                Left_Panel.Width = 320;
                panelTransition.ShowSync(Left_Panel);
            }
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
    }
}