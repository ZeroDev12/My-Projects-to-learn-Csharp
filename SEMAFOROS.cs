using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SEMAFOROS
    {
        static void Main(string[] args)
        {
            /*Cross the street
            Situation: we are about to cross the crosswalk
            we have a traffic light in front of us
            steps to cross the street

            1: look at the traffic light
            2: if it's red, don't cross
            3: if it's green, look right and left
            4: if cars are still passing, don't cross
            5: if there are no cars passing by, cross
            
            */

            int trafficlightGreenRed;
            int cars = 20;

            

            Console.WriteLine("Situation: You are about to cross the crosswalk.");
            Console.WriteLine("But, there are a lot of cars passing by. There's a traffic light in front of you.");
            Console.WriteLine("what color is the traffic light now?");

            trafficlightGreenRed = Convert.ToInt32(Console.ReadLine());

            if (trafficlightGreenRed == 1)//red
            {
                Console.WriteLine("Red, and there are cars passing even faster in front of you, you decide not to cross");
            }
            else
            {
                Console.WriteLine("No more speeding cars passing by, the traffic light is still green, you cross, and you arrive on the other side, you are safe");
            }
            Console.ReadKey();
            Console.Beep();
            
        }
    }
}
