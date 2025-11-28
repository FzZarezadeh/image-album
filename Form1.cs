using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_album
{
    public partial class Form1 : Form
    {
        string imgmain;
        float inzoomunit = 1.2f, outzoomunit = 0.8f;
        int picnumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void centerimage(Control img)
        {
            img.Left = (this.ClientSize.Width - img.Width) / 2;
            img.Top = (this.ClientSize.Height - img.Height) / 2;
        }

        private void zoom(float unit)
        {
            int newwidth = (int)(pictureBox1.Width * unit);
            int newheight = (int)(pictureBox1.Height * unit);
            pictureBox1.Width = newwidth;
            pictureBox1.Height = newheight;
            centerimage(pictureBox1);
        }


        private void buttonpos()
        {
            btnprev.Left = pictureBox1.Left - btnprev.Width - 10;
            btnprev.Top = pictureBox1.Top + (pictureBox1.Height - btnprev.Height) / 2;

            btnnext.Left = pictureBox1.Right + 10;
            btnnext.Top = pictureBox1.Top + (pictureBox1.Height - btnnext.Height) / 2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            imgmain = picnumber.ToString()+".jpg";
            pictureBox1.ImageLocation = imgmain;
            centerimage(pictureBox1);
            buttonpos();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (picnumber<8)
            {
                picnumber++;
                imgmain = picnumber.ToString() + ".jpg";
                pictureBox1.ImageLocation = imgmain;
                lblpicname.Text = "Picture " + picnumber.ToString();
            }
            else
            {
                picnumber=1;
                imgmain = picnumber.ToString() + ".jpg";
                pictureBox1.ImageLocation = imgmain;
                lblpicname.Text = "Picture " + picnumber.ToString();
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (picnumber > 1)
            {
                picnumber--;
                imgmain = picnumber.ToString() + ".jpg";
                pictureBox1.ImageLocation = imgmain;
                lblpicname.Text= "Picture "+ picnumber.ToString();
            }
            else
            {
                picnumber = 8;
                imgmain = picnumber.ToString() + ".jpg";
                pictureBox1.ImageLocation = imgmain;
                lblpicname.Text = "Picture " + picnumber.ToString();
            }
        }

        private void btnzoomout_Click(object sender, EventArgs e)
        {
            zoom(outzoomunit);
            buttonpos();
        }

        private void btnzoomin_Click(object sender, EventArgs e)
        {
            zoom(inzoomunit);
            buttonpos();
        }
    }
}
