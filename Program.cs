Console.WriteLine("If you want to buy gold, this app can convert your money to gold.");

Console.Write("Enter your budjet (Korean Won): ");
double money = double.Parse(Console.ReadLine());
const double priceGoldOneGramm = 79790.40; 

Console.WriteLine($"You can buy {money / priceGoldOneGramm} gr gold");
