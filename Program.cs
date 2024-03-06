using System;

public class FizzBuzz
{
    private int upperLimit;

    public FizzBuzz(int upperLimit)
    {
        this.upperLimit = upperLimit;
    }

    public void PrintNumbers()
    {
        for (int i = 1; i <= upperLimit; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj górny zakres dla programu");
        int upperLimit;

        while (!int.TryParse(Console.ReadLine(), out upperLimit) || upperLimit <= 0)
        {
            Console.WriteLine("Niepoprawna wartość, podaj poprawną liczbę (całkowita, większa od 0)");
        }

        FizzBuzz fizzBuzz = new FizzBuzz(upperLimit);

        fizzBuzz.PrintNumbers();
    }
}

