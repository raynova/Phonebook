namespace Phonebook
{
    partial class New_Edit_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.btn_NewEdit_Save = new System.Windows.Forms.Button();
            this.btn_NewEdit_Cancel = new System.Windows.Forms.Button();
            this.lbl_NewEdit_Name = new System.Windows.Forms.Label();
            this.lbl_NewEdit_LastName = new System.Windows.Forms.Label();
            this.lbl_NewEdit_Phone = new System.Windows.Forms.Label();
            this.lbl_NewEdit_Address = new System.Windows.Forms.Label();
            this.lbl_NewEdit_email = new System.Windows.Forms.Label();
            this.txt_NewEdit_Name = new System.Windows.Forms.TextBox();
            this.txt_NewEdit_LastName = new System.Windows.Forms.TextBox();
            this.txt_NewEdit_Phone = new System.Windows.Forms.TextBox();
            this.txt_NewEdit_Address = new System.Windows.Forms.TextBox();
            this.txt_NewEdit_email = new System.Windows.Forms.TextBox();
            this.lbl_NewEdit_Picture = new System.Windows.Forms.Label();
            this.openFile_NewEdit_Picture = new System.Windows.Forms.OpenFileDialog();
            this.btn_NewEdit_OpenPicture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewEdit_Save
            // 
            this.btn_NewEdit_Save.Location = new System.Drawing.Point(53, 386);
            this.btn_NewEdit_Save.Name = "btn_NewEdit_Save";
            this.btn_NewEdit_Save.Size = new System.Drawing.Size(75, 26);
            this.btn_NewEdit_Save.TabIndex = 0;
            this.btn_NewEdit_Save.Text = "Save";
            this.btn_NewEdit_Save.UseVisualStyleBackColor = true;
            this.btn_NewEdit_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_NewEdit_Cancel
            // 
            this.btn_NewEdit_Cancel.Location = new System.Drawing.Point(221, 386);
            this.btn_NewEdit_Cancel.Name = "btn_NewEdit_Cancel";
            this.btn_NewEdit_Cancel.Size = new System.Drawing.Size(75, 26);
            this.btn_NewEdit_Cancel.TabIndex = 1;
            this.btn_NewEdit_Cancel.Text = "Cancel";
            this.btn_NewEdit_Cancel.UseVisualStyleBackColor = true;
            this.btn_NewEdit_Cancel.Click += new System.EventHandler(this.btn_NewEdit_Cancel_Click);
            // 
            // lbl_NewEdit_Name
            // 
            this.lbl_NewEdit_Name.AutoSize = true;
            this.lbl_NewEdit_Name.Location = new System.Drawing.Point(12, 38);
            this.lbl_NewEdit_Name.Name = "lbl_NewEdit_Name";
            this.lbl_NewEdit_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_NewEdit_Name.TabIndex = 2;
            this.lbl_NewEdit_Name.Text = "Name";
            // 
            // lbl_NewEdit_LastName
            // 
            this.lbl_NewEdit_LastName.AutoSize = true;
            this.lbl_NewEdit_LastName.Location = new System.Drawing.Point(12, 79);
            this.lbl_NewEdit_LastName.Name = "lbl_NewEdit_LastName";
            this.lbl_NewEdit_LastName.Size = new System.Drawing.Size(56, 13);
            this.lbl_NewEdit_LastName.TabIndex = 3;
            this.lbl_NewEdit_LastName.Text = "Last name";
            // 
            // lbl_NewEdit_Phone
            // 
            this.lbl_NewEdit_Phone.AutoSize = true;
            this.lbl_NewEdit_Phone.Location = new System.Drawing.Point(12, 123);
            this.lbl_NewEdit_Phone.Name = "lbl_NewEdit_Phone";
            this.lbl_NewEdit_Phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_NewEdit_Phone.TabIndex = 4;
            this.lbl_NewEdit_Phone.Text = "Phone";
            // 
            // lbl_NewEdit_Address
            // 
            this.lbl_NewEdit_Address.AutoSize = true;
            this.lbl_NewEdit_Address.Location = new System.Drawing.Point(12, 163);
            this.lbl_NewEdit_Address.Name = "lbl_NewEdit_Address";
            this.lbl_NewEdit_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_NewEdit_Address.TabIndex = 5;
            this.lbl_NewEdit_Address.Text = "Address";
            // 
            // lbl_NewEdit_email
            // 
            this.lbl_NewEdit_email.AutoSize = true;
            this.lbl_NewEdit_email.Location = new System.Drawing.Point(12, 238);
            this.lbl_NewEdit_email.Name = "lbl_NewEdit_email";
            this.lbl_NewEdit_email.Size = new System.Drawing.Size(34, 13);
            this.lbl_NewEdit_email.TabIndex = 6;
            this.lbl_NewEdit_email.Text = "e-mail";
            // 
            // txt_NewEdit_Name
            // 
            this.txt_NewEdit_Name.Location = new System.Drawing.Point(122, 38);
            this.txt_NewEdit_Name.Name = "txt_NewEdit_Name";
            this.txt_NewEdit_Name.Size = new System.Drawing.Size(183, 20);
            this.txt_NewEdit_Name.TabIndex = 7;
            // 
            // txt_NewEdit_LastName
            // 
            this.txt_NewEdit_LastName.Location = new System.Drawing.Point(122, 79);
            this.txt_NewEdit_LastName.Name = "txt_NewEdit_LastName";
            this.txt_NewEdit_LastName.Size = new System.Drawing.Size(183, 20);
            this.txt_NewEdit_LastName.TabIndex = 8;
            // 
            // txt_NewEdit_Phone
            // 
            this.txt_NewEdit_Phone.Location = new System.Drawing.Point(122, 123);
            this.txt_NewEdit_Phone.Name = "txt_NewEdit_Phone";
            this.txt_NewEdit_Phone.Size = new System.Drawing.Size(183, 20);
            this.txt_NewEdit_Phone.TabIndex = 9;
            // 
            // txt_NewEdit_Address
            // 
            this.txt_NewEdit_Address.Location = new System.Drawing.Point(122, 163);
            this.txt_NewEdit_Address.Multiline = true;
            this.txt_NewEdit_Address.Name = "txt_NewEdit_Address";
            this.txt_NewEdit_Address.Size = new System.Drawing.Size(183, 69);
            this.txt_NewEdit_Address.TabIndex = 10;
            // 
            // txt_NewEdit_email
            // 
            this.txt_NewEdit_email.Location = new System.Drawing.Point(122, 238);
            this.txt_NewEdit_email.Multiline = true;
            this.txt_NewEdit_email.Name = "txt_NewEdit_email";
            this.txt_NewEdit_email.Size = new System.Drawing.Size(183, 50);
            this.txt_NewEdit_email.TabIndex = 11;
            // 
            // lbl_NewEdit_Picture
            // 
            this.lbl_NewEdit_Picture.AutoSize = true;
            this.lbl_NewEdit_Picture.Location = new System.Drawing.Point(11, 309);
            this.lbl_NewEdit_Picture.Name = "lbl_NewEdit_Picture";
            this.lbl_NewEdit_Picture.Size = new System.Drawing.Size(40, 13);
            this.lbl_NewEdit_Picture.TabIndex = 12;
            this.lbl_NewEdit_Picture.Text = "Picture";
            // 
            // btn_NewEdit_OpenPicture
            // 
            this.btn_NewEdit_OpenPicture.Location = new System.Drawing.Point(122, 309);
            this.btn_NewEdit_OpenPicture.Name = "btn_NewEdit_OpenPicture";
            this.btn_NewEdit_OpenPicture.Size = new System.Drawing.Size(75, 23);
            this.btn_NewEdit_OpenPicture.TabIndex = 13;
            this.btn_NewEdit_OpenPicture.Text = "Open...";
            this.btn_NewEdit_OpenPicture.UseVisualStyleBackColor = true;
            // 
            // New_Edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 461);
            this.Controls.Add(this.btn_NewEdit_OpenPicture);
            this.Controls.Add(this.lbl_NewEdit_Picture);
            this.Controls.Add(this.txt_NewEdit_email);
            this.Controls.Add(this.txt_NewEdit_Address);
            this.Controls.Add(this.txt_NewEdit_Phone);
            this.Controls.Add(this.txt_NewEdit_LastName);
            this.Controls.Add(this.txt_NewEdit_Name);
            this.Controls.Add(this.lbl_NewEdit_email);
            this.Controls.Add(this.lbl_NewEdit_Address);
            this.Controls.Add(this.lbl_NewEdit_Phone);
            this.Controls.Add(this.lbl_NewEdit_LastName);
            this.Controls.Add(this.lbl_NewEdit_Name);
            this.Controls.Add(this.btn_NewEdit_Cancel);
            this.Controls.Add(this.btn_NewEdit_Save);
            this.Name = "New_Edit_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewEdit_Save;
        private System.Windows.Forms.Button btn_NewEdit_Cancel;
        private System.Windows.Forms.Label lbl_NewEdit_Name;
        private System.Windows.Forms.Label lbl_NewEdit_LastName;
        private System.Windows.Forms.Label lbl_NewEdit_Phone;
        private System.Windows.Forms.Label lbl_NewEdit_Address;
        private System.Windows.Forms.Label lbl_NewEdit_email;
        private System.Windows.Forms.TextBox txt_NewEdit_Name;
        private System.Windows.Forms.TextBox txt_NewEdit_LastName;
        private System.Windows.Forms.TextBox txt_NewEdit_Phone;
        private System.Windows.Forms.TextBox txt_NewEdit_Address;
        private System.Windows.Forms.TextBox txt_NewEdit_email;
        private System.Windows.Forms.Label lbl_NewEdit_Picture;
        private System.Windows.Forms.OpenFileDialog openFile_NewEdit_Picture;
        private System.Windows.Forms.Button btn_NewEdit_OpenPicture;
    }
}