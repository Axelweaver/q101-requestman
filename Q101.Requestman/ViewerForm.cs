using System;
using System.Windows.Forms;
using Q101.Requestman.Helpers;

namespace Q101.Requestman
{
    public partial class ViewerForm : Form
    {
        private string _requestBody;

        public ViewerForm(string requestBody)
        {
            _requestBody = requestBody;

            InitializeComponent();
        }

        private void ViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {
            TextViewer.Text = _requestBody;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextViewer.Text = JsonHelper.FormatJson(_requestBody);
        }

        private void TextViewer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
