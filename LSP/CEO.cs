using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int Rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * Rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing direct performance report");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're Fired..");
        }
    }
}
