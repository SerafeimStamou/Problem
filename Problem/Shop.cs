using System;

namespace Problem
{
    public class Shop:Market
    {
        public double Cash { get; set; } = 400D;

        public Shop(int greenApples, int redApples, int oranges)
        {
            InitializeGreenApples(greenApples);
            InitializeRedApples(redApples);
            InitializeOranges(oranges);
        }

        public void InitializeGreenApples(int greenApples)
        {
            for (int i = 0; i < greenApples; i++)
            {
                FruitApple apple = new() { Id = Guid.NewGuid(), Color = "Green" };
                GreenApples.Add(apple);
            }
        }

        public void InitializeRedApples(int redApples)
        {
            for (int i = 0; i < redApples; i++)
            {
                FruitApple apple = new() { Id = Guid.NewGuid(), Color = "Red" };
                RedApples.Add(apple);
            }
        }

        public void InitializeOranges(int oranges)
        {
            for (int i = 0; i < oranges; i++)
            {
                FruitOrange orange = new() { Id = Guid.NewGuid()};
                Oranges.Add(orange);
            }
        }

        public void BuyAllFruitsFromProducer(Producer producer)
        {
            Purchase(producer);

            CalculateCost(producer);

            ClearLists(producer);
        }

        public void CalculateCost(Producer producer)
        {
            double Cost = producer.GreenApples.Count * 10 + producer.RedApples.Count * 9 + producer.Oranges.Count * 11;
            Cash = Cash - Cost;
            producer.Cash = producer.Cash + Cost;
        }

        public void Purchase(Producer producer)
        {
            for (int i = 0; i < 10; i++)
            {
                GreenApples.Add(producer.GreenApples[i]);
                RedApples.Add(producer.RedApples[i]);
                Oranges.Add(producer.Oranges[i]);
            }
        }

        public void ClearLists(Producer producer)
        {
            producer.GreenApples.Clear();
            producer.RedApples.Clear();
            producer.Oranges.Clear();
        }

        public void MoneyEarned(double money)
        {
            Cash = Cash + money;
        }

        public void ViewResults()
        {
            Console.WriteLine($"Shop      Green Apples:{GreenApples.Count}  Red Apples:{RedApples.Count}" +
                             $"  Oranges:{Oranges.Count}  Cash:{Cash}");

            Console.WriteLine();
        }
    }
}
