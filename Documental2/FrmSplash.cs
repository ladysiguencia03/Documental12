using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documental2
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            //this.Opacity = 0.5;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .03;
            cpbProgreso.Value += 1;
            cpbProgreso.Text = cpbProgreso.Value.ToString() + "%";


            if (cpbProgreso.Value == cpbProgreso.Maximum)
            {
                timer1.Enabled = false;
                //FrmMenu frmMenu = new FrmMenu();
                FrmLogin frmLogin = new FrmLogin("principal"); 
                //frmMenu.Show();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://zerodayschool.net");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el link");
            }
        }
    }
}
