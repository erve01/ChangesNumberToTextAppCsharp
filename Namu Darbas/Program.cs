using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_Darbas
{
    class Program
    {
        static void Main(string[] args)
        {
            int convertedUserInputAsNumber;
            int countInputChar = 0;
            Console.WriteLine("Prasome ivesti skaiciu nuo -999 iki 999");
            string userInput = Console.ReadLine();
            if (CheckIfTheInputisNumber(userInput) == true)  // Ziuri ar ivede skaiciu
            {
                convertedUserInputAsNumber = Convert.ToInt32(userInput); // useri inputa konvertuoja i skc

                if (convertedUserInputAsNumber == 0)
                {
                    Console.WriteLine("Jus ivedete nuli");
                    Console.ReadKey();
                    return;
                }
                else if (InputCharCount(countInputChar, userInput) == 1) // jeigu vienas simbolis
                {
                    if (convertedUserInputAsNumber >= -9 && convertedUserInputAsNumber < 0) // jeigu neigiamas
                    {

                        Console.WriteLine("minus " + ChangesOnesToText(userInput));
                    }
                    else  // jeigu teigiamas
                    {
                        Console.WriteLine(ChangesOnesToText(userInput));
                    }
                }
                else if (InputCharCount(countInputChar, userInput) > 1 && InputCharCount(countInputChar, userInput) == 2) // jeigu du simboliai
                {
                    if (convertedUserInputAsNumber < -9 && convertedUserInputAsNumber >= -99)  // jeigu du simboliai neigiamas
                    {
                        userInput = userInput.Substring(1);
                        Console.WriteLine("minus " + ChangesTensToText(userInput));
                    }
                    else // jeigu daugiau nei vienas simbolis ir teigiamas
                    {
                        Console.WriteLine(ChangesTensToText(userInput));
                    }
                }
                else if (InputCharCount(countInputChar, userInput) > 2 && InputCharCount(countInputChar, userInput) == 3)
                {
                    if (convertedUserInputAsNumber < -99 && convertedUserInputAsNumber >= -999)  // jeigu trys simboliai neigiamas
                    {
                        userInput = userInput.Substring(1);
                        Console.WriteLine("minus " + ChangesHundredsToText(userInput));
                    }
                    else // jeigu daugiau nei vienas simbolis ir teigiamas
                    {
                        Console.WriteLine(ChangesHundredsToText(userInput));
                    }
                }
                else
                {
                    Console.WriteLine("Skaicius didesnis nei 999");
                }


            }
            else
            {
                Console.WriteLine("Jus ivedete ne skaiciu, programa issijunks");
                Console.ReadKey();
                return;
            }

            Console.ReadLine();
        }

        static string ChangesHundredsToText(string userInput)
        {
            string name = ChangesOnesToText(userInput.Substring(0, 1)) + " simtai " + ChangesTensToText(userInput.Substring(1, 2) + "0") + " " + ChangesOnesToText(userInput.Substring(2));
            return name;
        }
        static string ChangesTensToText(string userInput)
        {
            string name = null;
            int userInputAsNumber = Convert.ToInt32(userInput);
            if (userInputAsNumber >= -9 && userInputAsNumber < 0)
            {
                userInputAsNumber = userInputAsNumber * -1;

            }
            switch (userInputAsNumber)
            {
                case 10:
                    name = "desimt";
                    break;
                case 11:
                    name = "vienuolika";
                    break;
                case 12:
                    name = "dvylika";
                    break;
                case 13:
                    name = "trylika";
                    break;
                case 14:
                    name = "keturiolika";
                    break;
                case 15:
                    name = "penkiolika";
                    break;
                case 16:
                    name = "sesiolika";
                    break;
                case 17:
                    name = "septyniolika";
                    break;
                case 18:
                    name = "astuoniolika";
                    break;
                case 19:
                    name = "devyniolika";
                    break;
                case 20:
                    name = "dvidesimt";
                    break;
                case 30:
                    name = "trisdesimt";
                    break;
                case 40:
                    name = "keturiasdesimt";
                    break;
                case 50:
                    name = "penkiasdesimt";
                    break;
                case 60:
                    name = "sešiasdesimt";
                    break;
                case 70:
                    name = "septyniasdesimt";
                    break;
                case 80:
                    name = "astuoniasdesimt";
                    break;
                case 90:
                    name = "devyniasdesimt";
                    break;
                default:
                    if (userInputAsNumber > 20)
                    {
                        name = ChangesTensToText(userInput.Substring(0, 1) + "0") + " " + ChangesOnesToText(userInput.Substring(1));
                    }
                    break;


            }
            return name;
        }
        static string ChangesOnesToText(string userInput)
        {
            string name = null;
            int userInputAsNumber = Convert.ToInt32(userInput);
            if (userInputAsNumber >= -9 && userInputAsNumber < 0)
            {
                userInputAsNumber = userInputAsNumber * -1;

            }
            switch (userInputAsNumber)
            {
                case 1:
                    name = "vienas";
                    break;
                case 2:
                    name = "du";
                    break;
                case 3:
                    name = "trys";
                    break;
                case 4:
                    name = "keturi";
                    break;
                case 5:
                    name = "penki";
                    break;
                case 6:
                    name = "sesi";
                    break;
                case 7:
                    name = "septyni";
                    break;
                case 8:
                    name = "astuoni";
                    break;
                case 9:
                    name = "devyni";
                    break;
            }
            return name;
        }
        static int InputCharCount(int countInputChar, string userInput)
        {
            for (int i = 0; i < userInput.Length; i++)
            {
                char symbal = userInput[i];
                if (symbal == '-')
                {
                    continue;
                }
                else
                {
                    countInputChar += 1;
                }
            }
            return countInputChar;
        }
        static bool CheckIfTheInputisNumber(string userInput)
        {
            for (int i = 0; i < userInput.Length; i++)
            {
                char symbal = userInput[i];

                if (symbal == '-' || symbal == '0' || symbal == '1' || symbal == '2' || symbal == '3' || symbal == '4' || symbal == '5' || symbal == '6' || symbal == '7' || symbal == '8' || symbal == '9')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;

        }
    }
}
