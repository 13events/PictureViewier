using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //show dialog box to user. If user clicks OK
            //load selected picture into pictureBox.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear the picture
            pictureBox1.Image = null;
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            //show the color dialog. If user selects O,
            //change the pictureBox background to color selected.

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if user selects the "Stretch" box
            //change the pictureBox size mode property to "Stretch".
            //If user clears the check, change size mode to "Normal"
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            } else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
