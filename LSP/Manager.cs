using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int Rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (Rank * 4);

        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Performance review");
        }
    }
}
