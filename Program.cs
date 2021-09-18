using System;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];
            var itemIndex = 0;   //var will be the type of what was inserted

            string userOpt = userSelectOpt();

            while (userOpt != "0")
            {
                switch (userOpt)
                {
                    case "1":
                        //TODO: insert item
                        Console.WriteLine("Insert item name:");
                        Item item = new Item();
                        item.name = Console.ReadLine();
                        Console.WriteLine("Insert item value: ");
                        if (int.TryParse(Console.ReadLine(), out int value))      //verifies if string can be parsed to
                        {

                            item.value = value;
                        }
                        else throw new ArgumentException("value must be integer!");
                        items[itemIndex] = item;
                        itemIndex++;
                        break;
                    case "2":
                        //TODO: list items
                        foreach (var i in items)
                        {
                            if (!string.IsNullOrEmpty(i.name))
                            {

                                Console.WriteLine($"Item: {i.name} - Value: {i.value}");
                            }
                        }
                        break;
                    case "3":
                        //TODO: calculate
                        var totValue = 0;
                        var totItems = 0;
                        for (int i = 0; i < items.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(items[i].name))
                            {
                            totItems++;
                            totValue = totValue + items[i].value;
                            }
                        }
                        Console.WriteLine("Total items: " + totItems);
                        Console.WriteLine("Total value: " + totValue);
                        var result = totValue/totItems;
                        Console.WriteLine($"Items average value: {result}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOpt = userSelectOpt();
            }
        }

        private static string userSelectOpt()
        {
            Console.WriteLine();
            Console.WriteLine("Select Option:");
            Console.WriteLine("1- Inser new item");
            Console.WriteLine("2- List items");
            Console.WriteLine("3- Calculate overall");
            Console.WriteLine("0-Exit");
            Console.WriteLine();

            string userOpt = Console.ReadLine();
            return userOpt;
        }
    }
}
