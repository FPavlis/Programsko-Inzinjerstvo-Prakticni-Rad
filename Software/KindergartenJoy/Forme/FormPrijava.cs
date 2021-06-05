using KindergartenJoy.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenJoy
{
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblKreiraj_Click(object sender, EventArgs e)
        {
            FormRegistracija form = new FormRegistracija();
            form.ShowDialog();
        }

        private void FormPrijava_Load(object sender, EventArgs e)
        {
            lblKreiraj.MouseHover += LblKreiraj_MouseHover;
            lblKreiraj.MouseLeave += LblKreiraj_MouseLeave;
            lblKreiraj.Click += lblKreiraj_Click;
        }


        private void LblKreiraj_MouseLeave(object sender, EventArgs e)
        {
            lblKreiraj.ForeColor = System.Drawing.Color.RoyalBlue;
        }

        private void LblKreiraj_MouseHover(object sender, EventArgs e)
        {
            lblKreiraj.ForeColor = System.Drawing.Color.Black;
        }
    }
}
