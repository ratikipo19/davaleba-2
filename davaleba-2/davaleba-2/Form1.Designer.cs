
namespace davaleba_2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privatenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculcy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Averagemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ismarried = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textPrivatenumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textFaculcy = new System.Windows.Forms.TextBox();
            this.textAveragemark = new System.Windows.Forms.TextBox();
            this.textPhonenumber = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Surname,
            this.Privatenumber,
            this.Birthdate,
            this.Faculcy,
            this.Averagemark,
            this.Phonenumber,
            this.Ismarried});
            this.dataGridView1.Location = new System.Drawing.Point(48, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // Privatenumber
            // 
            this.Privatenumber.DataPropertyName = "Privatenumber";
            this.Privatenumber.HeaderText = "Privatenumber";
            this.Privatenumber.Name = "Privatenumber";
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // Faculcy
            // 
            this.Faculcy.DataPropertyName = "Faculcy";
            this.Faculcy.HeaderText = "Faculcy";
            this.Faculcy.Name = "Faculcy";
            // 
            // Averagemark
            // 
            this.Averagemark.DataPropertyName = "Averagemark";
            this.Averagemark.HeaderText = "Averagemark";
            this.Averagemark.Name = "Averagemark";
            // 
            // Phonenumber
            // 
            this.Phonenumber.DataPropertyName = "Phonenumber";
            this.Phonenumber.HeaderText = "Phonenumber";
            this.Phonenumber.Name = "Phonenumber";
            // 
            // Ismarried
            // 
            this.Ismarried.DataPropertyName = "Ismarried";
            this.Ismarried.HeaderText = "Ismarried";
            this.Ismarried.Name = "Ismarried";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(548, 547);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 66);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(91, 462);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(111, 20);
            this.textName.TabIndex = 3;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(91, 521);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(111, 20);
            this.textSurname.TabIndex = 4;
            // 
            // textPrivatenumber
            // 
            this.textPrivatenumber.Location = new System.Drawing.Point(91, 593);
            this.textPrivatenumber.Name = "textPrivatenumber";
            this.textPrivatenumber.Size = new System.Drawing.Size(111, 20);
            this.textPrivatenumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Privatenumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Faculcy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Averagemark";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 596);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phonenumber";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ismarried";
            // 
            // textFaculcy
            // 
            this.textFaculcy.Location = new System.Drawing.Point(319, 462);
            this.textFaculcy.Name = "textFaculcy";
            this.textFaculcy.Size = new System.Drawing.Size(111, 20);
            this.textFaculcy.TabIndex = 20;
            // 
            // textAveragemark
            // 
            this.textAveragemark.Location = new System.Drawing.Point(319, 525);
            this.textAveragemark.Name = "textAveragemark";
            this.textAveragemark.Size = new System.Drawing.Size(111, 20);
            this.textAveragemark.TabIndex = 21;
            // 
            // textPhonenumber
            // 
            this.textPhonenumber.Location = new System.Drawing.Point(319, 590);
            this.textPhonenumber.Name = "textPhonenumber";
            this.textPhonenumber.Size = new System.Drawing.Size(111, 20);
            this.textPhonenumber.TabIndex = 22;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(625, 418);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(56, 17);
            this.check.TabIndex = 23;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 411);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 625);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.textPhonenumber);
            this.Controls.Add(this.textAveragemark);
            this.Controls.Add(this.textFaculcy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrivatenumber);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textPrivatenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textFaculcy;
        private System.Windows.Forms.TextBox textAveragemark;
        private System.Windows.Forms.TextBox textPhonenumber;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privatenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculcy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Averagemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ismarried;
    }
}

