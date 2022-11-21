using Aspose.Zip.SevenZip;
using Microsoft.Win32;
using Octokit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TF2_Optimizer
{
    public partial class Form : System.Windows.Forms.Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        private readonly PrivateFontCollection fonts = new PrivateFontCollection();

        public Form()
        {
            InitializeComponent();
            UI();
        }

        #region Strings
        //private static readonly string hitkillsounds = GetTF2Directory() + "\\tf\\custom\\hitsound\\sound\\ui\\";
        //private static readonly string cfg = GetTF2Directory() + "\\tf\\cfg\\";
        private readonly bool isTF2Running = Process.GetProcessesByName("hl2.exe").Any();
        private readonly GitHubClient client = new GitHubClient(new ProductHeaderValue("LatestRelease"));
        private readonly WebClient WClient = new WebClient();

        private string Custom => TF2_Location.Text + "\\tf\\custom\\";

        private readonly string[] MasterComfig =
        {
            "/mastercomfig-very-low-preset.vpk",
            "/mastercomfig-low-preset.vpk",
            "/mastercomfig-medium-low-preset.vpk",
            "/mastercomfig-medium-preset.vpk",
            "/mastercomfig-medium-high-preset.vpk",
            "/mastercomfig-high-preset.vpk",
            "/mastercomfig-ultra-preset.vpk",
            "/mastercomfig-lowmem-addon.vpk"
        };
        private readonly string[] AddonList =
        {
            "/mastercomfig-no-tutorial-addon.vpk",
            "/mastercomfig-no-soundscapes-addon.vpk",
            "/mastercomfig-null-canceling-movement-addon.vpk",
            "/mastercomfig-disable-pyroland-addon.vpk"
        };

        private readonly string[] GamebananaStrs =
        {
            "677961", // Flat Textures
            "467630", // Remove Sniper Scope
            "873049", // No Hats Mod (Pack)
            "/TF2UltimateVisualFix_000.vpk",
            "629105", // Transparent Arms
            "767925", // Unique Rockets
            "37714" // Realistic Skybox
        };

        private readonly string[] HudGitRepoRelease =
        {
            "/RenHUD.7z",
            "/flawhud-centered.zip",
            "/TF2.Optimizer.exe"
        };

        private string GetLatestMCRelease(string RepoOwner, string RepoName, int MCFG)
        {
            return (client.Repository.Release.GetLatest(RepoOwner, RepoName).Result.HtmlUrl + MasterComfig[MCFG]).Replace("tag", "download");
        }

        private string GetLatestGitRelease(string RepoOwner, string RepoName, int GHRP)
        {
            return (client.Repository.Release.GetLatest(RepoOwner, RepoName).Result.HtmlUrl + HudGitRepoRelease[GHRP]).Replace("tag", "download");
        }
        #endregion

        private void Form_Load(object sender, EventArgs e)
        {
            GetSteamDirectory();
            GetTF2Directory();

            renhud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/6339e7d4b3917.jpg";
            sunsethud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/6375462ecf1ac.jpg";
            warsawhud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/632a6be255007.jpg";
            hyphud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/60b699676dda0.jpg";
            hexhud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/62d0499459997.jpg";
            flawhud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/635dde90c8837.jpg";
            quakehud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/530-90_621d0fe12349b.jpg";
            quakehud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/530-90_621d0fe12349b.jpg";
            m0rehud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/60b6a0ef32f9d.jpg";
            toonhud_pic.ImageLocation = "https://images.gamebanana.com/img/ss/mods/5abfcec9e21ce.jpg";
        }

        private void UI()
        {
            byte[] fontData = Properties.Resources.tf2build;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.tf2build.Length);
            _ = AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.tf2build.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            Font tf2_font_regular = new Font(fonts.Families[0], 14.25F, FontStyle.Regular);
            Font tf2_font_small = new Font(fonts.Families[0], 12.25F, FontStyle.Regular);
            Font tf2_font_bold = new Font(fonts.Families[0], 20.25F, FontStyle.Bold);

            msconfig_pre_label.Font = tf2_font_bold;
            MenuLabel.Font = tf2_font_bold;
            Title.Font = tf2_font_bold;
            SubTitle.Font = tf2_font_small;
            About_Button.Font = tf2_font_regular;
            mastercomfig_Button.Font = tf2_font_regular;
            msconf_preset_combo.Font = tf2_font_regular;
            Configure_mastercomf.Font = tf2_font_regular;
            HUDs_Button.Font = tf2_font_regular;
            hud_lab1.Font = tf2_font_regular;
            hud_lab2.Font = tf2_font_regular;
            hud_lab3.Font = tf2_font_regular;
            hud_lab4.Font = tf2_font_regular;
            hud_lab5.Font = tf2_font_regular;
            hud_lab6.Font = tf2_font_regular;
            hud_lab7.Font = tf2_font_regular;
            hud_lab8.Font = tf2_font_regular;
            hud_lab9.Font = tf2_font_regular;
            Mods_Button.Font = tf2_font_regular;
            install_sel_mods.Font = tf2_font_regular;
            mods_lab1.Font = tf2_font_regular;
            mods_lab2.Font = tf2_font_regular;
            mods_lab3.Font = tf2_font_small;
            mods_lab4.Font = tf2_font_small;
            mods_lab5.Font = tf2_font_small;
            mods_lab6.Font = tf2_font_small;
            mods_lab7.Font = tf2_font_small;
            mods_lab10.Font = tf2_font_small;
            mods_lab11.Font = tf2_font_small;
            mods_lab12.Font = tf2_font_small;
            mods_lab13.Font = tf2_font_small;
            mods_lab14.Font = tf2_font_small;
            mods_lab15.Font = tf2_font_small;
            mods_lab16.Font = tf2_font_small;
            mods_lab17.Font = tf2_font_small;
            mods_lab18.Font = tf2_font_small;
            mods_lab19.Font = tf2_font_small;
            mods_lab20.Font = tf2_font_small;
            CustomMod_Button.Font = tf2_font_regular;
            ci_label1.Font = tf2_font_bold;
            ci_label2.Font = tf2_font_regular;
            OpenFileDI.Font = tf2_font_regular;
            DropInstall.Font = tf2_font_regular;
            Custom_Install.Font = tf2_font_regular;
            Settings_Button.Font = tf2_font_regular;
            set_label1.Font = tf2_font_bold;
            set_label2.Font = tf2_font_regular;
            set_label3.Font = tf2_font_regular;
            set_label4.Font = tf2_font_bold;
            set_label5.Font = tf2_font_regular;
            set_label6.Font = tf2_font_regular;
            set_label7.Font = tf2_font_regular;
            Steam_Location.Font = tf2_font_regular;
            TF2_Location.Font = tf2_font_regular;
            ResetTF2_Button.Font = tf2_font_regular;
        }

        private void GetSteamDirectory()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
                if (key != null)
                {
                    object o = key.GetValue("SteamPath");
                    if (o != null)
                    {
                        Steam_Location.Text = o.ToString().Replace("/", "\\");
                    }
                }
            }
            catch (Exception) { }
        }

        private void GetTF2Directory()
        {
            string TF2Dir = "\\steamapps\\common\\Team Fortress 2";
            string libfile = Steam_Location.Text + "\\steamapps\\libraryfolders.vdf";
            if (Directory.Exists(Steam_Location.Text + TF2Dir))
            {
                TF2_Location.Text = Steam_Location.Text + TF2Dir;
            }
            else
            {
                if (File.Exists(libfile))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(libfile, System.IO.FileMode.Open))
                        {
                            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                            {
                                string line = null;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (new Regex(@"path").IsMatch(line))
                                    {
                                        string path = line.Substring(line.LastIndexOf("-") + 1).Replace("\"path\"", " ").Replace("\"", "").Replace(":\\\\", ":\\").Normalize().Trim();
                                        if (Directory.Exists(path + TF2Dir))
                                        {
                                            TF2_Location.Text = path + TF2Dir;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    _ = MessageBox.Show("No other steam libraries found.");
                }
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

        private void About_Button_Click(object sender, EventArgs e)
        {
            Mastercomfig_Panel.Hide();
            Huds_Panel.Hide();
            Mods_Panel.Hide();
            Custom_Install_Panel.Hide();
            Settings_Panel.Hide();
            About_Panel.Show();
        }

        private void mastercomfig_Button_Click(object sender, EventArgs e)
        {
            About_Panel.Hide();
            Huds_Panel.Hide();
            Mods_Panel.Hide();
            Custom_Install_Panel.Hide();
            Settings_Panel.Hide();
            Mastercomfig_Panel.Show();
        }

        private void HUDs_Button_Click(object sender, EventArgs e)
        {
            About_Panel.Hide();
            Custom_Install_Panel.Hide();
            Mods_Panel.Hide();
            Settings_Panel.Hide();
            Mastercomfig_Panel.Hide();
            Huds_Panel.Show();
        }

        private void Mods_Button_Click(object sender, EventArgs e)
        {
            Mastercomfig_Panel.Hide();
            Huds_Panel.Hide();
            About_Panel.Hide();
            Settings_Panel.Hide();
            Custom_Install_Panel.Hide();
            Mods_Panel.Show();
        }

        private void CustomMod_Button_Click(object sender, EventArgs e)
        {
            Mastercomfig_Panel.Hide();
            Huds_Panel.Hide();
            Mods_Panel.Hide();
            About_Panel.Hide();
            Settings_Panel.Hide();
            Custom_Install_Panel.Show();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Mastercomfig_Panel.Hide();
            Huds_Panel.Hide();
            Mods_Panel.Hide();
            About_Panel.Hide();
            Custom_Install_Panel.Hide();
            Settings_Panel.Show();
        }

        #region Progress Bar
        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            _ = MessageBox.Show("mastercomfig has been installed.");
            progressBar.Hide();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        #endregion

        private void Configure_mastercomf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Custom))
                {
                    _ = Directory.CreateDirectory(Custom);
                }

                if (msconf_preset_combo.SelectedItem != null)
                {
                    if (MessageBox.Show($"Are you sure you want to install mastercomfig preset: {msconf_preset_combo.SelectedItem}?", "Install mastercomfig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        progressBar.Show();
                        if (Directory.Exists(Custom))
                        {
                            foreach (string vpks in MasterComfig)
                            {
                                if (File.Exists(Custom + vpks.Replace("/", "")))
                                {
                                    File.Delete(Custom + vpks.Replace("/", ""));
                                }
                            }
                            if (msconf_preset_combo.SelectedIndex == 0) // Very Low
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 0)), Custom + "mastercomfig-very-low-preset.vpk");
                                _ = GetPhysicallyInstalledSystemMemory(out long memKb);
                                long totalram = memKb / 1024 / 1024;
                                if (totalram < 4)
                                {
                                    WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 7)), Custom + "mastercomfig-lowmem-addon.vpk");
                                }
                            }
                            if (msconf_preset_combo.SelectedIndex == 1) // Low
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 1)), Custom + "mastercomfig-low-preset.vpk");
                            }
                            if (msconf_preset_combo.SelectedIndex == 2) // Medium Low
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 2)), Custom + "mastercomfig-medium-low-preset.vpk");
                            }
                            if (msconf_preset_combo.SelectedIndex == 3) // Medium
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 3)), Custom + "mastercomfig-medium-preset.vpk");
                            }
                            if (msconf_preset_combo.SelectedIndex == 4) // Medium High
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 4)), Custom + "mastercomfig-medium-high-preset.vpk");
                            }
                            if (msconf_preset_combo.SelectedIndex == 5) // High
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 5)), Custom + "mastercomfig-high-preset.vpk");
                            }
                            if (msconf_preset_combo.SelectedIndex == 6) // Ultra
                            {
                                WClient.DownloadFileAsync(new Uri(GetLatestMCRelease("mastercomfig", "mastercomfig", 6)), Custom + "mastercomfig-ultra-preset.vpk");
                            }
                            WClient.DownloadFileCompleted += Client_DownloadFileCompleted;
                            WClient.DownloadProgressChanged += Client_DownloadProgressChanged;
                        }
                    }
                }
                else
                {
                    _ = MessageBox.Show("You didn't choose any preset.", "Error");
                }
            }
            catch (Exception) { }
        }

        private void DropInstall_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void DropInstall_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Custom_Install_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDI_Click(object sender, EventArgs e)
        {

        }

        private void Steam_Location_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    Steam_Location.Text = path;
                }
            }
        }

        private void TF2_Location_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    TF2_Location.Text = path;
                }
            }
        }

        private void ResetTF2_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset TF2?", "Reset Team Fortress 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (isTF2Running == false)
                    { // https://docs.mastercomfig.com/latest/setup/clean_up/
                        Directory.Delete(TF2_Location.Text + "\\tf\\custom", true);
                        Directory.Delete(TF2_Location.Text + "\\tf\\cfg", true);
                        _ = Process.Start(TF2_Location.Text + "\\hl2.exe", "-game tf -steam -novid -autoconfig -default +host_writeconfig config.cfg full +mat_savechanges +quit");
                    }
                    else
                    {
                        _ = MessageBox.Show("Close Team Fortress 2 before you reset Team Fortress 2.");
                    }
                }
                catch (Exception) { }
            }
        }

        private void Discord_Link_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://discord.gg/UvQqsuQzXG");
        }

        private void Youtube_Link_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://www.youtube.com/@Gorkid0");
        }

        private void Github_Link_Click(object sender, EventArgs e)
        {
            _ = Process.Start("https://github.com/Gorkido");
        }

        private void languageChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageChanger.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            UI();
        }

        private void BackupHUDs()
        {
            foreach (string item in Directory.EnumerateDirectories(Custom))
            {
                if (item.Contains("hud"))
                {
                    Directory.Move(item, Custom + "HUD Backup\\");
                }
            }
        }

        private void renhud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "RenHud-V2";
            string User = "LunaXCBN";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile(GetLatestGitRelease(User, HUDName, 0), Custom + HUDName + ".7z");
                    _ = Directory.CreateDirectory(Custom + "RenHUD-V2");
                    using (SevenZipArchive archive = new SevenZipArchive(Custom + HUDName + ".7z"))
                    {
                        archive.ExtractToDirectory(Custom + "RenHUD-V2\\");
                    }
                    File.Delete(Custom + HUDName + ".7z");
                }
                catch (Exception) { }
            }
        }

        private void sunsethud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "SunsetHUD";
            string User = "Hypnootize";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile(client.Repository.Release.GetLatest(User, HUDName).Result.HtmlUrl.Replace("tag", "tags").Replace("releases", "archive/refs") + ".zip", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void warsavhud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "WarsawHUD";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile("https://github.com/p3tr1ch0r/warsawhud/archive/refs/heads/master.zip", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void hyphud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "hypnotizehud";
            string User = "Hypnootize";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile(client.Repository.Release.GetLatest(User, HUDName).Result.HtmlUrl.Replace("tag", "tags").Replace("releases", "archive/refs") + ".zip", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void flawhud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "flawhud";
            string User = "CriticalFlaw";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile(GetLatestGitRelease(User, HUDName, 1), Custom + HUDName + ".zip");
                    _ = Directory.CreateDirectory(Custom + HUDName);
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void hexhud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "hexhud";
            string User = "Hypnootize";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile(client.Repository.Release.GetLatest(User, HUDName).Result.HtmlUrl.Replace("tag", "tags").Replace("releases", "archive/refs") + ".zip", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void toonhud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "toonhud";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile("https://gamebanana.com/dl/683760", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void quakehud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "WarsawHUD";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile("https://github.com/quickkennedy/quakehud/archive/refs/heads/master.zip", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void m0rehud_pic_Click(object sender, EventArgs e)
        {
            string HUDName = "m0rehud";
            string User = "Hypnootize";
            if (MessageBox.Show($"Are you sure you want to install {HUDName}?", "Install " + HUDName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BackupHUDs();
                    WClient.DownloadFile(client.Repository.Release.GetLatest(User, HUDName).Result.HtmlUrl.Replace("tag", "tags").Replace("releases", "archive/refs") + ".zip", Custom + HUDName + ".zip");
                    ZipFile.ExtractToDirectory(Custom + HUDName + ".zip", Custom);
                    File.Delete(Custom + HUDName + ".zip");
                }
                catch (Exception) { }
            }
        }

        private void OptimizerNotifIcon_MouseClick(object sender, MouseEventArgs e)
        {
            OptimizerContMenuStrip.Show(Control.MousePosition);
        }

        private void OptimizerContMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Text;

            switch (itemText)
            {
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }

        private void installmod(int gamebananastr, string modname, bool sevenzip = false)
        {
            string downloadstring = "https://gamebanana.com/dl/";
            string mods = downloadstring + GamebananaStrs[gamebananastr];
            string modsfileloc = Custom + modname;
            try
            {
                if (sevenzip == true)
                {
                    WClient.DownloadFile(mods, modsfileloc + ".7z");
                    using (SevenZipArchive archive = new SevenZipArchive(Custom + modname + ".7z"))
                    {
                        archive.ExtractToDirectory(Custom);
                    }
                    File.Delete(Custom + modname + ".7z");
                }
                else
                {
                    WClient.DownloadFile(mods, modsfileloc + ".zip");
                    ZipFile.ExtractToDirectory(Custom + modname + ".zip", Custom);
                    File.Delete(Custom + modname + ".zip");
                }
            }
            catch (Exception) { }
        }

        private void install_sel_mods_Click(object sender, EventArgs e)
        {
            #region Performance
            if (flattextures_checkb.Checked)
            {
                installmod(0, "FlatTextures");
                Directory.Delete(Custom + "FlatTexturesV1", true);
            }
            if (removesnioperscope_checkb.Checked)
            {
                installmod(1, "NoSniperScope");
            }
            if (nohats_checkb.Checked)
            {
                installmod(2, "NoHats");
                foreach (string file in Directory.EnumerateFiles(Custom + "no_hats_bgum_master"))
                {
                    string destFile = Path.Combine(Custom, Path.GetFileName(file));
                    if (!File.Exists(destFile))
                    {
                        File.Move(file, destFile);
                    }
                }
                File.Delete(Custom + "README.md");
                Directory.Delete(Custom + "no_hats_bgum_master", true);
            }
            #endregion Performance

            #region Quality
            if (ultimatevisualfix_checkb.Checked)
            {
                // WClient.DownloadFile(GetLatestGitRelease("agrastiOs", "Ultimate-TF2-Visual-Fix-Pack", 7), Custom + ModsList[7]); Only pre-release is available so we don't use this.
                WClient.DownloadFile("https://github.com/agrastiOs/Ultimate-TF2-Visual-Fix-Pack/releases/download/v1.0-rc3/TF2UltimateVisualFix_000.vpk", Custom + GamebananaStrs[3]);
            }
            if (transparentarms_checkb.Checked)
            {
                installmod(4, "TransparentArms", sevenzip: true);
            }
            if (uniquerockets_checkb.Checked)
            {
                installmod(5, "UniqueRockets", sevenzip: true);
            }
            if (realisticskybox_checkb.Checked)
            {
                _ = Directory.CreateDirectory(Custom + "RealisticSkybox\\materials\\skybox");
                installmod(6, "RealisticSkybox");
                Thread.Sleep(1000);
                foreach (string file in Directory.EnumerateFiles(Custom + "Team fortress 2\\tf\\custom\\my_custom_stuff\\materials\\skybox"))
                {
                    string destFile = Path.Combine(Custom + "RealisticSkybox\\materials\\skybox", Path.GetFileName(file));
                    if (!File.Exists(destFile))
                    {
                        File.Move(file, destFile);
                    }
                }
                File.Delete(Custom + "RealisticSkybox.zip");
                Directory.Delete(Custom + "Team fortress 2", true);
            }
            if (mastercomfigextra_checkb.Checked)
            {
                foreach (string item in AddonList)
                {
                    WClient.DownloadFile((client.Repository.Release.GetLatest("mastercomfig", "mastercomfig").Result.HtmlUrl + item).Replace("tag", "download"), Custom + item);
                }
            }
            #endregion Quality
        }
    }
}