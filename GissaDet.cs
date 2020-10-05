using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_2
{
    class GissaDet
    {
        public static Random rand = new Random();
        public static int selectedNumber = rand.Next(0,51);
        public static int choiceOfUser;
        public static int count;

        public static List<int> choiceOfUserList = new List<int>();


        public static void Main(string[] args)
        {


        Console.WriteLine("Gillar du gissa-talet-spel? \n Gissa ett tal mellan 0 och 50!");

            do
            {
                try
                {
                    choiceOfUser = Convert.ToInt32(Console.ReadLine());
                    if (choiceOfUser > 50)
                        throw new IndexOutOfRangeException();
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Skriv talet på rätt sätt \t{e.Message}");
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine($"Talet måste vara mellan 0 och 50 \t{e.Message}");
                }
                GuessingProcess(choiceOfUser);

                choiceOfUserList.Add(choiceOfUser);

                count++;


            } while (choiceOfUser != selectedNumber);

            Console.ReadKey();

        }


        public static void GuessingProcess(int choiceOfUser)
        {


            if (choiceOfUser > selectedNumber)
                {
                    Console.WriteLine("numret var större än det hemliga numret... Försok igen!");
                }
                else if (choiceOfUser<selectedNumber)
                {
                    Console.WriteLine("numret var mindre än det hemliga numret... Försok igen!");
                }
                else
                {
                    Console.WriteLine("Yuhuuuu!! Du vann!");
                Console.WriteLine($"Det hemliga nummret var {selectedNumber}");
                    Console.WriteLine($"Du försökte {count+1} gånger");


                foreach (int number in choiceOfUserList)
                        {                    

                        Console.WriteLine($"Du gissade: {number}");
                        }
            }


        }

    }
}
