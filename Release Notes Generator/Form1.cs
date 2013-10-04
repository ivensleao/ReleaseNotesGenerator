using Release_Notes_Generator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Release_Notes_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string filepath = string.Empty;
        private const string FILE_FILTER = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        private const string FILE_EXTENSION = "txt";
        private const string INITIAL_DIRECTORY = @"C:\";

        private bool CreateFile(string path, string fileText)
        {
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(path, true);
                file.Write(fileText);
                file.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private string GenerateText()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("========================Release Notes========================");
            sb.AppendLine("\n\n");
            sb.AppendLine("\nProduct:" + txt_product.Text);
            sb.AppendLine("\nVersion:" + txt_version.Text);
            sb.AppendLine("\n\nAbout:" + txt_about.Text);
            sb.AppendLine("\n\n==========================Additions==========================");
            sb.AppendLine("\n\n" + txt_additions.Text);
            sb.AppendLine("\n==========================Bugs===============================");
            sb.AppendLine("\n\n" + txt_bugs.Text);

            return sb.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CreateFile(this.filepath, GenerateText()))
            {
                MessageBox.Show(Resources.MessageSuccess);
                ClearAll();
            }
            else
                MessageBox.Show(Resources.MessageError);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = INITIAL_DIRECTORY;
            saveFileDialog.Title = Resources.MessageFilesExtension;
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = FILE_EXTENSION;
            saveFileDialog.Filter = FILE_FILTER;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = txt_path.Text = saveFileDialog.FileName;
            }
        }

        private void ClearAll()
        {
            this.txt_about.Text = string.Empty;
            this.txt_additions.Text = string.Empty;
            this.txt_bugs.Text = string.Empty;
            this.txt_path.Text = string.Empty;
            this.txt_product.Text = string.Empty;
            this.txt_version.Text = string.Empty;
        }

    }
}
