using System;
using System.Collections.Generic;
namespace Assignment_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfProducts = new List<Products>();
            listOfProducts.Add(new Products() 
            { 
                name = "lettuce", 
                price = 10.5f, 
                quantity = 50,
                type = "Leafy green" 
            }
            );
            listOfProducts.Add(new Products() { name = "cabbage", price = 20f, quantity = 100, type = "Cruciferous" });
            listOfProducts.Add(new Products() { name = "pumpkin", price = 30f, quantity = 30, type = "Marrow" });
            listOfProducts.Add(new Products() { name = "cauliflower", price = 10f, quantity = 25, type = "Cruciferous" });
            listOfProducts.Add(new Products() { name = "zucchini", price = 20.5f, quantity = 50, type = "Marrow" });
            listOfProducts.Add(new Products() { name = "yam", price = 30f, quantity = 50, type = "Root" });
            listOfProducts.Add(new Products() { name = "spinach", price = 10f, quantity = 100, type = "Leafy green" });
            listOfProducts.Add(new Products() { name = "broccoli", price = 20.2f, quantity = 75, type = "Cruciferous" });
            listOfProducts.Add(new Products() { name = "garlic", price = 30f, quantity = 20, type = "Leafy green" });
            listOfProducts.Add(new Products() { name = "silverbeet", price = 10f, quantity = 50, type = "Marrow" });
            //Initializing objects and insert values in list.....>
            Console.WriteLine("Total products = " + listOfProducts.Count);
            Console.WriteLine();
            //Adding potato in the list
            listOfProducts.Add(new Products() { name = "Potato", price = 10f, quantity = 50, type = "Root" });

            foreach (var a in listOfProducts)
            {
                Console.WriteLine($"Name = {a.name}         Price = {a.price} Rs      Quantity = {a.quantity}       Type = {a.type}");
            }
            //Print all values

            Console.WriteLine();
            Console.WriteLine($"Total Products = {listOfProducts.Count}");
            Console.WriteLine();

            foreach (var b in listOfProducts)//printing product with type leafygrean
            {
                if (b.type.Equals("Leafy green"))
                {
                    Console.WriteLine($"Name = {b.name}      Price = {b.price} Rs        Quantity = {b.quantity}        Type = {b.type}");
                }
            }

            Console.WriteLine();

            listOfProducts.RemoveAt(8);//Garlic is at place 8....after removing it

            Console.WriteLine("Total Products =" + listOfProducts.Count);
            Console.WriteLine();//prnting new values

            Console.WriteLine("Add cabbages : ");
            var cabbage = int.Parse(Console.ReadLine());

            listOfProducts[1].quantity += cabbage;//Adding any nummber of cabbage in the inventory and printing it
            Console.WriteLine();
            Console.WriteLine("Total Cabbages : " + listOfProducts[1].quantity);
            Console.WriteLine();
            //If user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli the what is the round figure that user need to pay?
            //Buying of products is dynamic, loop will execute untill user exits by pressing 0
            float sum = 0; bool t_f = true;
            while (t_f)
            {
                Console.WriteLine("Enter number of item you want to Buy :");
                int i = 1;
                foreach (var c in listOfProducts)
                {
                    Console.WriteLine("  " + i + " " + c.name + " " + c.price + "Rs/kg");//will give list of items and amount 
                    i++;
                }

                Console.WriteLine("  0  EXIT");
                Console.WriteLine();

            move:

                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                else if (x > listOfProducts.Count)
                {
                    Console.WriteLine("Sorry, Please enter your item no again: :");
                    goto move;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("How many kilogorams :");
                    int k = int.Parse(Console.ReadLine());
                    sum += (listOfProducts[x - 1].price * k);
                    Console.WriteLine();
                }

            }
            Console.WriteLine("You have to pay : " + Math.Round(sum));//Will print amount to be paid
        }
    }
}
