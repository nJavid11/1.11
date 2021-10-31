using System;
using System.Collections.Generic;
using System.Text;

namespace FourthPic
{
    class Student
    {
        string fName;
        string course;
        string sbj;
        string uni;
        string email;
        string pNum;

        public Student()
        {

        }
        public Student(string fname, string course, string sbj, string uni, string email, string pNum)
        {
            this.fName = fname;
            this.course = course;
            this.sbj = sbj;
            this.uni = uni;
            this.email = email;
            this.pNum = pNum;

            Console.WriteLine("sjsjsj");
        }
        public Student(string fname, string email, string pNum)
        {
            this.fName = fname;
            this.email = email;
            this.pNum = pNum;
        }

        public Student(string course, string sbj)
        {
            this.course = course;
            this.sbj = sbj;
        }
        public Student(string fName)
        {
            this.fName = fName;
        }

        public Student(string fname, string uni, string email, string pNum)
        {
            this.fName = fname;
            this.uni = uni;
            this.email = email;
            this.pNum = pNum;
        }

        public Student(string fname, string course, string sbj, string uni, string email)
        {
            this.fName = fname;
            this.course = course;
            this.sbj = sbj;
            this.uni = uni;
            this.email = email;
        }

        public string Info() {
            string infoStr = $"Fulname - {fName}, Course - {course}, Subject - {sbj},\nUniversity - {uni}, E-mail - {email}, Phone number - {pNum}";
            return infoStr;
        }
    }
}
