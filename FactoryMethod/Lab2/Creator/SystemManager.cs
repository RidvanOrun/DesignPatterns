using FactoryMethod.Lab2.Concrete;
using FactoryMethod.Lab2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab2.Creator
{
    public class SystemManager
    {
        private ILoggerFactory _loggerFactory;

        public SystemManager(ILoggerFactory loggerFactory) => _loggerFactory = loggerFactory;


        public void Save()
        {
            ILogger loggerSystem = new SystemLoggerFactory().CreateLogger();
            ILogger loggerPLS = new PLSLoggerFactory().CreateLogger();

            loggerSystem.Log();
            loggerPLS.Log();
        }
    }
}
