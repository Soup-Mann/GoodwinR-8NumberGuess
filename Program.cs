Console.Clear();
string userInput;
bool isConverted = true;
bool isNumber;
long validNum = 0;
long numone;
Random rndNum = new Random();
string fullstop = "";

while (fullstop != "no")
{

    while (isConverted)
    {

        int num = rndNum.Next(0, 11);
        Console.WriteLine("Please Input a Number!");
        Console.WriteLine("");
        userInput = Console.ReadLine();
        isNumber = Int64.TryParse(userInput, out numone);

        Console.WriteLine(isNumber);

        Console.WriteLine("");

        while (numone != num)
        {
            isConverted = false;
            if (isNumber == true)
            {

                if (numone > num)
                {
                    Console.WriteLine("You guessed to high, please try again!");
                    Console.WriteLine("Please Input a Number!");
                    Console.WriteLine("");
                    userInput = Console.ReadLine();
                    isNumber = Int64.TryParse(userInput, out numone);
                    Console.WriteLine(isNumber);

                }
                else if (numone < num)
                {
                    Console.WriteLine("You guessed to low, please try again!");
                    Console.WriteLine("Please Input a Number!");
                    Console.WriteLine("");
                    userInput = Console.ReadLine();
                    isNumber = Int64.TryParse(userInput, out numone);
                    Console.WriteLine(isNumber);
                }
                else
                {

                    numone = num;

                }
            }
            else
            {
                Console.WriteLine("Invalid entry, please try again");
                isNumber = true;
            }

        }

          
    }

      Console.WriteLine("");
            Console.WriteLine("Congrats you guessed correctly!!");
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("--------------");
            Console.WriteLine("Run again?");
            Console.WriteLine("Type 'yes' or 'no'");
            fullstop = Console.ReadLine();
            isConverted = true;
}