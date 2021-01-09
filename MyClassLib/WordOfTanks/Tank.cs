using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        //Имя танка
        public string TankName { get; set; }

        //Уровень боекомплекта
        public int AmmunitionLevel { get; set; }

        //Уровня брони
        public int ArmorLevel { get; set; }

        //Уровня маневренности
        public int AgilityLevel { get; set; }

        private const int minValue = 0;
        private const int maxValue = 100;

        //Перечисление превосходство
        //Необходимо чтобы понять кто "превосходит" соперника

        public Tank(string tankName)
        {
            Random random = new Random();
            TankName = tankName;
            AmmunitionLevel = random.Next(minValue, maxValue);
            ArmorLevel = random.Next(minValue, maxValue);
            AgilityLevel = random.Next(minValue, maxValue);
        }

        public static ActionsClass.Advantage operator *(Tank firstTank, Tank secondTank)
        {
            int firstCount = new int(), secondCount = new int();

            ActionsClass.Advantage Ammunition = ActionsClass.Comparison(firstTank.AmmunitionLevel, secondTank.AmmunitionLevel);
            ActionsClass.Advantage Armor = ActionsClass.Comparison(firstTank.ArmorLevel, secondTank.ArmorLevel);
            ActionsClass.Advantage Agility = ActionsClass.Comparison(firstTank.AgilityLevel, secondTank.AgilityLevel);

            ActionsClass.ScoringPoints(Ammunition, ref firstCount, ref secondCount);
            ActionsClass.ScoringPoints(Armor, ref firstCount, ref secondCount);
            ActionsClass.ScoringPoints(Agility, ref firstCount, ref secondCount);

            return ActionsClass.WinnerСalculation(firstCount, secondCount);
        }
    }
}
