using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo
{
    enum DisplayOption { All, Code, Name, Prerequsite, Semester }

    class Course
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Prerequsites { get; private set; }
        public int Semester { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            return string.Format("Course Code: {0}\nCourse Name: {1}\nSemester: {2}\nRequirements: {3}\nDescription: {4}",Code, Name, Semester, Prerequsites, Prerequsites.Substring(0, 60));
        }
        public Course(string code, string name, string description, string semester, string prerequsites)
        { Code = code;Description = description;Name = name;Prerequsites = prerequsites;Semester = Convert.ToInt32(semester); }
    }
}
