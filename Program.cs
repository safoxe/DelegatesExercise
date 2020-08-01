using System;

namespace delegates_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes, seconds = 0;
            Console.WriteLine("Enter minutes:");
            if(Int32.TryParse(Console.ReadLine(), out minutes)) {
                Console.WriteLine("Enter seconds:");
                if(Int32.TryParse(Console.ReadLine(), out seconds)){}
            }
            var timer = new TimerModel(minutes, seconds);
        }
    }
}
