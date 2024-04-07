using System;
using System.Windows.Forms;

namespace Проект_на_тему_космос___it
{
    public partial class Form1 : Form
    {
        private AllDataAboutPlanets alldataplanets = new AllDataAboutPlanets();

        public Form1()
        {
            InitializeComponent();

            HeadAction(pictureBox10, alldataplanets.nameallplanets,
                alldataplanets.urlallplanets, false);
        }

        private void GenerationVideo(string url)
        {
            var embed = "<html><head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head></body>" +
                "<iframe width\"300\" src=\"{0}\"" +
                "frameborder = \"0\" allow = \"autoplay; encryted-media\" allowfullscreen></iframe>" +
                "</body></html>";

            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void HeadAction(PictureBox pictureBox, string nameplanet,
            string urlplanet, bool check)
        {
            if (check)
            {
                pictureBox10.ClientSize = new System.Drawing.Size(360, 200);
            }
            else
            {
                pictureBox10.ClientSize = new System.Drawing.Size(280, 280);
            }
            pictureBox10.Image = pictureBox.Image;
            pictureBox10.Show();

            richTextBox1.Text = nameplanet;
            richTextBox1.Show();

            GenerationVideo(urlplanet);
        }
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox8, alldataplanets.namemercury,
                alldataplanets.urlmercury, false);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox9, alldataplanets.nameuranus,
                alldataplanets.urluranus, true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox2, alldataplanets.namesun,
                alldataplanets.urlsun, false);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox7, alldataplanets.namevenus,
                alldataplanets.urlvenus, false);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox6, alldataplanets.nameearth,
                alldataplanets.urlearth, false);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox5, alldataplanets.namemars,
            alldataplanets.urlmars, false);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox4, alldataplanets.namejupiter,
                alldataplanets.urljupiter, false);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox3, alldataplanets.namesaturn,
                alldataplanets.urlsaturn, true);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            HeadAction(pictureBox11, alldataplanets.nameneptune,
                alldataplanets.urlneptune, false);
        }
    }
}
