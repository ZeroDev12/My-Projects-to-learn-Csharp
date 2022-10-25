using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_FILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a program where you have 0 keys
            //add one key and open an sigle door

            //1 write a variable, store 0
            //2 when something happen
                // solve the math question and get one key
                //write an fuction that give me an add problem, and ask for input in the result
                //if the result is right
                //get an key
                // press the number of the key and leave

                //if its not, say its not right
                //and tell him to try again

            //3 increment 1 key
            //4 then open an door

            

            

            AddProblem(5,5);
            
        }
        static void AddProblem(int x, int y)
        {
            Console.WriteLine("how much is " + x + " + " + y);
            int result = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine(result);

            if (result == 10)
            {
                Console.WriteLine("You are right, you received an key");
                int keys = 0;
                Console.WriteLine("keys before: " + keys);
                keys++;
                Console.WriteLine("keys now: " + keys);

                

                Console.WriteLine("use this key to leave by pressing 1");
                int keyExit = Convert.ToInt32(Console.ReadLine());
                

                switch (keyExit)
                {
                    case 1:
                        Console.WriteLine("\nLeaving.\n");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\ninvalid\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong");
                
            }
            
        }
    }
}
