using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class NotePad : Form
    {
        public string filename;
        public bool isfilechaged;

        public NotePad()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
            filename = "";
            isfilechaged = false;
            UpdateTextWithFile();
        }

        public void CreateNewDoc(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            textBox1.Text = "";
            filename = "";
            UpdateTextWithFile(); 
        }

        public void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog1.FileName = "";
            
            if(openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                try
                {
                    StreamReader reader = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = reader.ReadToEnd();
                    reader.Close();
                    filename = openFileDialog1.FileName;
                    isfilechaged = false;
                }
                catch 
                {

                    MessageBox.Show("Невозможно открыть файл.");
                }
            }
            UpdateTextWithFile();
        }

        public void SaveFile(string _filename)
        {
            if (_filename.Equals("")) 
            {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter writer = new StreamWriter(_filename + ".txt");
                writer.Write(textBox1.Text);
                writer.Close();
                filename = _filename;
                isfilechaged = false;
            }
            catch 
            {
                MessageBox.Show("Невозможно сохранить файл");
            }
            UpdateTextWithFile();
        }
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }
        public void TexChanged(object sender, EventArgs e)
        {

            if (!isfilechaged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isfilechaged = true;
                this.Text = "*" + this.Text;
            }

        }
        public void UpdateTextWithFile()
        {
            if (filename != "")
                this.Text = filename + " - NotePad";
            else
                this.Text = "No Name - NotePad";
        }
        public void SaveUnsavedFile()
        {
            if(!isfilechaged)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res.Equals(DialogResult.Yes))
                {
                    SaveFile(filename);
                }
                
            }
        }
        public void CopyText()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        public void PasteText()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length - textBox1.SelectionStart);
        }

        private void OnCopyClic(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }
        public void OnClosing(object sender, EventArgs e)
        {
            SaveUnsavedFile();
        }

        private void OnFontClic(object sender, EventArgs e)
        {
            FontSetting fontSetting = new FontSetting();
            fontSetting.Show();
        }
    }
}
