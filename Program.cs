using System;

namespace delegates_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            int seconds = 0;
            Console.WriteLine("Enter seconds:");
            if(Int32.TryParse(Console.ReadLine(), out seconds)) {}

            Console.WriteLine("Enter a message to transmit:");
            var timer = new TimerModel(seconds, Console.ReadLine());
            var timerObserver = new TimerObserver(timer);
            timerObserver.SubscribeToTimerEvents();

            Console.WriteLine("Timer count down: ");
            timer.StartCountDown();
        }
    }

/// <summary>
/// Class that transmits timer data to the console
/// </summary>
    public class TimerObserver {
        private TimerModel timer;
        public TimerObserver(TimerModel timer)
        {
            this.timer = timer;
        }

        public void SubscribeToTimerEvents()
        {
            timer.TimerElapsed += (sender, obj) => { Console.Write("\n" + obj.MessageFromTimer); };
            timer.TimerChanged += (sender, obj) => { Console.Write($"\r{ obj.TimerCurrentTimer }  "); };
        }
    }
}
