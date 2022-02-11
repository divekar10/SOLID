using DependancyInjection.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjection
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void processData()
        {

            _logger.log("Starting the processing of data.");
            Console.WriteLine("Processing the data.");
            _dataAccess.loadData();
            _dataAccess.saveData("ProcessedInfo");
            _logger.log("Finished processing the data...");
        }
    }
}
