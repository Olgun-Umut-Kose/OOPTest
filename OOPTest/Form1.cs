using OOPTest.Abstract;
using OOPTest.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPTest
{
    public partial class Form1 : Form
    {
        Dictionary<int, ICredit> pairs = new Dictionary<int, ICredit>();
        List<ICredit> credits = new List<ICredit>();
        ICredit credit;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbTasit_CheckedChanged(object sender, EventArgs e)
        {
            credit = pairs[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pairs.Add(1, new VehicleCredit());
            pairs.Add(2, new HouseCredit());
            pairs.Add(3, new PersonalFinanceCredit());
        }

        private void rbKonut_CheckedChanged(object sender, EventArgs e)
        {
            credit = pairs[2];
        }

        private void rbIhtiyac_CheckedChanged(object sender, EventArgs e)
        {
            credit = pairs[3];
        }

        private void btnKredi_Click(object sender, EventArgs e)
        {
            BasvuruManager.BasvuruYap(credit);
        }

        private void cbTasit_CheckedChanged(object sender, EventArgs e)
        {
            credits.Add(new VehicleCredit());
        }

        private void cbKonut_CheckedChanged(object sender, EventArgs e)
        {
            credits.Add(new HouseCredit());
        }

        private void cbIhtiyac_CheckedChanged(object sender, EventArgs e)
        {

            credits.Add(new PersonalFinanceCredit());

        }
        private void btnOnBilgi_Click(object sender, EventArgs e)
        {
            BasvuruManager.OnBilgilendirmeYap(credits);
            cbIhtiyac.Checked = false;
            cbKonut.Checked = false;
            cbTasit.Checked = false;
            credits.Clear();

        }
    }
}
