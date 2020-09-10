using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Main_form : Form
    {
        List<Contacts> lstContacts;
        Connection con;
        ListView lstViewVar;
        public Main_form(List<Contacts> lstContacts, Connection con)
        {
            lstViewVar = lstv_Main_ContactLst;

            this.lstContacts = lstContacts;
            this.con = con;
            InitializeComponent();

            foreach (Contacts contact in lstContacts)
            {
                lstv_Main_ContactLst.Items.Add(contact.name + " " + contact.lastName);
            }
        }

        //button Open
        private void button1_Click(object sender, EventArgs e)
        {
            var x = new Info_form(lstViewVar);
            x.ShowDialog(lstViewVar);
        }

        private void btn_Main_New_Click(object sender, EventArgs e)
        {
            var x = new New_Edit_form();
            x.ShowDialog();
        }

        private void comboBox_Main_Search_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Main_Search.SelectedIndex < 0)
            {
                comboBox_Main_Search.Text = "Search...";
            }
            else
            {
                comboBox_Main_Search.Text = comboBox_Main_Search.SelectedText;
            }
        }

        private void btn_Main_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
