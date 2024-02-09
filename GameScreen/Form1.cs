using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace GameScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Laugh);
            player.Play();
            button1.Visible = false;
            outputLabel.Text = "3";
            player.Play();
            Refresh();
            Thread.Sleep(1000);

            outputLabel.Text = "2";
            player.Play();
            Refresh();
            Thread.Sleep(1000);

            outputLabel.Text = "1";
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            player.Play();
            outputLabel.Text = "BOOM";
            this.BackColor = Color.Green;


        }
    }
}
