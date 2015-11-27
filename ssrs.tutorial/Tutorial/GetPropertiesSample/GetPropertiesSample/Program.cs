using System;
using GetPropertiesSample.ReportService2010;

namespace GetPropertiesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportingService2010 rs = new ReportingService2010();
            rs.Credentials = System.Net.CredentialCache.DefaultCredentials;
            rs.Url = "http://thebeast/ReportServer_SQL/reportservice2010.asmx";

            Property name = new Property();
            name.Name = "Name";

            Property description = new Property();
            description.Name = "Description";

            Property[] properties = new Property[2];
            properties[0] = name;
            properties[1] = description;

            try
            {

                Property[] returnProperties = rs.GetProperties("/Tutorial/SalesOrders", properties);
                
                foreach (Property p in returnProperties)
                {
                    Console.WriteLine(p.Name + ": " + p.Value);
                }

                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
