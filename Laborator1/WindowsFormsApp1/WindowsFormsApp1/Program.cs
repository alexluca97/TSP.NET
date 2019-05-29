using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var adminForm = new AdministratorForm(); //publisher
            var evidenceService = new EvidenceService(); // subscriber

            adminForm.AdminFormStarted += evidenceService.OnAdminFormStarted;

            adminForm.StartForm();

        }
    }

    public class EvidenceService
    {
        public void OnAdminFormStarted(object source, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Evidence\\Evidence.txt");
            sw.WriteLine("Admin form has started at: " + DateTime.Now);
        }
    }

}
