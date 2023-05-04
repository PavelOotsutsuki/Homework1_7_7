using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace Homework1_7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers1 = new List<Soldier>
            {
                new Soldier("Богданов Богда Богданович", 20),
                new Soldier("Сидоров Сидр Сидорович", 16),
                new Soldier("Петров Петр Петрович", 30),
                new Soldier("Борисов Борис Борисович", 100),
                new Soldier("Павлов Павел Павлович", 96),
                new Soldier("Матвеев Тимофей Матвеевич", 42)
            };

            List<Soldier> soldiers2 = new List<Soldier>
            {
                new Soldier("Иванов Иван Иванович", 40),
                new Soldier("Иноземцев Иноземец Иноземцевич", 5)
            };

            Console.WriteLine("ДО:");
            Console.WriteLine("1-я бригада: ");
            ShowSoldiers(soldiers1);
            Console.WriteLine("2-я бригада:");
            ShowSoldiers(soldiers2);
            Console.WriteLine(new string('-', 20));
            var reassignmentsSoldiers = soldiers1.Where(soldier => soldier.Name.ToUpper().StartsWith('Б')).ToList();
            soldiers2 = soldiers2.Concat(reassignmentsSoldiers).ToList();
            soldiers1 = soldiers1.Except(reassignmentsSoldiers).ToList();
            Console.WriteLine("ПОСЛЕ:");
            Console.WriteLine("1-я бригада: ");
            ShowSoldiers(soldiers1);
            Console.WriteLine("2-я бригада:");
            ShowSoldiers(soldiers2);
        }

        static void ShowSoldiers(List<Soldier> soldiers)
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Name);
            }
        }
    }

    class Soldier
    {
        public Soldier(string name, int termOfServiceMonth)
        {
            Name = name;
            TermOfServiceMonth = termOfServiceMonth;
        }

        public string Name { get; private set; }
        public int TermOfServiceMonth { get; private set; }
    }
}