using davaleba_2.Employe;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace davaleba_2.DbManager
{
    public class DbManager
    {
        public static string EmployeDb = ConfigurationManager.ConnectionStrings["EmployeDb"].ConnectionString;

        public List<Employee> GetEmployes()
        {
            List<Employee> list = new List<Employee>();

            SqlCommand cmd = new SqlCommand("[GetEmploye]");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (SqlConnection conn = new SqlConnection(EmployeDb))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = Convert.ToInt32(reader["Id"]);
                        emp.Name = Convert.ToString(reader["Name"]);
                        emp.Surname = Convert.ToString(reader["Surname"]);
                        emp.Privatenumber = Convert.ToString(reader["Privatenumber"]);
                        emp.Birthdate = Convert.ToDateTime(reader["Birthdate"]);
                        emp.Faculcy = Convert.ToString(reader["Faculcy"]);
                        emp.Averagemark = Convert.ToString(reader["Averagemark"]);
                        emp.Phonenumber = Convert.ToString(reader["Phonenumber"]);
                        emp.Ismarried = Convert.ToBoolean(reader["Ismarried"]);

                        list.Add(emp);
                    }
                    reader.Close();
                }
                return list;
            }
        }
        public void AddEmploy (Employe.Employee employe)
        {
            SqlCommand cmd = new SqlCommand("AddEmployee");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", employe.Id);
            cmd.Parameters.AddWithValue("@Name", employe.Name);
            cmd.Parameters.AddWithValue("@Surname", employe.Surname);
            cmd.Parameters.AddWithValue("@Privatenumber", employe.Privatenumber);
            cmd.Parameters.AddWithValue("@Birthdate", employe.Birthdate);
            cmd.Parameters.AddWithValue("@Faculcy", employe.Faculcy);
            cmd.Parameters.AddWithValue("@Averagemark", employe.Averagemark);
            cmd.Parameters.AddWithValue("@Phonenumber", employe.Phonenumber);
            cmd.Parameters.AddWithValue("@Ismarried", employe.Ismarried);


            using (SqlConnection conn = new SqlConnection(EmployeDb))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}


