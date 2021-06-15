using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindergartenJoy.Forme
{
    public partial class FormUpisObavljen : Form
    {
        public FormUpisObavljen()
        {
            InitializeComponent();
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
