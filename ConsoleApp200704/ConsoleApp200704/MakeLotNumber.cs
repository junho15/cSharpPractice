using System;

namespace ConsoleApp200704
{
    class MakeLotNumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var LotArray = new int[6];
            for (int index = 0; index < LotArray.Length; index++)
            {
                LotArray[index] = random.Next(45) + 1;

                for (int CheckIndex = index - 1; CheckIndex >= 0; CheckIndex--)
                {
                    if (LotArray[index] == LotArray[CheckIndex])
                    {
                        index--;
                        break;
                    }
                }
            }

            for (int index = 0; index < LotArray.Length; index++)
            {
                Console.WriteLine($"{index + 1} : {LotArray[index]}");
            }
        }
    }
}
