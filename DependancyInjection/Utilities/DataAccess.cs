using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjection.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void loadData()
        {
            Console.WriteLine("Loading Data...");
        }

        public void saveData(string name)
        {
            Console.WriteLine($"Saving {name}");
        }
    }
}
