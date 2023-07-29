int operation = 0;
do
{
    Console.WriteLine();
    Console.WriteLine("This program will convert your amount of budget as follows:");
    Console.WriteLine("1. Korean (Won) => Gold");
    Console.WriteLine("2. Gold => Korean (Won)");
    Console.WriteLine("3. Exit");
    Console.WriteLine();
    Console.Write("Choose operation that you need: ");

    try
    {
        operation = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    catch (FormatException formatException)
    {
        Console.WriteLine("The input is not in a correct format");
    }
    catch (OverflowException overflowException)
    {
        Console.WriteLine("Value is too large or too small, take a look data type.");
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }

    const double priceGoldOneGramm = 79790.40;

    switch (operation)
    {
        case 1:
            Console.Write("Enter your budjet (Korean Won): ");
            string stringMoney = Console.ReadLine();
            double money = int.Parse(stringMoney);

            Console.WriteLine($"You can buy {money / priceGoldOneGramm} gr gold");
            break;

        case 2:
            Console.Write("Enter your budjet (Gold): ");
            string stringGold = Console.ReadLine();
            double gold = int.Parse(stringGold);

            Console.WriteLine($"You can buy {gold * priceGoldOneGramm} Won");
            break;

        case 3:
            Console.WriteLine("Thank you for using Doviz :)");
            break;

        default:
            Console.WriteLine("Entered wrong operation, try again!!!");
            break;
    }
} while (operation != 3);

