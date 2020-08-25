using System;

namespace VariablesExercise
{
    class Program
    {
       static void Main(string[] args)
			{
				string sonName = "Odin";
				int sonAge = 6;
				double realAge = 6.5;
				char eyes = ':';
				char smile = ')';

				Console.WriteLine($"My son, {sonName}, is {sonAge} years old, though he would say he's {realAge}. {eyes}{smile}");

        }
    }
}
