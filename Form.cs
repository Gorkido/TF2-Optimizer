using Microsoft.Win32;
using Octokit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
        private readonly Font tf2_font_regular;
        private readonly Font tf2_font_small;
        private readonly Font tf2_font_bold;

        public Form()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.tf2build;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.tf2build.Length);
            _ = AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.tf2build.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            tf2_font_regular = new Font(fonts.Families[0], 14.25F, FontStyle.Regular);
            tf2_font_small = new Font(fonts.Families[0], 12.25F, FontStyle.Regular);
            tf2_font_bold = new Font(fonts.Families[0], 20.25F, FontStyle.Bold);

            msconfig_pre_label.Font = tf2_font_bold;
            MenuLabel.Font = tf2_font_bold;
            Title.Font = tf2_font_bold;
            SubTitle.Font = tf2_font_small;
            About_Button.Font = tf2_font_regular;
            mastercomfig_Button.Font = tf2_font_regular;
            msconf_preset_combo.Font = tf2_font_regular;
            Configure_mastercomf.Font = tf2_font_regular;
            PopHUDs_Button.Font = tf2_font_regular;
            Useful_Mods_Button.Font = tf2_font_regular;
            CustomMod_Button.Font = tf2_font_regular;
            ci_label1.Font = tf2_font_bold;
            ci_label2.Font = tf2_font_regular;
            OpenFileDI.Font = tf2_font_regular;
            DropInstall.Font = tf2_font_regular;
            Custom_Install.Font = tf2_font_regular;
            Auto_Opti_Button.Font = tf2_font_regular;
            Settings_Button.Font = tf2_font_regular;
            set_label1.Font = tf2_font_bold;
            set_label2.Font = tf2_font_regular;
            set_label3.Font = tf2_font_regular;
            set_label4.Font = tf2_font_bold;
            set_label5.Font = tf2_font_regular;
            set_label6.Font = tf2_font_regular;
            Steam_Location.Font = tf2_font_regular;
            TF2_Location.Font = tf2_font_regular;
            ResetTF2_Button.Font = tf2_font_regular;
        }

        #region Strings
        //private static readonly string hitkillsounds = GetTF2Directory() + "\\tf\\custom\\hitsound\\sound\\ui\\";
        //private static readonly string cfg = GetTF2Directory() + "\\tf\\cfg\\";
        private readonly string downloadstring = "https://gamebanana.com/dl/";
        private readonly bool isTF2Running = Process.GetProcessesByName("hl2.exe").Any();
        private readonly GitHubClient client = new GitHubClient(new ProductHeaderValue("LatestRelease"));
        private readonly WebClient WClient = new WebClient();

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

        private string GetLatestMCRelease(string RepoOwner, string RepoName, byte MCFG)
        {
            return (client.Repository.Release.GetLatest(RepoOwner, RepoName).Result.HtmlUrl + MasterComfig[MCFG]).Replace("tag", "download");
        }

        private readonly string[] AllHUDs =
        {

        };
        #endregion

        private void Form_Load(object sender, EventArgs e)
        {
            GetSteamDirectory();
            GetTF2Directory();
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
            Custom_Install_Panel.Hide();
            Settings_Panel.Hide();
            About_Panel.Show();
        }

        private void mastercomfig_Button_Click(object sender, EventArgs e)
        {
            About_Panel.Hide();
            Custom_Install_Panel.Hide();
            Settings_Panel.Hide();
            Mastercomfig_Panel.Show();
        }

        private void PopHUDs_Button_Click(object sender, EventArgs e)
        {

        }

        private void Useful_Mods_Button_Click(object sender, EventArgs e)
        {

        }

        private void CustomMod_Button_Click(object sender, EventArgs e)
        {
            Mastercomfig_Panel.Hide();
            About_Panel.Hide();
            Settings_Panel.Hide();
            Custom_Install_Panel.Show();
        }

        private void Auto_Opti_Button_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Mastercomfig_Panel.Hide();
            About_Panel.Hide();
            Custom_Install_Panel.Hide();
            Settings_Panel.Show();
        }

        private void Configure_mastercomf_Click(object sender, EventArgs e)
        {
            string custom = TF2_Location.Text + "\\tf\\custom\\";
            if (msconf_preset_combo.SelectedItem != null)
            {
                if (MessageBox.Show($"Are you sure you want to install mastercomfig preset: {msconf_preset_combo.SelectedItem}?", "Install mastercomfig", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Directory.Exists(custom))
                    {
                        if (msconf_preset_combo.SelectedIndex == 0) // Very Low
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 0), custom + "mastercomfig-very-low-preset.vpk");
                            _ = GetPhysicallyInstalledSystemMemory(out long memKb);
                            long totalram = memKb / 1024 / 1024;
                            if (totalram < 4)
                            {
                                WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 7), custom + "mastercomfig-lowmem-addon.vpk");
                            }
                        }
                        if (msconf_preset_combo.SelectedIndex == 1) // Low
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 1), custom + "mastercomfig-low-preset.vpk");
                        }
                        if (msconf_preset_combo.SelectedIndex == 2) // Medium Low
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 2), custom + "mastercomfig-medium-low-preset.vpk");
                        }
                        if (msconf_preset_combo.SelectedIndex == 3) // Medium
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 3), custom + "mastercomfig-medium-preset.vpk");
                        }
                        if (msconf_preset_combo.SelectedIndex == 4) // Medium High
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 4), custom + "mastercomfig-medium-high-preset.vpk");
                        }
                        if (msconf_preset_combo.SelectedIndex == 5) // High
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 5), custom + "mastercomfig-high-preset.vpk");
                        }
                        if (msconf_preset_combo.SelectedIndex == 6) // Ultra
                        {
                            WClient.DownloadFile(GetLatestMCRelease("mastercomfig", "mastercomfig", 6), custom + "mastercomfig-ultra-preset.vpk");
                        }
                    }
                }
            }
            else
            {
                _ = MessageBox.Show("You didn't choose any preset.", "Error");
            }
        }

        private void DropInstall_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                _ = DropInstall.Items.Add(file);
            }
        }

        private void DropInstall_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop, false) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void Custom_Install_Click(object sender, EventArgs e)
        {
            foreach (object item in DropInstall.Items)
            {
                _ = MessageBox.Show(item.ToString());
                //File.Copy(item.ToString(), custom);
            }
        }

        private void OpenFileDI_Click(object sender, EventArgs e)
        {
            _ = openFileDialog1.ShowDialog();
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
    }
}