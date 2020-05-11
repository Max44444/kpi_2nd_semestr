using System;
using Car;

namespace lab_8_OP
{
    class Program
    {
        public static void LowerCaseCount(string str)
        {
            int counter = 0; 
            foreach (var i in str)
            {
                if (char.IsUpper(i)) 
                { 
                    ++counter;
                }
            }

            Console.WriteLine(counter);
        }
        
        
        static void Main(string[] args)
        {
            Action<string> d = LowerCaseCount;
            var str = "iweorjfg4QWEF G3w4g@# $G?@#5w4% WG$43";
            d.Invoke(str);

            var bmw = new SimpleCar("BMW", 220, 10, 80);
            bmw.OverSpeed += Warning;
            bmw.StartOfMovement();

            for (int i = 0; i < 100; i++)
            {
                bmw.Movement(Convert.ToUInt32((new Random()).Next(50, 100)));
                System.Threading.Thread.Sleep(100);
            }
            
            bmw.Stop();
            Console.WriteLine(bmw.FuelLevel);
        }

        
        private static void Warning(object sender, EventArgs e)
        {
            if (sender is SimpleCar)
            {
                Console.WriteLine("You have exceeded the speed, please drive slower");
            }
        }
    }
}