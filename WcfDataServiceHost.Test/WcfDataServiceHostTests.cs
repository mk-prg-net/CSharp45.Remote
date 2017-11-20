using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Linq;


namespace WcfDataServiceHost.Test
{
    [TestClass]
    public class WcfDataServiceHostTests
    {
        [TestMethod]
        public void WcfDataServiceHostTest1()
        {
            var proxy = new ServiceReference1.KeplerDBEntities(new Uri("http://localhost:52789/KeplerDbDataService.svc/"));
            
            proxy.HimmelskoerperTab


        }
    }
}
