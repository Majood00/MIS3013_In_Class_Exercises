using System;
using System.Collections.Generic;

namespace Functions_Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> studentIDs = new List<int>();
            List<string> studentNames = new List<string>();
            List<string> studentCoursesTaken = new List<string>();

            studentIDs.Add(1);
            studentNames.Add("Talia");
            studentCoursesTaken.Add("MIS-2113, MIS-3013, MIS-3033, MIS-3353");

            studentIDs.Add(2);
            studentNames.Add("Kaylee");
            studentCoursesTaken.Add("MIS-2113, MIS-3013, MIS-3033, MIS-3353, MIS-3383");

            studentIDs.Add(3);
            studentNames.Add("Jenna");
            studentCoursesTaken.Add("MIS-2113, MIS-3013, MIS-3353");

            OutputStudentsWhoveTakenParticularCourse("MIS-2113", studentIDs, studentNames, studentCoursesTaken);
            OutputStudentsWhoveTakenParticularCourse("MIS-3383", studentIDs, studentNames, studentCoursesTaken);

            OutputStudentDetails("Talia", studentIDs, studentNames, studentCoursesTaken);
        }

        static void OutputStudentsWhoveTakenParticularCourse(string course, List<int> ids, 
            List<string> names, List<string> courses)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (courses[i].Contains(course) == true)
                {
                    Console.WriteLine($"{names[i]} ({ids[i]}) has taken {course}");
                }
            }
        }

        static void OutputStudentDetails(string student, List<int> ids,
            List<string> names, List<string> courses)
        {
            for (int i = 0; i < ids.Count; i++)
            {
                if (names[i] == student)
                {
                    Console.WriteLine($"{names[i]} ({ids[i]}) has taken the following course(s): {courses[i]}");

                    Console.WriteLine();
                }
            }
        }
    }
}
