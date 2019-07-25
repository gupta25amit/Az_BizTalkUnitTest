using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timewave.BizTalkUnit.Sample.Schemas;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void OrderInstanceValidationTest()
        {
            var target = new  SourceSchema();

            //=== The SamplePOInput.xml file from <Samples Path>\Orchestrations\HelloWorld ===//  
            string strSourcePO_XML = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\OrderSample.xml";

            //=== Validate the SamplePOInput message against the schema ===//  
            Assert.IsTrue(target.ValidateInstance(strSourcePO_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
        }
    }
}
