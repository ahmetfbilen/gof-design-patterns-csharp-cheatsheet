using System;
using System.Collections.Generic;

namespace GoFDesignPatterns
{
    public interface ISortStrategy
    {
        void Sort(List<int> list);
    }

    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list) => Console.WriteLine("Bubble Sort ile sıralandı.");
    }

    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list) => Console.WriteLine("Quick Sort ile sıralandı.");
    }

    public class Sorter
    {
        private ISortStrategy _strategy;
        public Sorter(ISortStrategy strategy) => _strategy = strategy;
        public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;
        public void Sort(List<int> list) => _strategy.Sort(list);
    }

    public static class StrategyExample
    {
        public static void Run()
        {
            Console.WriteLine("=== [Strategy] ===\n");

            Console.WriteLine("Amaç:");
            Console.WriteLine("Algoritmaları birbirinin yerine geçebilir şekilde tanımlamak.\n");

            Console.WriteLine("Problem:");
            Console.WriteLine("Farklı algoritmalar arasında geçiş yapmak için kodu değiştirmek zorunda kalmak esnekliği azaltır.\n");

            Console.WriteLine("Çözüm Mantığı:");
            Console.WriteLine("- Ortak bir strateji arayüzü tanımla");
            Console.WriteLine("- Farklı algoritmaları bu arayüzü implemente eden sınıflara koy\n");

            Console.WriteLine("Kod:");
            Console.WriteLine("public class Sorter { private ISortStrategy _strategy; public void Sort(List<int> list) => _strategy.Sort(list); }\n");

            Console.WriteLine("Çıktı:");
            var sorter = new Sorter(new BubbleSort());
            sorter.Sort(new List<int> { 5, 3, 1 });

            sorter.SetStrategy(new QuickSort());
            sorter.Sort(new List<int> { 5, 3, 1 });
        }
    }
}