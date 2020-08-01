# DelegatesExercise
Repeating delegates topic in C# programming language

To run use: dotnet run

Used following description of the exercise from https://www.oreilly.com/library/view/learning-c-30/9780596155018/ch17s06.html:
Exercise 17-1.
Write a countdown alarm program that uses delegates to notify anyone who is interested that the designated amount of time has passed. You’ll need a class to simulate the countdown clock that accepts a message and a number of seconds to wait (supplied by the user). After waiting the appropriate amount of time, the countdown clock should call the delegate and pass the message to any registered observers. (When you’re calculating the time to wait, remember that Thread.Sleep( ) takes an argument in milliseconds, and requires a using System.Threading statement.) Create an observer class as well that echoes the received message to the console.
