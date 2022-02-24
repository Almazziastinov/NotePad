
namespace NotePad
{
    partial class FontSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextExample = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Образец";
            // 
            // TextExample
            // 
            this.TextExample.AutoSize = true;
            this.TextExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextExample.Location = new System.Drawing.Point(179, 220);
            this.TextExample.Name = "TextExample";
            this.TextExample.Size = new System.Drawing.Size(157, 36);
            this.TextExample.TabIndex = 1;
            this.TextExample.Text = "AaBbYyZz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            ""});
            this.fontBox.Location = new System.Drawing.Point(12, 12);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(121, 24);
            this.fontBox.TabIndex = 4;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "полужирный курсив"});
            this.styleBox.Location = new System.Drawing.Point(185, 12);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(121, 24);
            this.styleBox.TabIndex = 5;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // FontSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 458);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextExample);
            this.Controls.Add(this.label1);
            this.Name = "FontSetting";
            this.Text = "FontSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextExample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox styleBox;
    }
}