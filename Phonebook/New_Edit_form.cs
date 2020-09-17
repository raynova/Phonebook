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
    public partial class New_Edit_form : Form
    {
        Connection con;
        bool editCont = false;
        List<Contacts> lstContacts;
        Contacts contact;
        ListView lstv_Main_ContactLst;

        public New_Edit_form(List<Contacts> lstContacts, Contacts contact, Connection con, ListView lstv_Main_ContactLst)
        {
            this.lstContacts = lstContacts;
            this.lstv_Main_ContactLst = lstv_Main_ContactLst;
            this.con = con;
            this.contact = contact;

            editCont = true;
            string formText;

            if (contact.name != null)
            {
                formText = contact.name;
            }
            else if (contact.lastName != null)
            {
                formText = contact.lastName;
            }
            else if (contact.phone != 0)
            {
                formText = Convert.ToString(contact.phone);
            }
            else { formText = "Edit contact"; }

            InitializeComponent();
            this.Text = formText;

            if(contact.name != null || contact.lastName != null || contact.phone != 0 || contact.address != null || contact.email != null)
            {
                txt_NewEdit_Name.Text = contact.name;
                txt_NewEdit_LastName.Text = contact.lastName;
                txt_NewEdit_Phone.Text = Convert.ToString(contact.phone);
                txt_NewEdit_Address.Text = contact.address;
                txt_NewEdit_email.Text = contact.email;
            }
        }

        public New_Edit_form(Connection con, List<Contacts> lstContacts, ListView lstv_Main_ContactLst)
        {
            this.lstv_Main_ContactLst = lstv_Main_ContactLst;
            this.lstContacts = lstContacts;
            this.con = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string lastName = "";
            int phone = 0;
            string address = "";
            string email = "";

            if (txt_NewEdit_Name != null)
            {
                name = txt_NewEdit_Name.Text;
            }
            if (txt_NewEdit_LastName != null)
            {
                lastName = txt_NewEdit_LastName.Text;
            }
            if (txt_NewEdit_Phone != null)
            {
                phone = Convert.ToInt32(txt_NewEdit_Phone.Text);
            }
            if (txt_NewEdit_Address != null)
            {
                address = txt_NewEdit_Address.Text;
            }
            if (txt_NewEdit_email != null)
            {
                email = txt_NewEdit_email.Text;
            }


            if (editCont == false)
            {
                string query = $@"INSERT INTO contacts (name, lastName, phone, address, email) 
VALUES ('{name}', '{lastName}', {phone}, '{address}', '{email}')"
                    ;
                con.Update_Delete_New_Contact(query);
            }

            if(editCont == true)
            {
                string query = $@"UPDATE contacts 
SET name = '{name}', lastName = '{lastName}', phone = {phone}, address = '{address}', email = '{email}' 
WHERE id = {contact.id}";
                con.Update_Delete_New_Contact(query);
            }

            lstv_Main_ContactLst.Clear();
            lstContacts.Clear();

            string queryUpdate = "SELECT id, name, lastName, phone, address, email FROM contacts";
            con.Select(lstContacts, queryUpdate);
            foreach (Contacts contact in lstContacts)
            {
                lstv_Main_ContactLst.Items.Add(contact.name + " " + contact.lastName);
            }
            

            Close();
        }

        private void btn_NewEdit_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public ListView ReturnListView(ListView lstv_Main_ContactLst)
        {
            return lstv_Main_ContactLst;
        }
    }
}
