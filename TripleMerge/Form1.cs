using System;
using System.Windows.Forms;
using System.IO;

namespace TripleMerge
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        void btnMerge_Click(object sender, EventArgs e)
        {
            var result = TripleMerger.Merge(original, one, two);

            txbResult.Text = string.Join("\r\n", result);
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var result = TripleMerger.Merge(original, one, two);

            using (var saveFileDialog1 = new SaveFileDialog())
            {
                try
                {
                    saveFileDialog1.Title = "Triple Merge - SAVE File";
                    saveFileDialog1.FilterIndex = 1;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
                       saveFileDialog1.FileName != string.Empty)
                    {
                        File.WriteAllLines(saveFileDialog1.FileName, result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Save File");
                }
            }
        }

        string[] original;
        string[] one;
        string[] two;

        void btnOpenSource_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                try
                {
                    openFileDialog1.Title = "Triple Merge - Open Source File";

                    openFileDialog1.FileName = string.Empty;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                        openFileDialog1.FileName != string.Empty)
                    {
                        original = File.ReadAllLines(openFileDialog1.FileName);
                        txbTextSource.Text = string.Join("\r\n", original);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Open File");
                }
            }
        }

        void btnOpen1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                try
                {
                    openFileDialog1.Title = "Triple Merge - Open Source File";

                    openFileDialog1.FileName = string.Empty;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                        openFileDialog1.FileName != string.Empty)
                    {
                        one = File.ReadAllLines(openFileDialog1.FileName);
                        txbText1.Text = string.Join("\r\n", one);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Open File");
                }
            }
        }

        void btnOpen2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                try
                {
                    openFileDialog1.Title = "Triple Merge - Open Source File";

                    openFileDialog1.FileName = string.Empty;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                        openFileDialog1.FileName != string.Empty)
                    {
                        two = File.ReadAllLines(openFileDialog1.FileName);
                        txbText2.Text = string.Join("\r\n", two);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Open File");
                }
            }
        }
    }
}
