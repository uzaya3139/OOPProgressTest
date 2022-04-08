using System;
using System.Collections.Generic;

namespace FirstConsole
{
    class ObjectOrientedProgrammingCourse
    {
        class Student
        {
            public string student_Name;
            public string student_ID;
            public string identification_Card;
            public decimal mark;

            public void PrintBase()
            {
                Console.WriteLine("Student Name: " + student_Name);
                Console.WriteLine("Student ID: " + student_ID);
                Console.WriteLine("Identification Card: " + identification_Card);
                Console.WriteLine("Mark: " + mark);
            }
        }

        public static void Main(string[] args)
        {
            Student Billy = new Student();
            Billy.student_Name = "Billy Wong";
            Billy.student_ID = "BCS0001";
            Billy.identification_Card = "000930-13-8858";
            Billy.mark = 73;
            Console.WriteLine(Billy.student_Name);
            Console.WriteLine(Billy.student_ID);
            Console.WriteLine(Billy.identification_Card);
            Console.WriteLine(Billy.mark);

            Console.WriteLine();

            Student Kyle = new Student();
            Kyle.student_Name = "Kyle Ngu";
            Kyle.student_ID = "BCS0002";
            Kyle.identification_Card = "990624-13-9861";
            Kyle.mark = 68;
            Console.WriteLine(Kyle.student_Name);
            Console.WriteLine(Kyle.student_ID);
            Console.WriteLine(Kyle.identification_Card);
            Console.WriteLine(Kyle.mark);

            Console.WriteLine();

            Student Dalton = new Student();
            Dalton.student_Name = "Dalton Loh";
            Dalton.student_ID = "BCS0003";
            Dalton.identification_Card = "990201-13-7761";
            Dalton.mark = 76;
            Console.WriteLine(Dalton.student_Name);
            Console.WriteLine(Dalton.student_ID);
            Console.WriteLine(Dalton.identification_Card);
            Console.WriteLine(Dalton.mark);

            Console.WriteLine();

            Student Michael = new Student();
            Michael.student_Name = "Michael Ling";
            Michael.student_ID = "BCS0004";
            Michael.identification_Card = "981216-13-1110";
            Michael.mark = 70;
            Console.WriteLine(Michael.student_Name);
            Console.WriteLine(Michael.student_ID);
            Console.WriteLine(Michael.identification_Card);
            Console.WriteLine(Michael.mark);

            Console.WriteLine();

            Student Bryan = new Student();
            Bryan.student_Name = "Bryan Ting";
            Bryan.student_ID = "BCS0005";
            Bryan.identification_Card = "981020-13-3574";
            Bryan.mark = 80;
            Console.WriteLine(Bryan.student_Name);
            Console.WriteLine(Bryan.student_ID);
            Console.WriteLine(Bryan.identification_Card);
            Console.WriteLine(Bryan.mark);

            Console.WriteLine();

            Console.WriteLine("Student Name in ascending order:");
            List<string> lin = new List<string>();

            lin.Add(Billy.student_Name);
            lin.Add(Kyle.student_Name);
            lin.Add(Dalton.student_Name);
            lin.Add(Michael.student_Name);
            lin.Add(Bryan.student_Name);

            lin.Sort();

            foreach (string item in lin)
            {
                Console.WriteLine(item.ToString() + "\n");
            }

            Console.WriteLine("Mark in descending order:");
            List<decimal> lid = new List<decimal>();

            lid.Add(Billy.mark);
            lid.Add(Kyle.mark);
            lid.Add(Dalton.mark);
            lid.Add(Michael.mark);
            lid.Add(Bryan.mark);

            lid.Sort();

            foreach (decimal item in lid)
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            Console.ReadKey();
        }
    }
}
