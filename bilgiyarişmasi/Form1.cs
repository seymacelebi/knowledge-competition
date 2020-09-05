using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarişmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label8.Text = BtnB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                ddsfd.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                sfs.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label8.Text = BtnC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                ddsfd.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                sfs.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label8.Text = BtnD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                ddsfd.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                sfs.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label8.Text = BtnA.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                ddsfd.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                sfs.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            LblSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label7.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehrimiz Ege bölgesinde bulunmaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Manisa";
                BtnD.Text = "Aydın";
                label7.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Martin Eden hangi yazara aittir?";
                BtnA.Text = "Jack London";
                BtnB.Text = "İskerder Pala";
                BtnC.Text = "Ahmet Ümit";
                BtnD.Text = "Elif Şafak";
                label7.Text = "Jack London";
            }
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show(" Doğru: " + dogru + "  Yanlış: " + yanlis);
            }

        }
    }
}
