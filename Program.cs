using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Лаба5_11 {
    internal class Program {
        static void Main(string[] args) {
            Controller logic = new Controller();
            Console.Write("Введите стаж работы:");
            int experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nРаботники с указанным стажем работы:\n");
            foreach(Worker worker in logic.getListEmployeeWithExperience(experience))
                Console.WriteLine(worker.ToString());

            Console.Write("Введите зарплату:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nРаботники с указанной зарплатой:\n");
            foreach (Worker worker in logic.getListEmployeeWithSalary(salary))
                Console.WriteLine(worker.ToString());

            Console.Write("Введите должность:");
            string jobTitle = Console.ReadLine();
            Console.WriteLine("\nРаботники с указанной должностью:\n");
            foreach (Worker worker in logic.getListEmployeeJobTitle(jobTitle))
                Console.WriteLine(worker.ToString());
            Console.ReadKey();
        }
    }
}
