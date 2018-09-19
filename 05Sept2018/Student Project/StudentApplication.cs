using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication1
{
    class StudentApplication
    {
        static int studentcount = 0;
        static int[] grade = new int[12];
        static Subjects[] sub = new Subjects[6];
        static StudentDetails[] studentList = new StudentDetails[264];
        static bool flag = true;
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Enter the Subjects-------------------");

            for (int subiterator = 0; subiterator < sub.Length; subiterator++)
            {
                Console.Write("Subject " + (subiterator + 1) + " :");
                sub[subiterator] = new Subjects();
                sub[subiterator].subject = Console.ReadLine();
                while (sub[0].subject == null || sub[0].subject == string.Empty)
                {
                    Console.Write(" Please Enter Valid Subjects :");
                    sub[subiterator].subject = Console.ReadLine();
                }
            }

            Console.WriteLine("---------------Welocme To Acuvate---------------");
            while (true)
            {
                Console.WriteLine("Press\t1.Add Student Details\n\t2.Show Students In each Grade \n\t3.Display Ranks\n\t4.Display Student With Highest Marks in each Subject\n\t5.Display Students\n\t=>Press Any key to exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        EnterDetails();
                        break;

                    case "2":
                        studentPerGrade();
                        break;

                    case "3":
                        getStudentRandPercent();
                        break;

                    case "4":
                        getHighestMarksSub();

                        break;

                    case "5":
                        printAllStudentDetails();
                        break;

                    default:
                        goto iamout;
                        
                }


            }
        iamout:

            Console.WriteLine("Thank You Visit Again!!!");
            Console.ReadKey();
        }
        static void EnterDetails()
        {

            StudentDetails s = new StudentDetails();
            Console.WriteLine("Enter Roll No:");
            s.rollNo = 0;
            bool rollcheck = int.TryParse(Console.ReadLine(), out s.rollNo);
            while (!rollcheck)
            {
                Console.WriteLine("Enter a valid roll number:");
                rollcheck = int.TryParse(Console.ReadLine(), out s.rollNo);
            }
            Console.WriteLine("Enter Grade of the Student:");

            s.Grade = 0;
            rollcheck = int.TryParse(Console.ReadLine(), out s.Grade);
            while (!rollcheck)
            {
                Console.WriteLine("Enter a valid Grade Between 1 to 12");
                rollcheck = int.TryParse(Console.ReadLine(), out s.Grade);
            }

            if (s.Grade >= 1 && s.Grade <= 12)
            {
                if (grade[s.Grade - 1] >= 22)
                {
                    Console.WriteLine("Grade" + s.Grade + " is already full Cannot add students");
                    goto endoffun;
                }
                grade[s.Grade - 1]++;
                flag = true;
                Console.WriteLine("Enter Name of the Student");
                s.name = Console.ReadLine();
              
                double total = 0;
                s.percentage = 0;
                for (int i = 0; i < 6; i++)
                {
                    s.marks[i] = 0;
                    Console.WriteLine("Enter marks for  " + sub[i].subject);
                    rollcheck = int.TryParse(Console.ReadLine(), out s.marks[i]);
                    while (!rollcheck || s.marks[i] < 0 || s.marks[i] > 100)
                    {
                        Console.WriteLine("Marks for " + sub[i].subject + " should be between 0 to 100");
                        rollcheck = int.TryParse(Console.ReadLine(), out s.marks[i]);
                    }
                    total += s.marks[i];
                }
                double per = Convert.ToDouble((total / 600) * 100);

                s.percentage = per;
            }
            else
            {
                flag = false;
            }

            int ln = studentList.Length;
            if (flag)
            {
                if (studentcount <= 264)
                {
                    studentList[studentcount] = s;
                    studentcount++;
                    if (studentcount == 0)
                    {
                        for (int higcnt = 0; higcnt < 6; higcnt++)
                        {
                            sub[higcnt].student = studentList[0];
                            sub[higcnt].HighestMarks = studentList[0].marks[higcnt];
                        }

                    }
                    else
                    {
                        for (int higcnt = 0; higcnt < 6; higcnt++)
                        {
                            if (s.marks[higcnt] > sub[higcnt].HighestMarks)
                            {
                                sub[higcnt].student = s;
                                sub[higcnt].HighestMarks = s.marks[higcnt];
                            }
                        }
                    }
                }
                Console.WriteLine("The Information Entered");
                Console.WriteLine("Grade:"+s.Grade+"\tRollNo:"+s.rollNo+"\tName:"+s.name+"\tPercentage"+s.percentage+"%");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        endoffun: { }
        }
        static void studentPerGrade()
        {
            Console.WriteLine("Students in each Grade");

            Console.WriteLine("---------------------------Student Details-------------------------------");
            Console.WriteLine("Grade\t\t Total Students");
            int ct = 1;
            foreach (int gr in grade)
            {

                Console.WriteLine(ct + "\t\t" + gr);
                ct++;
            }
        }
        static void getStudentRandPercent()
        {
            if (studentList.Length > 0)
            {
                StudentDetails sd = new StudentDetails();
                sd = null;

                for (int i = 0; i < studentList.Length - 1; i++)
                {
                    bool f = false;
                    for (int j = 0; j < studentList.Length - 1; j++)
                    {
                        if (studentList[j] != null && studentList[j + 1] != null)
                        {
                            if (studentList[j + 1].percentage > studentList[j].percentage)
                            {
                                sd = studentList[j];
                                studentList[j] = studentList[j + 1];
                                studentList[j + 1] = sd;
                                flag = true;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Rank\t\tName\t\tPercentage");
            int iterator = 1;
            foreach (StudentDetails student in studentList)
            {
                if (student != null)
                    Console.WriteLine(iterator +"\t\t"+student.name+"\t\t"+student.percentage);
                iterator++;
            }
        }
        static void getHighestMarksSub()
        {
            Console.WriteLine("------------Highest Marks Student---------------");
            Console.WriteLine("Name\t\tSubject\t\tHighest");
            for (int printer = 0; printer < sub.Length; printer++)
            {
                Console.WriteLine(sub[printer].student.name +"\t\t"+sub[printer].subject+"\t\t"+sub[printer].HighestMarks.ToString());
            }
        }
        static void printAllStudentDetails()
        {
            Console.WriteLine("----------------Print All Students--------------");
            Console.WriteLine("SNO.\tName\t percentage\tgrade");
            int counter = 1;
            foreach (StudentDetails d in studentList)
            {
                if (d != null)
                {
                    Console.WriteLine((counter++) + "\t" + d.name + "\t" + d.percentage + "\t" + d.Grade);
                }
            }
        }
    }
}
