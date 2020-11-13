using System;
using System.IO;
using System.Windows.Forms;

namespace PA_Manager
{
    public partial class frmRename : Form
    {
        private String sSave;
        public frmRename(String sName)
        {
            InitializeComponent();
            sSave = sName;
        }

        private void frmRename_Load(object sender, EventArgs e)
        {
            tbSave.Text = Path.GetFileName(sSave);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbSave.Text != "")
            {
                File.Move(sSave, Path.GetDirectoryName(sSave) + "\\" + tbSave.Text);
                File.Move(Path.GetDirectoryName(sSave) + "\\" + Path.GetFileNameWithoutExtension(sSave) + ".png", Path.GetDirectoryName(sSave) + "\\" + Path.GetFileNameWithoutExtension(tbSave.Text) + ".png");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
