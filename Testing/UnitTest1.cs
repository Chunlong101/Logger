using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logging;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var log = Logging.Logger.GetLogger(this.GetType());
            log.Info("asdf"); 
        }
    }
}
