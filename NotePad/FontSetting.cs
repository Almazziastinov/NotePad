using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FontSetting : Form
    {
        public FontSetting()
        {
            InitializeComponent();
            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = fontBox.Items[0];
        }

        private void OnFontChanged(object sender, EventArgs e)
        {
            TextExample.Font = new Font(TextExample.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()));
        }

        private void OnStyleChanged(object sender, EventArgs e)
        {
            TextExample.Font = new Font(TextExample.Font.FontFamily,int.Parse() FontStyle.Bold)
        }
    }
}
