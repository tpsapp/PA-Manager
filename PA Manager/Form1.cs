using System;
using System.IO;
using System.Windows.Forms;

namespace PA_Manager
{
    public partial class frmMain : Form
    {
        private String sPAPath;
        private String sPAPrefs;
        private String sPASaves;
        private String[] sLines;

        private void LoadPrefs()
        {
            if (File.Exists(sPAPrefs))
            {
                sLines = File.ReadAllLines(sPAPrefs);
                tbSWidth.Text = sLines[1].Remove(0, 21).Trim();
                tbSHeight.Text = sLines[2].Remove(0, 21).Trim();
                if (sLines[3].Remove(0, 21) == "true  ")
                {
                    cbFullScreen.Checked = true;
                }
                if (sLines[4].Remove(0, 21) == "true  ")
                {
                    cbMSampled.Checked = true;
                }
                if (sLines[5].Remove(0, 21) == "true  ")
                {
                    cbSSampled.Checked = true;
                }
                tbSMFreq.Text = sLines[6].Remove(0, 21).Trim();
                tbSVol.Text = sLines[7].Remove(0, 21).Trim();
                if (sLines[8].Remove(0, 21) == "true  ")
                {
                    cbSwapStereo.Checked = true;
                }
                if (sLines[9].Remove(0, 21) == "true  ")
                {
                    cbEnableDSP.Checked = true;
                }
                if (sLines[10].Remove(0, 21) == "true  ")
                {
                    cbRRooms.Checked = true;
                }
                tbRMap.Text = sLines[11].Remove(0, 21).Trim();
                if (sLines[12].Remove(0, 21) == "true  ")
                {
                    cbFirstTime.Checked = true;
                }
                tbASTimer.Text = sLines[13].Remove(0, 21).Trim();
                tbHCompat.Text = sLines[14].Remove(0, 21).Trim();
                tbLKVer.Text = sLines[15].Remove(0, 21).Trim();
                tbTLCam.Text = sLines[16].Remove(0, 21).Trim();
                tbTLInt.Text = sLines[17].Remove(0, 21).Trim();
                tbTLFPSNum.Text = sLines[18].Remove(0, 22).Trim();
                tbTLFPSDen.Text = sLines[19].Remove(0, 23).Trim();
                tbTLQual.Text = sLines[20].Remove(0, 21).Trim();
            }
        }

        private void SavePrefs()
        {
            sLines[1] = "ScreenW              " + tbSWidth.Text;
            sLines[2] = "ScreenH              " + tbSHeight.Text;
            sLines[3] = "ScreenWindowed       " + cbFullScreen.Checked.ToString().ToLower();
            sLines[4] = "ScreenMultiSampled   " + cbMSampled.Checked.ToString().ToLower();
            sLines[5] = "ScreenSuperSampled   " + cbSSampled.Checked.ToString().ToLower();
            sLines[6] = "SoundMixFrequency    " + tbSMFreq.Text;
            sLines[7] = "SoundVolume          " + tbSVol.Text;
            sLines[8] = "SoundSwapStereo      " + cbSwapStereo.Checked.ToString().ToLower();
            sLines[9] = "SoundEnableDsp       " + cbEnableDSP.Checked.ToString().ToLower();
            sLines[10] = "RenderRooms          " + cbRRooms.Checked.ToString().ToLower();
            sLines[11] = "RecentMap            " + tbRMap.Text;
            sLines[12] = "FirstTime            " + cbFirstTime.Checked.ToString().ToLower();
            sLines[13] = "AutoSaveTimer        " + tbASTimer.Text;
            sLines[14] = "HardwareCompat       " + tbHCompat.Text;
            sLines[15] = "LastKnownVersion     " + tbLKVer.Text;
            sLines[16] = "TimeLapseCamera      " + tbTLCam.Text;
            sLines[17] = "TimeLapseInterval    " + tbTLInt.Text;
            sLines[18] = "TimeLapseFPSNumerator " + tbTLFPSNum.Text;
            sLines[19] = "TimeLapseFPSDenominator " + tbTLFPSDen.Text;
            sLines[20] = "TimeLapseQuality     " + tbTLQual.Text;
            File.WriteAllLines(sPAPrefs, sLines);
        }

        private void ListSaves()
        {
            lbSavedGames.Items.Clear();
            String[] sLines = Directory.GetFiles(sPASaves);
            foreach (String sLine in sLines)
            {
                if (Path.GetExtension(sLine) == ".prison")
                {
                    lbSavedGames.Items.Add(Path.GetFileNameWithoutExtension(sLine));
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\Users\\" + System.Environment.UserName + "\\AppData\\Local\\Introversion\\Prison Architect"))
            {
                sPAPath = "C:\\Users\\" + System.Environment.UserName + "\\AppData\\Local\\Introversion\\Prison Architect";
            }
            else if (Directory.Exists("C:\\Documents and Settings\\" + System.Environment.UserName + "\\Local Settings\\Application Data\\Introversion\\Prison Architect"))
            {
                sPAPath = "C:\\Documents and Settings\\" + System.Environment.UserName + "\\Local Settings\\Application Data\\Introversion\\Prison Architect";
            }
            else
            {
                OpenFileDialog ofdPAPath = new OpenFileDialog();
                ofdPAPath.Title = "Prison Architect Preferences Path";
                ofdPAPath.InitialDirectory = "%USERPROFILE%";
                ofdPAPath.Filter = "PA Preferences|preferences.txt";
                DialogResult drFile = ofdPAPath.ShowDialog();
                if (drFile == System.Windows.Forms.DialogResult.OK)
                {
                    sPAPath = Path.GetDirectoryName(ofdPAPath.FileName);
                }
            }
            sPAPrefs = sPAPath + "\\preferences.txt";
            sPASaves = sPAPath + "\\saves\\";
            LoadPrefs();
            ListSaves();
        }

        private void lbSavedGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSavedGames.SelectedIndex >= 0)
            {
                pbPreview.Load(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".png");
            }
            else
            {
                pbPreview.Image = null;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lbSavedGames.SelectedIndex >= 0)
            {
                if (File.Exists(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".prison"))
                {
                    File.Copy(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".prison", sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + " - copy.prison");
                    File.Copy(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".png", sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + " - copy.png");
                }
            }
            int iTemp = lbSavedGames.SelectedIndex;
            ListSaves();
            if (iTemp >= 0)
            {
                lbSavedGames.SelectedIndex = iTemp;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbSavedGames.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the saved game named " + lbSavedGames.Items[lbSavedGames.SelectedIndex], "Delete save...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".prison");
                    File.Delete(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".png");
                }
            }
            int iTemp = lbSavedGames.SelectedIndex;
            ListSaves();
            if (iTemp >= 0)
            {
                lbSavedGames.SelectedIndex = iTemp;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lbSavedGames.SelectedIndex >= 0)
            {
                Form fRen = new frmRename(sPASaves + lbSavedGames.Items[lbSavedGames.SelectedIndex] + ".prison");
                fRen.ShowDialog();
            }
            int iTemp = lbSavedGames.SelectedIndex;
            ListSaves();
            if (iTemp >= 0)
            {
                lbSavedGames.SelectedIndex = iTemp;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reloadPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPrefs();
        }

        private void changeGameDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPAPath = new OpenFileDialog();
            ofdPAPath.Title = "Prison Architect Preferences Path";
            ofdPAPath.InitialDirectory = sPAPath;
            ofdPAPath.Filter = "PA Preferences|preferences.txt";
            DialogResult drFile = ofdPAPath.ShowDialog();
            if (drFile == System.Windows.Forms.DialogResult.OK)
            {
                sPAPath = Path.GetDirectoryName(ofdPAPath.FileName);
            }
            LoadPrefs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbSavedGames.SelectedIndex >= 0)
            {
                Form fTemp = new frmEdit(lbSavedGames.Items[lbSavedGames.SelectedIndex].ToString(), sPASaves + "\\" + lbSavedGames.Items[lbSavedGames.SelectedIndex].ToString() + ".prison");
                fTemp.ShowDialog();
            }
            ListSaves();
        }

        private void savePreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePrefs();
        }
    }
}
