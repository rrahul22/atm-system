using System;

namespace SkillTest
{
    class ATMSystem
    {
        static void Main(string[] args)
        {
            int amount, fiveHundred, hundred, fifty, ten, five;
            int result = 0;
            fiveHundred = hundred = fifty = ten = five = 0;

            Console.Write("Enter Amount : ");
            string input = Console.ReadLine();
            if (!Int32.TryParse(input, out result))
            {
                Console.WriteLine("Invalid Amount");
                Console.ReadLine();
                return;
            }

            amount = Convert.ToInt32(input);

            if ((amount % 5) == 0)
            {
                while (amount > 0)
                {
                    if (amount >= 500)
                    {
                        fiveHundred = Convert.ToInt32(amount / 500);
                        amount -= (fiveHundred * 500);
                    }
                    else if (amount >= 100)
                    {
                        hundred = Convert.ToInt32(amount / 100);
                        amount -= (hundred * 100);
                    }
                    else if (amount >= 50)
                    {
                        fifty = Convert.ToInt32(amount / 50);
                        amount -= (fifty * 50);
                    }
                    else if (amount >= 10)
                    {
                        ten = Convert.ToInt32(amount / 10);
                        amount -= (ten * 10);
                    }
                    else if (amount >= 5)
                    {
                        five = Convert.ToInt32(amount / 5);
                        amount -= (five * 5);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }

            if (fiveHundred > 0) Console.WriteLine("500 * {0}", fiveHundred);
            if (hundred > 0) Console.WriteLine("100 * {0}", hundred);
            if (fifty > 0) Console.WriteLine("50 * {0}", fifty);
            if (ten > 0) Console.WriteLine("10 * {0}", ten);
            if (five > 0) Console.WriteLine("5 * {0}", five);

            Console.ReadLine();
        }
    }
}
