using System;
using System.Reflection;
using log4net;
using log4net.Config;
namespace LogExample
{
    class MainClass
    {
        private static readonly ILog _log = 
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            var displayMsg = "Hello World!";
            var error = "Error Cuy, ?????";
            var debug = "Hello, saatnya kita debug";
            _log.Info(displayMsg);
            _log.Error(error);
            _log.Debug(debug);
            Console.WriteLine(displayMsg);
            Console.WriteLine("Tes");
        }
    }
}
