using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjection.Utilities
{
    public class Logger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine($"Logging {message}");
        }
    }
}
