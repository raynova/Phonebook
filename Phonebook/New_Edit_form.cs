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
        public New_Edit_form(Contacts contact)
        {
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

            InitializeComponent(formText);

            if(contact.name != null || contact.lastName != null || contact.phone != 0 || contact.address != null || contact.email != null)
            {
                txt_NewEdit_Name.Text = contact.name;
                txt_NewEdit_LastName.Text = contact.lastName;
                txt_NewEdit_Phone.Text = Convert.ToString(contact.phone);
                txt_NewEdit_Address.Text = contact.address;
                txt_NewEdit_email.Text = contact.email;
            }
        }

        public New_Edit_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewEdit_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
