using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    class Program
    {
        public static IBLEmployees blHandler;

        static void Main(string[] args)
        {
            SetupDependencies();
            SetupService();
        }

        private static void SetupDependencies()
        {
            blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
        }

        private static void SetupService()
        {
            Uri uri = new Uri("http://localhost:8834/tsi1/");
            ServiceHost host = new ServiceHost(typeof(ServiceEmployees), uri);
            try
            {
                host.AddServiceEndpoint(typeof(IServiceEmployees), new BasicHttpBinding(), "");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);
                host.Open();
                Console.WriteLine("El servicio comenzo a hostear a las " + DateTime.Now.ToString());
                Console.WriteLine("El host esta funcionando... Presiona <Enter> para detenerlo");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
