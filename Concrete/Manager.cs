using SolidHomeWork.Abstract;
using SolidHomeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHomeWork.Concrete
{
    public class Manager : Employee,IReporting
    {
        public override decimal MaasHesapla(int rank)
        {
            return 1000 * rank;
        }

        public void SendReport()
        {
            Console.WriteLine("Müdür rapor gönderdi.");
        }
    }
}
