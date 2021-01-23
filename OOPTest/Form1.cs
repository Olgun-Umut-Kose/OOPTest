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
        VehicleCredit vehicleCredit = new VehicleCredit();
        HouseCredit houseCredit = new HouseCredit();
        PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
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
            if (cbTasit.Checked)
            {
                credits.Add(vehicleCredit);
            }
            else
            {
                credits.Remove(vehicleCredit);
            }
        }

        private void cbKonut_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKonut.Checked)
            {
                credits.Add(houseCredit);
            }
            else
            {
                credits.Remove(houseCredit);
            }
        }

        private void cbIhtiyac_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIhtiyac.Checked)
            {
                credits.Add(personalFinanceCredit);
            }
            else
            {
                credits.Remove(personalFinanceCredit);
            }
        }

        private void btnOnBilgi_Click(object sender, EventArgs e)
        {
            BasvuruManager.OnBilgilendirmeYap(credits);
        }
    }
}
