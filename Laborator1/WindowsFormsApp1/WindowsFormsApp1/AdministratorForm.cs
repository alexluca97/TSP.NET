using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class AdministratorForm
    {
        public delegate void StartAdministratorFormEventHandler(object source, EventArgs args);

        public event StartAdministratorFormEventHandler AdminFormStarted;

        public void StartForm()
        {
            OnAdminFormStarted();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());

          
        }


        protected virtual void OnAdminFormStarted()
        {
            if (AdminFormStarted != null)
                AdminFormStarted(this, EventArgs.Empty);
        }
    }
}
