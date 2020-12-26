using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_09.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter("lr11_output.txt");
            Console.SetOut(new_out);
#endif
            List<Person> all = new List<Person>();

            try
            {
                string line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(Person.Create(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\t\t========\n\t\tЗадача 1\n\t\t========");

            // Часть 1
            float min_salary = (from p in all
                                select p.Salary).Min();
            Person man_with_min_salary = (from p in all
                                          where (p.Salary == min_salary)
                                          select p).First();
            Console.WriteLine("\n" + man_with_min_salary + "\n");

            // Часть 2
            Person man_with_min_salary_without_tax = new Person();
            float min_salary_without_tax = all[0].Salary - all[0].Tax;
            for (int i = 1; i < all.Count; i++)
            {
                if ((all[i].Salary - all[i].Tax) < min_salary_without_tax)
                {
                    min_salary_without_tax = all[i].Salary - all[i].Tax;
                    man_with_min_salary_without_tax = all[i];
                }  
            }
            Console.WriteLine(man_with_min_salary_without_tax);

            Console.WriteLine("\n\t\t========\n\t\tЗадача 2\n\t\t========");
            int without_skill = 0;
            for (int i = 0; i < all.Count; i++)
            {
                if (all[i].Skill == "")
                    without_skill++;
            }
            Console.WriteLine("\nОтвет: " + without_skill);

            Console.WriteLine("\n\t\t========\n\t\tЗадача 3\n\t\t========");
            int with_email = 0, no_email = 0;
            float average_salary_with_email = 0, average_salary_no_email = 0;
            for (int i = 0; i < all.Count; i++)
            {
                if (all[i].Email != "")
                {
                    with_email++;
                    average_salary_with_email += all[i].Salary;
                }
                else
                {
                    no_email++;
                    average_salary_no_email += all[i].Salary;
                }
            }
            Console.WriteLine("\nСредняя з/п для сотрудников с Email: " + average_salary_with_email / with_email);
            Console.WriteLine("\nСредняя з/п для сотрудников без Email: " + average_salary_no_email / no_email);

            Console.WriteLine("\n\t\t========\n\t\tЗадача 4\n\t\t========");
            float sum_tax = 0;
            for (int i = 0; i < all.Count; i++)
            {
                sum_tax += all[i].Tax;
            }
            Console.WriteLine("\nОбщая сумма налога: " + sum_tax);
#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}