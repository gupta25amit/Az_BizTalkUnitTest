using BizUnit.Core;
using BizUnit.Core.TestBuilder;
using BizUnit.TestSteps.Common;
using BizUnit.TestSteps.DataLoaders.File;
using BizUnit.TestSteps.File;
using BizUnit.TestSteps.Time;
using BizUnit.TestSteps.ValidationSteps.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using MSTestExtensions;

namespace Timewave.BizTalkUnit.Sample.Tests
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {
        [TestMethod]
        public void SummaryTest()
        {
            //var totalItemsTest = new TestCase { Name = "Total Items is 3" };


            var sourceFilePath = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\OrderSample.xml";
            //var targetDirectory = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\Order";
            var targetFilePath = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\Order\OrderSample.xml";
            var DestinationDirSummary = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\Summary";


            //Get rid of any files that are already there
            var deleteStep = new DeleteStep();
            deleteStep.FilePathsToDelete.Add(targetFilePath);

            //Create the test step
            var createStep = new CreateStep();
            createStep.CreationPath = targetFilePath;   //Where are we going to create the file
            var dataLoader = new FileDataLoader();          //Where are we getting the file from?
            dataLoader.FilePath = sourceFilePath;
            createStep.DataSource = dataLoader;

            //Create a validating read step //We should only have one file in the directory
            var ValidateFileStep = new FileReadMultipleStep();
            ValidateFileStep.DirectoryPath = DestinationDirSummary;
            ValidateFileStep.SearchPattern = "*.xml";
            ValidateFileStep.Timeout = 3000;
            ValidateFileStep.ExpectedNumberOfFiles = 1;
            ValidateFileStep.DeleteFiles = true;


            //Create an XML Validation step //This will check the result against the XSD for the document
            var summarySchemaValidationStep = new XmlValidationStep();
            var schemaSummary = new SchemaDefinition();
            schemaSummary.XmlSchemaPath = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Timewave.BizUnit.Sample\Timewave.BizUnit.Sample\Schemas\SummarySchema.xsd";
            schemaSummary.XmlSchemaNameSpace = "http://Timewave.BizTalkUnit.Sample.DestinationSchema";

            summarySchemaValidationStep.XmlSchemas.Add(schemaSummary);

            //Create an XPath Validation.  This will check a value in the output.
            //The Xpath for the node can be grabbed from the Instance XPath property on the XSD.
            var xpathProductId = new XPathDefinition();
            xpathProductId.Description = "ItemsOrdered";
            xpathProductId.XPath = "/*[local-name()='CustomerSummary' and namespace-uri()='http://Timewave.BizTalkUnit.Sample.DestinationSchema']/*[local-name()='ItemsOrdered' and namespace-uri()='']";
            xpathProductId.Value = "2";
            summarySchemaValidationStep.XPathValidations.Add(xpathProductId);

            ValidateFileStep.SubSteps.Add(summarySchemaValidationStep);

            var testCase = new TestCase();
            testCase.SetupSteps.Add(deleteStep);
            testCase.ExecutionSteps.Add(createStep);
            testCase.ExecutionSteps.Add(ValidateFileStep);
            testCase.CleanupSteps.Add(deleteStep);

            var testRunner = new TestRunner(testCase);
            try
            {
                testRunner.Run();
            }
            catch (Exception ex)
            {

                string filePath = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\TestResult\Error.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-----------------------------------------------------------------------------");
                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                    writer.WriteLine();

                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }
            finally
            {
                TestCase.SaveToFile(
                    testCase,
                    @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\TestResult\SampleTest.xaml",
                    true);
            }

        }

        [TestMethod]
        public void PickListTest_ValidatePickListQuantity()
        {
            var validation = new XmlValidationStep();
            var schemaPickList = new SchemaDefinition
            {
                XmlSchemaPath = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Timewave.BizUnit.Sample\Timewave.BizUnit.Sample\Schemas\PickListSchema.xsd",
                XmlSchemaNameSpace = "http://Timewave.BizTalkUnit.Sample.PickListSchema"
            };
            validation.XmlSchemas.Add(schemaPickList);

            var xpathProductId = new XPathDefinition();
            xpathProductId.Description = "Quantity";
            xpathProductId.XPath = "/*[local-name()='PickList' and namespace-uri()='http://Timewave.BizTalkUnit.Sample.PickListSchema']/*[local-name()='Items' and namespace-uri()='']/*[local-name()='Quantity' and namespace-uri()='']"; ;
            xpathProductId.Value = "3";
            validation.XPathValidations.Add(xpathProductId);

            var ctx = new Context();
            string[] filePaths = Directory.GetFiles(@"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\Picklist", "*.xml");
            var data = StreamHelper.LoadFileToStream(filePaths[0]);
            validation.Execute(data, ctx);
        }

        [TestMethod]
        public void PickListTest_QuantityMisMatch()
        {
            var validation = new XmlValidationStep();
            var schemaPurchaseOrder = new SchemaDefinition
            {
                XmlSchemaPath = @"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Timewave.BizUnit.Sample\Timewave.BizUnit.Sample\Schemas\PickListSchema.xsd",
                XmlSchemaNameSpace = "http://Timewave.BizTalkUnit.Sample.PickListSchema"
            };
            validation.XmlSchemas.Add(schemaPurchaseOrder);

            var xpathProductId = new XPathDefinition();
            xpathProductId.Description = "Quantity";
            xpathProductId.XPath = "/*[local-name()='PickList' and namespace-uri()='http://Timewave.BizTalkUnit.Sample.PickListSchema']/*[local-name()='Items' and namespace-uri()='']/*[local-name()='Quantity' and namespace-uri()='']"; ;
            xpathProductId.Value = "8";
            validation.XPathValidations.Add(xpathProductId);

            var ctx = new Context();
            string[] filePaths = Directory.GetFiles(@"C:\Users\amigupta7\Desktop\Amit\Project\POC\Timewave.BizUnit.Sample\Testing\Picklist", "*.xml");
            var data = StreamHelper.LoadFileToStream(filePaths[0]);

            try
            {
                Assert.Throws<ValidationStepExecutionException>(() => validation.Execute(data, ctx));
            }
            catch (ValidationStepExecutionException vsee)
            {
                Assert.AreEqual("Failed to validate document instance", vsee.Message);
                Assert.AreEqual("The expected value for qauntity is 3", vsee.InnerException.Message);
            }
        }

    }
}
