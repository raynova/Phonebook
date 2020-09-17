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
        
        public Main_form(List<Contacts> lstContacts, Connection con)
        {
            this.lstContacts = lstContacts;
            this.con = con;
            InitializeComponent();

            foreach (Contacts contact in lstContacts)
            {
                string contStr = contact.name + " " + contact.lastName;
                lstv_Main_ContactLst.Items.Add(contact.name + " " + contact.lastName);
                comboBox_Main_Search.Items.Add(contStr);
            }

            comboBox_Main_Search.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_Main_Search.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //button Open
        /*private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Main_Search.SelectedItem.
            {
                int index = 0;
                foreach(ListViewItem item in lstv_Main_ContactLst.SelectedItems)
                {
                    index = item.Index;
                }
                var x = new Info_form(lstContacts, index, con, lstv_Main_ContactLst);
                x.ShowDialog();
            }
        }*/

        private void btn_Main_New_Click(object sender, EventArgs e)
        {
            var x = new New_Edit_form(con, lstContacts, lstv_Main_ContactLst);
            x.ShowDialog();
        }

        private void comboBox_Main_Search_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Main_Search.SelectedIndex < 0)
            {
                
            }
            else
            {
                comboBox_Main_Search.Text = comboBox_Main_Search.SelectedText;
            }
        }

        private void btn_Main_Delete_Click(object sender, EventArgs e)
        {
            if (lstv_Main_ContactLst.SelectedItems.Count == 1)
            {
                int index = 0;
                foreach (ListViewItem item in lstv_Main_ContactLst.SelectedItems)
                {
                    index = item.Index;
                }
                string query = $@"DELETE FROM contacts WHERE id = {lstContacts[index].id}";
                con.Update_Delete_New_Contact(query);
                lstContacts.RemoveAt(index);
                lstv_Main_ContactLst.Items.RemoveAt(index);
            }
        }

        private void lstv_Main_ContactLst_DoubleClick(object sender, EventArgs e)
        {
            if (lstv_Main_ContactLst.SelectedItems.Count == 1)
            {
                int index = 0;
                foreach (ListViewItem item in lstv_Main_ContactLst.SelectedItems)
                {
                    index = item.Index;
                }
                var x = new Info_form(lstContacts, index, con, lstv_Main_ContactLst);
                x.ShowDialog();
            }
        }
    }
}
