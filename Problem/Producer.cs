using System;
using System.Collections.Generic;

namespace Problem
{
    public class Producer
    {
        public List<FruitApple> GreenApples { get; set; } = new();
        public List<FruitApple> RedApples { get; set; } = new();
        public List<FruitOrange> Oranges { get; set; } = new();
        public double Cash { get; set; } = 0;

        public Producer(int greenApples, int redApples, int oranges)
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
            for(int i = 0; i < redApples; i++)
            {
                FruitApple apple = new() { Id = Guid.NewGuid(),Color="Red"};
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

        public void ViewResults()
        {
            Console.WriteLine($"Producer  Green Apples:{GreenApples.Count}  Red Apples:{RedApples.Count}" +
                              $"  Oranges:{Oranges.Count}  Cash:{Cash}");

            Console.WriteLine();
        }
    }
}
