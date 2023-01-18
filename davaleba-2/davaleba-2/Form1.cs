using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace davaleba_2
{
    public partial class Form1 : Form
    {
        DbManager.DbManager db = new DbManager.DbManager();
        public List<Employe.Employee> employelist = new List<Employe.Employee>();
        decimal total3;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Employe.Employee  emp= new Employe.Employee();
           
            emp.Name = Convert.ToString(textName.Text);
            emp.Surname = Convert.ToString(textSurname.Text);
            emp.Privatenumber = Convert.ToString(textPrivatenumber.Text);
            emp.Birthdate = Convert.ToDateTime(dateTimePicker1.Text);
            emp.Faculcy = Convert.ToString(textFaculcy.Text);
            emp.Averagemark = Convert.ToString(textAveragemark.Text);
            emp.Phonenumber = Convert.ToString(textPhonenumber.Text);
            emp.Ismarried = Convert.ToBoolean(check.Checked);



            db.AddEmploy(emp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbManager.DbManager DB = new DbManager.DbManager();
            dataGridView1.DataSource = DB.GetEmployes();
        }

    }
}
