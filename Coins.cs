using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_S
{
    public static class Coin_Amount
    {
        public const float Nickel = 0.05f;
        public const float Dime = 0.10f;
        public const float Quarter = 0.25f;
        public const float Pennie = 0.01f;

        public static void displayoptions()
        {
            Console.WriteLine(" 1 : Nickel   - 1/20 $");
            Console.WriteLine(" 2 : Dime     - 1/10 $ ");
            Console.WriteLine(" 3 : Quarter  - 1/4 $ ");
            Console.WriteLine(" 4 : pennie   - 1/100 $ ");
        }
        public static bool isvalidCoin(int InputOption)
        {
            if (InputOption >= 1 && InputOption <= 3)
                return true;
            else return false;
        }
        public static float GetInsertedAmount(int InputOption)
        {
            switch (InputOption)
            {
                case 1: return Nickel;
                case 2: return Dime;
                case 3: return Quarter;
                case 4: return Pennie;
                default: return 0.0f;
            }
        }
    }
    class Coins
    {
        float TotalAmount;
        float RejectedAmount;

        public Coins()
        {
            TotalAmount = 0.0f;
            RejectedAmount = 0.0f;
        }
        public float AddCoin(int Input)
        {
            float amount = Coin_Amount.GetInsertedAmount(Input);
            if (Coin_Amount.isvalidCoin(Input) == true)
                TotalAmount += amount;
            else
                RejectedAmount += amount;

            return TotalAmount;
        }

        public void DisplayAmounts()
        {
            Console.WriteLine("Total Amount ${0:0.00}  :  Rejected Amount ${1:0.00} \n", TotalAmount, RejectedAmount);
        }
        public float getValidAmount()
        {
            return TotalAmount;
        }
        public void ClearAmount()
        {
            TotalAmount = 0.0f;
            RejectedAmount = 0.0f;
        }
    }
}
