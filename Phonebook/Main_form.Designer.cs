namespace Phonebook
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.btn_Main_New = new System.Windows.Forms.Button();
            this.lstv_Main_ContactLst = new System.Windows.Forms.ListView();
            this.btn_Main_Delete = new System.Windows.Forms.Button();
            this.comboBox_Main_Search = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Main_New
            // 
            this.btn_Main_New.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Main_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Main_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_New.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Main_New.Location = new System.Drawing.Point(37, 401);
            this.btn_Main_New.Name = "btn_Main_New";
            this.btn_Main_New.Size = new System.Drawing.Size(75, 28);
            this.btn_Main_New.TabIndex = 1;
            this.btn_Main_New.Text = "New";
            this.btn_Main_New.UseVisualStyleBackColor = false;
            this.btn_Main_New.Click += new System.EventHandler(this.btn_Main_New_Click);
            // 
            // lstv_Main_ContactLst
            // 
            this.lstv_Main_ContactLst.BackColor = System.Drawing.Color.AliceBlue;
            this.lstv_Main_ContactLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_Main_ContactLst.FullRowSelect = true;
            this.lstv_Main_ContactLst.HideSelection = false;
            this.lstv_Main_ContactLst.Location = new System.Drawing.Point(37, 102);
            this.lstv_Main_ContactLst.MultiSelect = false;
            this.lstv_Main_ContactLst.Name = "lstv_Main_ContactLst";
            this.lstv_Main_ContactLst.Size = new System.Drawing.Size(237, 272);
            this.lstv_Main_ContactLst.TabIndex = 2;
            this.lstv_Main_ContactLst.TileSize = new System.Drawing.Size(230, 30);
            this.lstv_Main_ContactLst.UseCompatibleStateImageBehavior = false;
            this.lstv_Main_ContactLst.View = System.Windows.Forms.View.Tile;
            this.lstv_Main_ContactLst.DoubleClick += new System.EventHandler(this.lstv_Main_ContactLst_DoubleClick);
            // 
            // btn_Main_Delete
            // 
            this.btn_Main_Delete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Main_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Main_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_Main_Delete.Location = new System.Drawing.Point(199, 401);
            this.btn_Main_Delete.Name = "btn_Main_Delete";
            this.btn_Main_Delete.Size = new System.Drawing.Size(75, 28);
            this.btn_Main_Delete.TabIndex = 3;
            this.btn_Main_Delete.Text = "Delete";
            this.btn_Main_Delete.UseVisualStyleBackColor = false;
            this.btn_Main_Delete.Click += new System.EventHandler(this.btn_Main_Delete_Click);
            // 
            // comboBox_Main_Search
            // 
            this.comboBox_Main_Search.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox_Main_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Main_Search.FormattingEnabled = true;
            this.comboBox_Main_Search.Location = new System.Drawing.Point(37, 27);
            this.comboBox_Main_Search.Name = "comboBox_Main_Search";
            this.comboBox_Main_Search.Size = new System.Drawing.Size(237, 24);
            this.comboBox_Main_Search.TabIndex = 4;
            this.comboBox_Main_Search.Text = "Search...";
            this.comboBox_Main_Search.SelectedIndexChanged += new System.EventHandler(this.comboBox_Main_Search_SelectedIndexChanged);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(314, 461);
            this.Controls.Add(this.comboBox_Main_Search);
            this.Controls.Add(this.btn_Main_Delete);
            this.Controls.Add(this.lstv_Main_ContactLst);
            this.Controls.Add(this.btn_Main_New);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Main_New;
        private System.Windows.Forms.ListView lstv_Main_ContactLst;
        private System.Windows.Forms.Button btn_Main_Delete;
        private System.Windows.Forms.ComboBox comboBox_Main_Search;
    }
}

