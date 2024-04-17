namespace NTier101_Live.PL
{
    partial class frmUser
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
            this.dgrdUsers = new System.Windows.Forms.DataGridView();
            this.btonNew = new System.Windows.Forms.Button();
            this.btonUpdate = new System.Windows.Forms.Button();
            this.btonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.tboxUserPassw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.tboxSoyad = new System.Windows.Forms.TextBox();
            this.tboxTCKimlik = new System.Windows.Forms.TextBox();
            this.tboxMudurlukID = new System.Windows.Forms.TextBox();
            this.btonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdUsers
            // 
            this.dgrdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdUsers.Location = new System.Drawing.Point(13, 13);
            this.dgrdUsers.Name = "dgrdUsers";
            this.dgrdUsers.Size = new System.Drawing.Size(651, 150);
            this.dgrdUsers.TabIndex = 0;
            // 
            // btonNew
            // 
            this.btonNew.Location = new System.Drawing.Point(13, 185);
            this.btonNew.Name = "btonNew";
            this.btonNew.Size = new System.Drawing.Size(75, 23);
            this.btonNew.TabIndex = 1;
            this.btonNew.Text = "Yeni";
            this.btonNew.UseVisualStyleBackColor = true;
            this.btonNew.Click += new System.EventHandler(this.btonNew_Click);
            // 
            // btonUpdate
            // 
            this.btonUpdate.Location = new System.Drawing.Point(115, 185);
            this.btonUpdate.Name = "btonUpdate";
            this.btonUpdate.Size = new System.Drawing.Size(75, 23);
            this.btonUpdate.TabIndex = 2;
            this.btonUpdate.Text = "Update";
            this.btonUpdate.UseVisualStyleBackColor = true;
            this.btonUpdate.Click += new System.EventHandler(this.btonUpdate_Click);
            // 
            // btonDelete
            // 
            this.btonDelete.Location = new System.Drawing.Point(215, 185);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(75, 23);
            this.btonDelete.TabIndex = 3;
            this.btonDelete.Text = "Delete";
            this.btonDelete.UseVisualStyleBackColor = true;
            this.btonDelete.Click += new System.EventHandler(this.btonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btonSave);
            this.groupBox1.Controls.Add(this.tboxMudurlukID);
            this.groupBox1.Controls.Add(this.tboxTCKimlik);
            this.groupBox1.Controls.Add(this.tboxSoyad);
            this.groupBox1.Controls.Add(this.tboxAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxUserPassw);
            this.groupBox1.Controls.Add(this.tboxUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Detay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(88, 28);
            this.tboxUserName.MaxLength = 10;
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(85, 20);
            this.tboxUserName.TabIndex = 7;
            // 
            // tboxUserPassw
            // 
            this.tboxUserPassw.Location = new System.Drawing.Point(88, 54);
            this.tboxUserPassw.MaxLength = 10;
            this.tboxUserPassw.Name = "tboxUserPassw";
            this.tboxUserPassw.Size = new System.Drawing.Size(85, 20);
            this.tboxUserPassw.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TC Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Müdürlük";
            // 
            // tboxAd
            // 
            this.tboxAd.Location = new System.Drawing.Point(88, 90);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(100, 20);
            this.tboxAd.TabIndex = 13;
            // 
            // tboxSoyad
            // 
            this.tboxSoyad.Location = new System.Drawing.Point(88, 118);
            this.tboxSoyad.Name = "tboxSoyad";
            this.tboxSoyad.Size = new System.Drawing.Size(100, 20);
            this.tboxSoyad.TabIndex = 14;
            // 
            // tboxTCKimlik
            // 
            this.tboxTCKimlik.Location = new System.Drawing.Point(88, 145);
            this.tboxTCKimlik.Name = "tboxTCKimlik";
            this.tboxTCKimlik.Size = new System.Drawing.Size(100, 20);
            this.tboxTCKimlik.TabIndex = 15;
            // 
            // tboxMudurlukID
            // 
            this.tboxMudurlukID.Location = new System.Drawing.Point(88, 175);
            this.tboxMudurlukID.Name = "tboxMudurlukID";
            this.tboxMudurlukID.Size = new System.Drawing.Size(43, 20);
            this.tboxMudurlukID.TabIndex = 16;
            // 
            // btonSave
            // 
            this.btonSave.Location = new System.Drawing.Point(255, 178);
            this.btonSave.Name = "btonSave";
            this.btonSave.Size = new System.Drawing.Size(75, 23);
            this.btonSave.TabIndex = 17;
            this.btonSave.Text = "Kaydet";
            this.btonSave.UseVisualStyleBackColor = true;
            this.btonSave.Click += new System.EventHandler(this.btonSave_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btonDelete);
            this.Controls.Add(this.btonUpdate);
            this.Controls.Add(this.btonNew);
            this.Controls.Add(this.dgrdUsers);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdUsers;
        private System.Windows.Forms.Button btonNew;
        private System.Windows.Forms.Button btonUpdate;
        private System.Windows.Forms.Button btonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxUserPassw;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btonSave;
        private System.Windows.Forms.TextBox tboxMudurlukID;
        private System.Windows.Forms.TextBox tboxTCKimlik;
        private System.Windows.Forms.TextBox tboxSoyad;
        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}