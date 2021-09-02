using System;
using System.Collections.Generic;

namespace Problem
{
    public class Client
    {
        public string Name { get; set; }

        public List<FruitApple> GreenApples { get; set; } = new();
        public List<FruitApple> RedApples { get; set; } = new();
        public List<FruitOrange> Oranges { get; set; } = new();
        public double Cash { get; set; } = 200D;

        public void BuyFruitsFromShop(int greenApples,int redApples, int oranges,Shop shop)
        {
            PurchaseGreenApples(greenApples, shop);

            PurchaseRedApples(redApples, shop);

            PurchaseOranges(oranges, shop);

            double cost = CalculateCost(greenApples, redApples, oranges);

            shop.MoneyEarned(cost);
        }

        public void PurchaseGreenApples(int greenApples, Shop shop)
        {
            for (int i = 0; i < greenApples; i++)
            {
                GreenApples.Add(shop.GreenApples[i]);
                shop.GreenApples.Remove(GreenApples[i]);
            }
        }

        public void PurchaseRedApples(int redApples, Shop shop)
        {
            for (int i = 0; i < redApples; i++)
            {
                RedApples.Add(shop.RedApples[i]);
                shop.RedApples.Remove(RedApples[i]);
            }
        }

        public void PurchaseOranges(int oranges,Shop shop)
        {
            for (int i = 0; i < oranges; i++)
            {
                Oranges.Add(shop.Oranges[i]);
                shop.Oranges.Remove(Oranges[i]);
            }
        }

        public double CalculateCost(int greenApples, int redApples, int oranges)
        {
            double cost = greenApples * 15 + redApples * 13 + oranges * 16;
            Cash = Cash - cost;

            return cost;
        }

        public void ViewResults()
        {
            Console.WriteLine($"{Name}  Green Apples:{GreenApples.Count}  Red Apples:{RedApples.Count}" +
                              $"  Oranges:{Oranges.Count}  Cash:{Cash}");

            Console.WriteLine();
        }
    }
}
