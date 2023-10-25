using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        private Knjiznica knjiznica;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            knjiznica = new Knjiznica();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {

        }
    }
}
