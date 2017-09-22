using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FåglarProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            Fågel nyFågel = new Fågel();
            nyFågel.Namn = tbxNyFågel.Text;

            using (var context = new FåglarDBEntities())
            {
                context.Fåglar.Add(nyFågel);
                context.SaveChanges();
            }
        }

        private void btnVisaFåglar_Click(object sender, EventArgs e)
        {
            using (var context = new FåglarDBEntities())
            {
                var fråga = from fågel in context.Fåglar
                            select new { fågel.Namn };

                lbxFåglar.DataSource = fråga;
            }
        }
    }
}
