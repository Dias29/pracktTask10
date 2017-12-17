using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
                

                WriteLine("Введите имя студента: ");
                string name = ReadLine();

                WriteLine("Введите полное имя студента: ");
                string fullN = ReadLine();

                WriteLine("Поставьте оценки студету: ");
                int[] grades = new int[int.Parse(ReadLine())];
                // for(int i=0; i<)

                Student student = new Student(name, fullN, grades);
               // Clear();

                WriteLine("Имя: " + student.GetName());
                WriteLine("Полное имя: " + student.GetFullName());
                for (int i = 0; i < grades.Length; i++)
                {
                    WriteLine("Оценкa: " + grades[i]);
                }

                ReadLine();
                Clear();
            //}
        }
    }
}
