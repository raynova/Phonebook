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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Edit_form));
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
            this.openFile_NewEdit_Picture = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_NewEdit_Save
            // 
            this.btn_NewEdit_Save.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_NewEdit_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewEdit_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewEdit_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_NewEdit_Save.Location = new System.Drawing.Point(34, 393);
            this.btn_NewEdit_Save.Name = "btn_NewEdit_Save";
            this.btn_NewEdit_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_NewEdit_Save.TabIndex = 0;
            this.btn_NewEdit_Save.Text = "Save";
            this.btn_NewEdit_Save.UseVisualStyleBackColor = false;
            this.btn_NewEdit_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_NewEdit_Cancel
            // 
            this.btn_NewEdit_Cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_NewEdit_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewEdit_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewEdit_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_NewEdit_Cancel.Location = new System.Drawing.Point(202, 393);
            this.btn_NewEdit_Cancel.Name = "btn_NewEdit_Cancel";
            this.btn_NewEdit_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_NewEdit_Cancel.TabIndex = 1;
            this.btn_NewEdit_Cancel.Text = "Cancel";
            this.btn_NewEdit_Cancel.UseVisualStyleBackColor = false;
            this.btn_NewEdit_Cancel.Click += new System.EventHandler(this.btn_NewEdit_Cancel_Click);
            // 
            // lbl_NewEdit_Name
            // 
            this.lbl_NewEdit_Name.AutoSize = true;
            this.lbl_NewEdit_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEdit_Name.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NewEdit_Name.Location = new System.Drawing.Point(22, 37);
            this.lbl_NewEdit_Name.Name = "lbl_NewEdit_Name";
            this.lbl_NewEdit_Name.Size = new System.Drawing.Size(45, 16);
            this.lbl_NewEdit_Name.TabIndex = 2;
            this.lbl_NewEdit_Name.Text = "Name";
            // 
            // lbl_NewEdit_LastName
            // 
            this.lbl_NewEdit_LastName.AutoSize = true;
            this.lbl_NewEdit_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEdit_LastName.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NewEdit_LastName.Location = new System.Drawing.Point(22, 78);
            this.lbl_NewEdit_LastName.Name = "lbl_NewEdit_LastName";
            this.lbl_NewEdit_LastName.Size = new System.Drawing.Size(70, 16);
            this.lbl_NewEdit_LastName.TabIndex = 3;
            this.lbl_NewEdit_LastName.Text = "Last name";
            // 
            // lbl_NewEdit_Phone
            // 
            this.lbl_NewEdit_Phone.AutoSize = true;
            this.lbl_NewEdit_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEdit_Phone.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NewEdit_Phone.Location = new System.Drawing.Point(22, 122);
            this.lbl_NewEdit_Phone.Name = "lbl_NewEdit_Phone";
            this.lbl_NewEdit_Phone.Size = new System.Drawing.Size(47, 16);
            this.lbl_NewEdit_Phone.TabIndex = 4;
            this.lbl_NewEdit_Phone.Text = "Phone";
            // 
            // lbl_NewEdit_Address
            // 
            this.lbl_NewEdit_Address.AutoSize = true;
            this.lbl_NewEdit_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEdit_Address.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NewEdit_Address.Location = new System.Drawing.Point(22, 162);
            this.lbl_NewEdit_Address.Name = "lbl_NewEdit_Address";
            this.lbl_NewEdit_Address.Size = new System.Drawing.Size(59, 16);
            this.lbl_NewEdit_Address.TabIndex = 5;
            this.lbl_NewEdit_Address.Text = "Address";
            // 
            // lbl_NewEdit_email
            // 
            this.lbl_NewEdit_email.AutoSize = true;
            this.lbl_NewEdit_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEdit_email.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_NewEdit_email.Location = new System.Drawing.Point(22, 279);
            this.lbl_NewEdit_email.Name = "lbl_NewEdit_email";
            this.lbl_NewEdit_email.Size = new System.Drawing.Size(45, 16);
            this.lbl_NewEdit_email.TabIndex = 6;
            this.lbl_NewEdit_email.Text = "e-mail";
            // 
            // txt_NewEdit_Name
            // 
            this.txt_NewEdit_Name.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NewEdit_Name.Location = new System.Drawing.Point(99, 37);
            this.txt_NewEdit_Name.Name = "txt_NewEdit_Name";
            this.txt_NewEdit_Name.Size = new System.Drawing.Size(195, 20);
            this.txt_NewEdit_Name.TabIndex = 7;
            // 
            // txt_NewEdit_LastName
            // 
            this.txt_NewEdit_LastName.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NewEdit_LastName.Location = new System.Drawing.Point(99, 78);
            this.txt_NewEdit_LastName.Name = "txt_NewEdit_LastName";
            this.txt_NewEdit_LastName.Size = new System.Drawing.Size(195, 20);
            this.txt_NewEdit_LastName.TabIndex = 8;
            // 
            // txt_NewEdit_Phone
            // 
            this.txt_NewEdit_Phone.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NewEdit_Phone.Location = new System.Drawing.Point(99, 122);
            this.txt_NewEdit_Phone.Name = "txt_NewEdit_Phone";
            this.txt_NewEdit_Phone.Size = new System.Drawing.Size(195, 20);
            this.txt_NewEdit_Phone.TabIndex = 9;
            // 
            // txt_NewEdit_Address
            // 
            this.txt_NewEdit_Address.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NewEdit_Address.Location = new System.Drawing.Point(99, 162);
            this.txt_NewEdit_Address.Multiline = true;
            this.txt_NewEdit_Address.Name = "txt_NewEdit_Address";
            this.txt_NewEdit_Address.Size = new System.Drawing.Size(195, 95);
            this.txt_NewEdit_Address.TabIndex = 10;
            // 
            // txt_NewEdit_email
            // 
            this.txt_NewEdit_email.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NewEdit_email.Location = new System.Drawing.Point(99, 279);
            this.txt_NewEdit_email.Multiline = true;
            this.txt_NewEdit_email.Name = "txt_NewEdit_email";
            this.txt_NewEdit_email.Size = new System.Drawing.Size(195, 50);
            this.txt_NewEdit_email.TabIndex = 11;
            // 
            // New_Edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(314, 461);
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
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.OpenFileDialog openFile_NewEdit_Picture;
    }
}