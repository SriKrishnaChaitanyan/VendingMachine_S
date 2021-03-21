using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_S
{
    class Program
    {
        static void Main(string[] args)
        {
            int InputProduct, InputAmount;
            Coins objCoins = new Coins();
            Cola objCola = new Cola();
            Chips objChips = new Chips();
            Candy objCandy = new Candy();
            bool bSelectProduct = false;
            Product objProduct = new Product();
            while (true)
            {
                if (bSelectProduct == false)
                {
                    Console.Clear();
                    objCoins.DisplayAmounts();
                    Console.WriteLine("---------------------------");
                    Coin_Amount.displayoptions();
                    Console.WriteLine(" 0 : To Choose a Product \n");
                    Console.WriteLine("Insert Coins :");
                    try
                    {
                        InputAmount = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        InputAmount = -1;
                    }
                    if (InputAmount != -1)
                        objCoins.AddCoin(InputAmount);

                    if (InputAmount == 0)
                        bSelectProduct = true;
                }
                else
                {
                    Console.Clear();
                    if (objProduct.GetProduct() != -1)
                        Console.WriteLine("Choose a Valid Product.");
                    objProduct = objCola;
                    objProduct.DisplayDetails();
                    objProduct = objChips;
                    objProduct.DisplayDetails();
                    objProduct = objCandy;
                    objProduct.DisplayDetails();
                    Console.WriteLine("Choose a Product :");
                    try
                    {
                        InputProduct = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        InputProduct = -1;
                    }
                    if (InputProduct != -1)
                    {
                        if (objProduct.IsValidProduct(InputProduct) == true)
                        {
                            switch (objProduct.GetProduct())
                            {
                                case 1:
                                    objProduct = objCola;
                                    break;
                                case 2:
                                    objProduct = objChips;
                                    break;
                                case 3:
                                    objProduct = objCandy;
                                    break;
                            }

                            if (objProduct.DispatchProduct(objCoins.getValidAmount()) == false)
                                Console.WriteLine("Insufficient Amount. Clearing Data..");
                            bSelectProduct = false;
                            objCoins.ClearAmount();
                            Console.ReadLine();
                        }
                    }

                }
            }
        }
    }
}
