using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_S
{
    class Product
    {
        int SelectedProduct;

        public Product()
        {
            SelectedProduct = -1;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Available Products : ");
        }
        public virtual float Amount()
        {
            return 0.0f;
        }
        public int GetProduct()
        {
            return SelectedProduct;
        }
        public virtual bool DispatchProduct(float Amt)
        {
            return false;
        }
        public bool IsValidProduct(int Input)
        {
            if (Input >= 1 && Input <= 3)
            {
                SelectedProduct = Input;
                return true;
            }
            else
            {
                SelectedProduct = 0;
                return false;
            }
        }
    }

    class Cola : Product
    {
        public override void DisplayDetails()
        {
            Console.WriteLine(" 1 : Cola   : ${0:0.00}", Amount());
        }
        public override float Amount()
        {
            return 1.0f;
        }
        public override bool DispatchProduct(float Amt)
        {
            if (Amt >= Amount())
            {
                Console.WriteLine("Product Dispatched. Thank You..  :  Balance Amount ${0:0.00} ", Amt - Amount());
                return true;
            }
            else return false;
        }
    }

    class Chips : Product
    {
        public override void DisplayDetails()
        {
            Console.WriteLine(" 2 : Chips  : ${0:0.00}", Amount());
        }
        public override float Amount()
        {
            return 0.50f;
        }
        public override bool DispatchProduct(float Amt)
        {
            if (Amt >= Amount())
            {
                Console.WriteLine("Product Dispatched. Thank You..  :  Balance Amount ${0:0.00} ", Amt - Amount());
                return true;
            }
            else return false;
        }
    }

    class Candy : Product
    {
        public override void DisplayDetails()
        {
            Console.WriteLine(" 3 : Candy  : ${0:0.00} \n", Amount());
        }
        public override float Amount()
        {
            return 0.65f;
        }
        public override bool DispatchProduct(float Amt)
        {
            if (Amt >= Amount())
            {
                Console.WriteLine("Product Dispatched. Thank You..  :  Balance Amount ${0:0.00} ", Amt - Amount());
                return true;
            }
            else return false;
        }
    }
}
