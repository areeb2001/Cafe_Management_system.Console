using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bill = new string[10];
            int count = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your order!");
                Console.WriteLine("press 1 for Hot Coffee");
                Console.WriteLine("press 2 for Cold Coffee");
                Console.WriteLine("press 3 for Tea");
                Console.WriteLine("press 4 for Shake");
                Console.WriteLine("press 5 for Muffins");
                Console.WriteLine("press 6 for Sandwich");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    bill[count] = Hotcoffee();
                    count++;
                    Console.WriteLine("Do you want to buy more 1 for yes and 0 for no");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        flag = false;
                    }

                }
                else if (c == 2)
                {
                    bill[count] = Coldcoffee();
                    count++;
                    Console.WriteLine("Do you want to buy more 1 for yes and 0 for no");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        flag = false;
                    }

                }
                else if (c == 3)
                {
                    bill[count] = tea();
                    count++;
                    Console.WriteLine("Do you want to buy more 1 for yes and 0 for no");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        flag = false;
                    }
                }
                else if (c == 4)
                {
                    bill[count] = shake();
                    count++;
                    Console.WriteLine("Do you want to buy more 1 for yes and 0 for no");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        flag = false;
                    }
                }
                else if (c == 5)
                {
                    bill[count] = muffins();
                    count++;
                    Console.WriteLine("Do you want to buy more 1 for yes and 0 for no");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        flag = false;
                    }
                }
                else if (c == 6)
                {
                    bill[count] = sandwich();
                    count++;
                    Console.WriteLine("Do you want to buy more 1 for yes and 0 for no");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Your bill is below : ");
            for (int i = 0; i < bill.Length; i++)
            {
                Console.WriteLine(bill[i]);
            }
            Console.ReadKey();
        }
        static string Hotcoffee()
        {

            string[] Hotcoffee = { "Expresso", "Latte", "Mocho", "Flat white" };
            for (int i = 0; i < Hotcoffee.Length; i++)
            {
                Console.WriteLine("Avaiable options are: " + Hotcoffee[i]);
            }
            int[] price = { 250, 325, 345, 320 };
            string s = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (s == Hotcoffee[i])
                {
                    Console.Write("How many you want enter quantity in integer: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Hotcoffee[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    string bill_id = Hotcoffee[i] + "  " + "x " + q.ToString() + ": " + price[i] * q;
                    return bill_id;
                }
            }
            return null;
        }
        static string Coldcoffee()
        {

            string[] Coldcoffee = { "Iced latte", "Ice mocho", "Old school cold coffee", "Iced americano" };
            for (int i = 0; i < Coldcoffee.Length; i++)
            {
                Console.WriteLine("Avaiable options are: " + Coldcoffee[i]);
            }
            int[] price = { 340, 345, 342, 285 };
            string s = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (s == Coldcoffee[i])
                {
                    Console.Write("How many you want enter quantity in integer: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Coldcoffee[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    string bill_id = Coldcoffee[i] + "  " + "x " + q.ToString() + ": " + price[i] * q;
                    return bill_id;
                }
            }
            return null;
        }
        static string tea()
        {

            string[] tea = { "Dhoodh pati", "Green tea", "Special green tea", "White tea" };
            for (int i = 0; i < tea.Length; i++)
            {
                Console.WriteLine("Avaiable options are: " + tea[i]);
            }
            int[] price = { 188, 155, 299, 165 };
            string s = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (s == tea[i])
                {
                    Console.Write("How many you want enter quantity in integer: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(tea[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    string bill_id = (tea[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    return bill_id;
                }
            }
            return null;
        }
        static string shake()
        {

            string[] shake = { "Chocolate", "Vanilla", "Chocolate peanut butter", "Strawberry" };
            for (int i = 0; i < shake.Length; i++)
            {
                Console.WriteLine("Avaiable options are: " + shake[i]);
            }
            int[] price = { 360, 340, 363, 460 };
            string s = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (s == shake[i])
                {
                    Console.Write("How many you want enter quantity in integer: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(shake[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    string bill_id = shake[i] + "  " + "x " + q.ToString() + ": " + price[i] * q;
                    return bill_id;
                }
            }
            return null;
        }
        static string muffins()
        {

            string[] muffins = { "Chocolate", "Vanilla", "Strawberry", "Blueberry" };
            for (int i = 0; i < muffins.Length; i++)
            {
                Console.WriteLine("Avaiable options are: " + muffins[i]);
            }
            int[] price = { 99, 99, 99, 99 };
            string s = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (s == muffins[i])
                {
                    Console.Write("How many you want enter quantity in integer: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(muffins[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    string bill_id = muffins[i] + "  " + "x " + q.ToString() + ": " + price[i] * q;
                    return bill_id;
                }
            }
            return null;


        }
        static string sandwich()
        {

            string[] sandwich = { "Clud sandwich", "Grilled sandwich", "Spicy sandwich", "Zinger sandwich" };
            for (int i = 0; i < sandwich.Length; i++)
            {
                Console.WriteLine("Avaiable options are: " + sandwich[i]);
            }
            int[] price = { 325, 295, 295, 350 };
            string s = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (s == sandwich[i])
                {
                    Console.Write("How many you want enter quantity in integer: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sandwich[i] + "  " + "x " + q.ToString() + ": " + price[i] * q);
                    string bill_id = sandwich[i] + "  " + "x " + q.ToString() + ": " + price[i] * q;
                    return bill_id;
                }
            }
            return null;
        }
    }
}