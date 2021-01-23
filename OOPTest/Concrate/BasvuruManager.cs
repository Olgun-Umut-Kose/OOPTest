using OOPTest.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.Concrate
{
    class BasvuruManager
    {
        public static void BasvuruYap(ICredit credit)
        {
            credit.Calculate();
        }
        public static void OnBilgilendirmeYap(List<ICredit> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
