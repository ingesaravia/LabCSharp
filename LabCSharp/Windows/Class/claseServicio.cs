using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace LabCSharp.Windows.Class
{
    public class claseServicio:ServiceBase
    {
        //Requiere incluir Referencia System.ServiceProcess

        public void iniciarServicio()
        {
            ServiceController sc = new ServiceController("Nombre Del Servicio");

            try
            {
                if (sc != null && sc.Status == ServiceControllerStatus.Stopped)
                {
                    sc.Start();
                }
                sc.WaitForStatus(ServiceControllerStatus.Running);
                sc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al arrancar el servicio:");
                Console.WriteLine(ex.Message);
            }
        }


        public void detenerServicio()
        {
            ServiceController sc = new ServiceController("wuauserv");

            try
            {
                if (sc != null && sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                }
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                sc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al detener el servicio:");
                Console.WriteLine(ex.Message);
            }
        }

        public void listarServicio()
        {
            ServiceController[] services = ServiceController.GetServices();

            foreach (ServiceController sc in services)
            {
                System.Console.WriteLine(sc.ServiceName);
            }


        }
        
        
    }
}
