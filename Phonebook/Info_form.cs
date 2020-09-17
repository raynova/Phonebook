﻿using System;
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
    public partial class Info_form : Form
    {
        Connection con;
        Contacts contact = new Contacts();
        ListView lstv_Main_ContactLst;
        List<Contacts> lstContacts;
        ComboBox comboBox_Main_Search;
        public Info_form(List<Contacts> lstContacts, int index, Connection con, ListView lstv_Main_ContactLst, ComboBox comboBox_Main_Search)
        {
            this.comboBox_Main_Search = comboBox_Main_Search;
            this.lstContacts = lstContacts;
            this.lstv_Main_ContactLst = lstv_Main_ContactLst;
            this.con = con;
            contact = lstContacts[index];

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
            else { formText = "Info"; }

            InitializeComponent();
            this.Text = formText;

            lbl_Info_Name.Text = contact.name;
            lbl_Info_LastName.Text = contact.lastName;
            lbl_Info_Phone.Text = Convert.ToString(contact.phone);
            lbl_Info_Address.Text = contact.address;
            lbl_Info_email.Text = contact.email;
        }

        private void btn_Info_Edit_Click(object sender, EventArgs e)
        {
            var x = new New_Edit_form(lstContacts, contact, con, lstv_Main_ContactLst, comboBox_Main_Search);
            x.ShowDialog();
            Close();
        }

        private void btn_Info_Close2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
