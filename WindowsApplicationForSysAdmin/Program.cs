using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplicationForSysAdmin.Authenticate.Role;
using WindowsApplicationForSysAdmin.Authenticate.Users;
using WindowsApplicationForSysAdmin.Chart;
using WindowsApplicationForSysAdmin.Employee;
using Microsoft.AspNet.Identity;
using ObjectFactory.WinForm;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Chart;
using ServiceLayer.Employee;
using ServiceLayer.General.Type;
using StructureMap;

namespace WindowsApplicationForSysAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            var appuserManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<ApplicationUserManager>();
            appuserManager.SeedDatabase();

            Application.Run(new FrmLogin(appuserManager));

        }
    }
}
