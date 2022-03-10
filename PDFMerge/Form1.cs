using System.Security;

namespace PDFMerge
{
    public partial class PDFMerge : Form
    {
        public PDFMerge()
        {
            InitializeComponent();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceTextBox.Text = folderBrowserDialog1.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            try
            {
                PythonContainer.MergePDFs(sourceTextBox.Text, targetTextBox.Text);
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            targetBrowseButton.Enabled = enableTargetPath.Checked;
            targetTextBox.Enabled = enableTargetPath.Checked;
        }

        private void targetBrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    targetTextBox.Text = folderBrowserDialog1.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}