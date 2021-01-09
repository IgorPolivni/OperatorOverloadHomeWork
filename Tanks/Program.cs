using System;
using MyClassLib.WordOfTanks;

namespace Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tanksNumber = 5;
            const string firstTankName = "Т-34";
            const string secondTankName = "Pantera";

            Tank[] firstGroup = new Tank[tanksNumber];
            Tank[] secondGroup = new Tank[tanksNumber];

            try
            {
                ////Вызов исключения - Раскоменитуйте для проверки
                //firstGroup = null;

                ActionsClass.CreateTanks(ref firstGroup, tanksNumber, firstTankName);
                ActionsClass.CreateTanks(ref secondGroup, tanksNumber, secondTankName);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }

            ActionsClass.Advantage winner = ActionsClass.Battle(firstGroup, secondGroup, tanksNumber);

            ActionsClass.BattleResults(winner, firstTankName, secondTankName);

        }
    }
}
