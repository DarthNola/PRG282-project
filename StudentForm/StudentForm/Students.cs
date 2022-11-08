using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    internal class Students
    {
        int studentID;
        string studentName;
        string surname;
        string DOB;
        string gender;
        string phone;
        string address;
        string module;

        public Students(int studentID, string studentName, string surname, string dOB, string gender, string phone, string address, string module)
        {
            this.StudentID = studentID;
            this.StudentName = studentName;
            this.Surname = surname;
            DOB1 = dOB;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
            this.Module = module;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Module { get => module; set => module = value; }
    }
}
