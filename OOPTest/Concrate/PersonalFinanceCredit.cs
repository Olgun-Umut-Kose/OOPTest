using System.Windows.Forms;
using OOPTest.Abstract;

namespace OOPTest.Concrate
{
    class PersonalFinanceCredit : ICredit
    {
        public void Calculate()
        {
            MessageBox.Show("İhtiyaç Kredisi Hesap Sonucu:");
        }
    }
}
