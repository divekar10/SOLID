using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Chore : IChore
    {
        ILogger _Logger;
        IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _Logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _Logger.Log($"Performed Work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _Logger.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner, $"The Chore {ChoreName} is Complete.");
        }
    }
}
