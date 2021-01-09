using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WordOfTanks
{
    public class Menu
    {
        public static void PrintTankInfo(Tank tank)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Название танка:        | {tank.TankName}"); 
            Console.WriteLine($"Уровень боекомплекта:  | {tank.AmmunitionLevel}"); 
            Console.WriteLine($"Уровень брони:         | {tank.ArmorLevel}"); 
            Console.WriteLine($"Уровень маневренности: | {tank.AgilityLevel}");
            Console.WriteLine("---------------------------------");
        }

        public static void PrintRaundNumber(int roundNumber)
        {
            Console.WriteLine($"\n\n------------РАУНД №{roundNumber + 1}-------------");
        }

        public static void PrintWinner(Tank tank)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Выиграл танк {tank.TankName}!");
        }

        //Ничья
        public static void PrintDraw()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"          НИЧЬЯ!!!");
        }

        public static void PrintBattleResults(string tankName)
        {
            Console.WriteLine("\n\n---------------------------------");
            Console.WriteLine("----------ИТОГИ СРАЖЕНИЯ---------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"  ВЫИГРАЛА группа танка {tankName}!");
            Console.WriteLine("---------------------------------");
        }
    }
}
