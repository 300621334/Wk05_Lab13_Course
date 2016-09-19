using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseDemo
{

    static class CourseManager
    {

        public static List<Course> courses;
        public static void Display(DisplayOption option, string toMatch = "")
        {
            foreach(Course x in courses)
            {
                switch(option)
                { case DisplayOption.All:
                        Console.WriteLine(x);
                        break;
                    case DisplayOption.Code:
                        if (toMatch == x.Code)
                            { Console.WriteLine(x); }
                            break;
                    case DisplayOption.Name:
                        if (toMatch == x.Name)
                        { Console.WriteLine(x); }
                        break;
                    case DisplayOption.Semester:
                        if (toMatch == x.Semester.ToString())
                        { Console.WriteLine(x); }
                        break;
                    case DisplayOption.Prerequsite:
                        if (x.Prerequsites.Contains(toMatch))
                        { Console.WriteLine(x); }
                        break;
                }
            }
        }
        public static void LoadCourses(string fileName)
        {
            courses = new List<Course>();
            using (TextReader reader = new StreamReader(fileName))
            {
                string line = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line==null) { break; }
                    string[] splitLine = line.Split('~');
                    courses.Add(new Course(splitLine[0], splitLine[1], splitLine[2], splitLine[3], splitLine[4]));
                }
            }
        }

    }
}
