using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using ReportService2010;


namespace SampleRDLSchema
{
    class ReportUpdater
    {
        ReportingService2010 _reportService;

        static void Main(string[] args)
        {
            ReportUpdater reportUpdater = new ReportUpdater();
            reportUpdater.UpdateReport();
        }

        private void UpdateReport()
        {
            try
            {
                // Set up the Report Service connection
                _reportService = new ReportingService2010();
                _reportService.Credentials =
                    System.Net.CredentialCache.DefaultCredentials;
                _reportService.Url =
                   "http://<Server Name>/reportserver/" +
                                   "reportservice2010.asmx";

                // Call the methods to update a report definition
                LoadReportDefinition();
                UpdateReportDefinition();
                PublishReportDefinition();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private void LoadReportDefinition()
        {
            //Lesson 3: Load a report definition from the report 
            //          catalog
        }

        private void UpdateReportDefinition()
        {
            //Lesson 4: Update the report definition using the  
            //          classes generated from the RDL Schema
        }

        private void PublishReportDefinition()
        {
            //Lesson 5: Publish the updated report definition back 
            //          to the report catalog
        }
    }
}