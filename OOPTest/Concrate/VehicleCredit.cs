using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPTest.Abstract;

namespace OOPTest.Concrate
{
    class VehicleCredit : ICredit
    {
        public void Calculate()
        {
            MessageBox.Show("Taşıt Kredisi Hesap Sonucu:");
        }
    }
}
