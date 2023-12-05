using System.Security.Cryptography.X509Certificates;

namespace BlazorApp
{
    public class Pizza
    {
        public Topping PizzaTopping { get; set; }
        public PizzaCrust CrustPizza { get; set; }
        public Tip PizzaTip { get; set; }


        public Pizza()
        {
            PizzaTopping = new Topping();
            CrustPizza = new PizzaCrust(); 
            PizzaTip = new Tip();
        }

        public double GetToppingPrice()
        {
            double ToppingPrice = 0;
            ToppingPrice = PizzaTopping.ToppingPrice();
            return ToppingPrice;
        }

        public double GetCrustPrice()
        {
            double CrustPrice = 0;
            CrustPrice = CrustPizza.CrustPrice() + PizzaTopping.ToppingPrice();
            return CrustPrice;
        }

        public double GetFinalPrice()
        {
            double TipPrice = 0;
            double TwoPrice = 0;
            double DeliveryFee = 2;
            

            TwoPrice = CrustPizza.CrustPrice() + PizzaTopping.ToppingPrice() + DeliveryFee;

            TipPrice = TwoPrice * PizzaTip.TipPrice();

            return TipPrice;
        }
    }


    public class Topping
    {
        public bool Bacon { get; set; }
        public bool MoreBacon { get; set; }
        public bool ExtraBacon { get; set; }
        public bool Pepperoni { get; set; }
        public bool ExtraCheese { get; set; }
        public bool Ham { get; set; }
        public bool Chicken { get; set; }

        public double ToppingPrice()
        {
            double runningTotal = 0;

            if (Bacon)
            {
                runningTotal += 30;

            }
            if (MoreBacon)
            {
                runningTotal += 40;

            }
            if (ExtraBacon)
            {
                runningTotal += 50;
            }
            if (Pepperoni)
            {
                runningTotal += 1.50;
            }
            if (ExtraCheese)
            {
                runningTotal += 2.00;
            }
            if (Ham)
            {
                runningTotal += 1.79;
            }
            if (Chicken)
            {
                runningTotal += 3;
            }

            return runningTotal;
        }
    }

    public class PizzaCrust
    {
        private double crustTotal;

        public bool ThinCrust { get; set; }
        public bool PanCrust { get; set; }
        public bool HandTossed { get; set; }


        public double CrustPrice()
        {
            crustTotal = 0; 

            if (ThinCrust)
            {
                crustTotal += 5.99;

            }
            if (PanCrust)
            {
                crustTotal += 7.99;

            }
            if (HandTossed)
            {
                crustTotal += 6.99;

            }
            return crustTotal;

        }
    }
    public class Tip
    {
        private double tipTotal;

        public bool Twelve { get; set; }
        public bool Fifteen { get; set; }
        public bool Eighteen { get; set; }

        public double TipPrice()
        {
            tipTotal = 0;

            if (Twelve)
            {
                tipTotal = 1.12; 

            }
            if (Fifteen)
            {
                tipTotal = 1.15; 

            }
            if (Eighteen)
            {
                tipTotal = 1.18;
            }

            return tipTotal;
        }
    }
}
