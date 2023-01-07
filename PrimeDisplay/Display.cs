namespace PrimeDisplay;

public class Display
{
    // Parameter 1: enter the number of prime numbers you want to display
    // Parameter 2: define if you want to see other numbers too, or not
    public void Primes(int nrOfPrimes, bool showNotPrime)
    {
        int primes = 0;
        int index = 2;
        // As long as the number of wished prime amount is reached, the loop goes on.
        while (primes != nrOfPrimes)
        {
            // Defining division limit.
            int middle = index / 2;

            // Looking for primes.
            // As long as the current number doesn't get a flag, it is a prime.
            // If the flag is placed, it is not prime and will displayed as white,
            // if the showNotPrime variable is set to true.
            int flag = 0;
            for (int i = 2; i <= middle; i++)
            {
                if (index % i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    if (showNotPrime)
                    {
                        Console.Write($"{index} ");
                    }

                    flag = 1;
                    break;
                }
            }

            // If the number is prime (does not have a flag) it will be displayed in red color.
            if (flag == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{index} ");
                primes++;
            }

            // Increment current position.
            index++;
        }

        Console.ReadKey(true);
    }
}