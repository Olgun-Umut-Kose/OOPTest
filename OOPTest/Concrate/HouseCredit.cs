using System.Windows.Forms;
using OOPTest.Abstract;

namespace OOPTest.Concrate
{
    class HouseCredit : ICredit
    {
        public void Calculate()
        {
            MessageBox.Show("Konut Kredisi Hesap Sonucu:");
        }
    }

}
