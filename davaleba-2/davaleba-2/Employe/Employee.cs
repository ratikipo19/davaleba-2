using System;

namespace davaleba_2.Employe
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Privatenumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Faculcy { get; set; }
        public string Averagemark { get; set; }
        public string Phonenumber { get; set; }
        public bool Ismarried { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, string privatenumber, DateTime birthdate, string faculcy, string averagemark, string phonenumber, bool ismarried)
        {
            Id = id;
            Name = name;
            Privatenumber = privatenumber;
            Birthdate = birthdate;
            Faculcy = faculcy;
            Averagemark = averagemark;
            Phonenumber = phonenumber;
            Ismarried = ismarried;

        }
    }
}
