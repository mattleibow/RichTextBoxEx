using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxExSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEx.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEx.Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEx.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontFamilyCombo.Items.Clear();
            fontFamilyCombo.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
        }

        private void fontFamilyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var oldFont = richTextBoxEx.SelectionFont;
            richTextBoxEx.SelectionFont = new Font(fontFamilyCombo.Text, oldFont.Size, oldFont.Style, oldFont.Unit, oldFont.GdiCharSet, oldFont.GdiVerticalFont);
        }

        private void fontSizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var oldFont = richTextBoxEx.SelectionFont;
            richTextBoxEx.SelectionFont = new Font(oldFont.FontFamily, float.Parse(fontSizeCombo.Text), oldFont.Style, oldFont.Unit, oldFont.GdiCharSet, oldFont.GdiVerticalFont);
        }

        private void boldMenuItem_Click(object sender, EventArgs e)
        {
            var oldFont = richTextBoxEx.SelectionFont;
            richTextBoxEx.SelectionFont = new Font(oldFont.FontFamily, oldFont.Size, FontStyle.Bold, oldFont.Unit, oldFont.GdiCharSet, oldFont.GdiVerticalFont);
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var cf = richTextBoxEx.SelectionCharFormat;
        }

        private void richTextBoxEx_SelectionChanged(object sender, EventArgs e)
        {
            fontFamilyCombo.Text = richTextBoxEx.SelectionCharFormat.FaceName;
            fontSizeCombo.Text = richTextBoxEx.SelectionCharFormat.yHeight_Points.ToString();
        }
    }
}
