using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string query = "SELECT name, lastName, phone, address, email FROM contacts";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            List<Contacts> lstContacts = new List<Contacts>();
            Connection con = new Connection();
            con.Select(lstContacts, query);

            Application.Run(new Main_form(lstContacts, con));
            
        }
    }
}
