
namespace ATBM_Proj.Forms
{
    partial class CreateUsers
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnRegis = new FontAwesome.Sharp.IconButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoselect = new System.Windows.Forms.RadioButton();
            this.rdoUpdate = new System.Windows.Forms.RadioButton();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.rdoInsert = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGrant = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 237);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(186, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delete User";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(38, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select User: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(202, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Drop User";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegis.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegis.IconColor = System.Drawing.Color.Black;
            this.btnRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegis.Location = new System.Drawing.Point(289, 185);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(107, 29);
            this.btnRegis.TabIndex = 11;
            this.btnRegis.Text = "Confirm";
            this.btnRegis.UseVisualStyleBackColor = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(242, 138);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(154, 23);
            this.txtPass.TabIndex = 10;
            this.txtPass.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(67, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Username: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(242, 82);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(154, 23);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "Enter Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(545, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 237);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(418, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grant Privileges User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(22, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select User: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 355);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(24, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Select Tables: ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(28, 470);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoInsert);
            this.groupBox1.Controls.Add(this.rdoDelete);
            this.groupBox1.Controls.Add(this.rdoUpdate);
            this.groupBox1.Controls.Add(this.rdoselect);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(236, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(143, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privileges";
            // 
            // rdoselect
            // 
            this.rdoselect.AutoSize = true;
            this.rdoselect.Location = new System.Drawing.Point(24, 23);
            this.rdoselect.Name = "rdoselect";
            this.rdoselect.Size = new System.Drawing.Size(79, 20);
            this.rdoselect.TabIndex = 0;
            this.rdoselect.TabStop = true;
            this.rdoselect.Text = "SELECT";
            this.rdoselect.UseVisualStyleBackColor = true;
            // 
            // rdoUpdate
            // 
            this.rdoUpdate.AutoSize = true;
            this.rdoUpdate.Location = new System.Drawing.Point(23, 49);
            this.rdoUpdate.Name = "rdoUpdate";
            this.rdoUpdate.Size = new System.Drawing.Size(83, 20);
            this.rdoUpdate.TabIndex = 1;
            this.rdoUpdate.TabStop = true;
            this.rdoUpdate.Text = "UPDATE";
            this.rdoUpdate.UseVisualStyleBackColor = true;
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Location = new System.Drawing.Point(23, 75);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(81, 20);
            this.rdoDelete.TabIndex = 2;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "DELETE";
            this.rdoDelete.UseVisualStyleBackColor = true;
            // 
            // rdoInsert
            // 
            this.rdoInsert.AutoSize = true;
            this.rdoInsert.Location = new System.Drawing.Point(24, 101);
            this.rdoInsert.Name = "rdoInsert";
            this.rdoInsert.Size = new System.Drawing.Size(77, 20);
            this.rdoInsert.TabIndex = 3;
            this.rdoInsert.TabStop = true;
            this.rdoInsert.Text = "INSERT";
            this.rdoInsert.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(475, 373);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(176, 112);
            this.checkedListBox1.TabIndex = 11;
            // 
            // btnGrant
            // 
            this.btnGrant.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrant.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGrant.IconColor = System.Drawing.Color.Black;
            this.btnGrant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrant.Location = new System.Drawing.Point(777, 400);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(110, 33);
            this.btnGrant.TabIndex = 12;
            this.btnGrant.Text = "Grant";
            this.btnGrant.UseVisualStyleBackColor = false;
            // 
            // CreateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1067, 574);
            this.Controls.Add(this.btnGrant);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateUsers";
            this.Text = "CreateUsers";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoInsert;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.RadioButton rdoUpdate;
        private System.Windows.Forms.RadioButton rdoselect;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private FontAwesome.Sharp.IconButton btnGrant;
    }
}