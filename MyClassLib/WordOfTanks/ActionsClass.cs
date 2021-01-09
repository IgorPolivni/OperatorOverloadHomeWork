using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WordOfTanks
{
    public class ActionsClass
    {
        private const int winPoints = 2;

        public enum Advantage
        {
            FirstOneWon = 1,    //Первый победил
            Nobody = 0,        //Ничья
            SecondOneWon = -1   //Второй победил
        }

        public static void CreateTanks(ref Tank[] tanks, int tanksNumber,string tankName)
        {
            if(tanks == null)
                throw new ArgumentNullException();
            else
            {
                for (int i = 0; i < tanksNumber; i++)
                    tanks[i] = new Tank(tankName);
            }
        }

        public static Advantage Battle(Tank[] firstGroup, Tank[] secondGroup, int tanksNumber)
        {
            int FirstGroupVictories = new int();
            int SecondGroupVictories = new int();
            for (int i = 0; i < tanksNumber; i++)
            {
                Menu.PrintRaundNumber(i);
                //Вывод информации о танках
                Menu.PrintTankInfo(firstGroup[i]);
                Menu.PrintTankInfo(secondGroup[i]);

                if (firstGroup[i] * secondGroup[i] == Advantage.FirstOneWon)
                {
                    Menu.PrintWinner(firstGroup[i]);
                    FirstGroupVictories++;
                }
                else if (firstGroup[i] * secondGroup[i] == Advantage.SecondOneWon)
                {
                    Menu.PrintWinner(secondGroup[i]);
                    SecondGroupVictories++;
                }
                else if (firstGroup[i] * secondGroup[i] == Advantage.Nobody)
                {
                    Menu.PrintDraw();//Ничья
                }

            }

            return Comparison(FirstGroupVictories, SecondGroupVictories);
        }

        //Сравнение
        public static Advantage Comparison(int firstNum, int secondNum)
        {
            if (firstNum > secondNum) return Advantage.FirstOneWon;
            else if (firstNum < secondNum) return Advantage.SecondOneWon;
            else return Advantage.Nobody;
        }

        public static Advantage WinnerСalculation(int firstCount, int secondCount)
        {
            if (firstCount >= winPoints) return Advantage.FirstOneWon;
            else if (secondCount >= winPoints) return Advantage.SecondOneWon;
            else return Advantage.Nobody;
        }

        //Подсчет баллов
        public static void ScoringPoints(Advantage value, ref int firstCount, ref int secondCount)
        {
            if (value == Advantage.FirstOneWon) firstCount++;
            else if (value == Advantage.SecondOneWon) secondCount++;
        }

        public static void BattleResults(Advantage winnerGroup, string firstTankName, string secondTankName)
        {
            if (winnerGroup == Advantage.FirstOneWon)
                Menu.PrintBattleResults(firstTankName);
            else if (winnerGroup == Advantage.SecondOneWon)
                Menu.PrintBattleResults(secondTankName);
            else if (winnerGroup == Advantage.Nobody)
                Menu.PrintDraw();//Ничья
        }
    }
}
