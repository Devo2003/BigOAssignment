using System;
namespace BigOAssignment1
{
	public class ExampleClass
	{
        
		public ExampleClass()
		{
        }

        //Method of Constant time example O(1)
        //This method gets the first item in the array just needing to do one step to get the item its being told to get
		public void ConstantEx()
		{
            int[] Num = { 1, 2, 3 };
            Console.WriteLine(Num[0]);
		}

        //Method of Linear time example O(n)
        //This method runs loops through all 3 items the array contains and prints them out 
        public void LinearEx()
        {
            Console.WriteLine("------------------");

            string[] items = { "Game", "Mouse", "Phone"};
            foreach (string item in items)
            {
                Console.WriteLine(item);
                
            }

            Console.WriteLine("------------------");
        }

        //Method of Quadratic time example O(n^2)
        //This method has a nested loop that goes through one loop then goes through the one within to print a total of 28 items meaning it creates a combination of the two arrays
        //here I just used a deck of cards as an example
        public void QuadraticEx()
        {
            string[] Suits = { "Diamonds", "Hearts", "Spades", "Clubs" };
            string[] cardNames = { "Ace", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            foreach (string cardName in  cardNames)
            {
                foreach (string suit in Suits)
                {
                    Console.WriteLine(cardName + " of " + suit);
                    Console.WriteLine("------------------");
                }
            }
        }
    }
}

