using System;

namespace Ex05
{
	class CoffeePrice
	{
		public void PrintCoffePrice()
		{
			Console.Write("What kind of coffee? ");
			String order = Console.ReadLine();
			int price = 0;
			switch(order)
			{
				case "Espresso":
				case "Cappuccino":
				case "Latte":
					price = 3500;
					break;
				case "Americano":
					price = 2000;
					break;
				default:
					Console.WriteLine("Not in the menu");
					break;
			}
			if (price != 0)
				Console.WriteLine("The price is " + price);
		}
		
	}
}
