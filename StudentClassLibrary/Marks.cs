
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassLibrary
{
    public class Marks : IStudent
    {
        //int telugu, english, hindi, maths, science, social;
        public int Telugu { get; set; }
        public int English { get; set; }
        public int Hindi { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }

        public int TotalMarks { get; set; }
        public int StudentId { get; set; }
        public int Standard { get; set; }
        public string? StudentName { get; set; }
        public string? StudentAddress { get; set; }
        public char Gender { get; set; }
        public char Section { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine("Enter Student ID: ");
            StudentId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter Gender ( M or F) : ");
            Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Standard ( 1 to 10 ): ");
            Standard = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Section Like StA,B,C,D,......: ");
            Section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            StudentAddress = Console.ReadLine();
        }
        public void MarksCalculation()
        {
            Console.WriteLine("Enter Marks...\nM");
            Console.WriteLine("Enter Telugu: ");
            Telugu = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter English: ");
            English = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Hindi: ");
            Hindi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Maths: ");
            Maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Science: ");
            Science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Social Studies: ");
            Social = Convert.ToInt16(Console.ReadLine());
            TotalMarks = Telugu + Hindi + English + Maths + Science + Social;

        }
       
    }
}
