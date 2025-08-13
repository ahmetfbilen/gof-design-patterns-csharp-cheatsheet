using System;

namespace GoFDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== GoF Design Patterns (Öğretici Mod) ===");
                Console.WriteLine("1 - Singleton");
                Console.WriteLine("2 - Factory Method");
                Console.WriteLine("3 - Adapter");
                Console.WriteLine("4 - Decorator");
                Console.WriteLine("5 - Observer");
                Console.WriteLine("6 - Strategy");
                Console.WriteLine("0 - Çıkış");
                Console.Write("\nSeçiminiz: ");

                if (!int.TryParse(Console.ReadLine(), out int secim) || secim < 0 || secim > 6)
                {
                    Console.WriteLine("Geçersiz seçim!");
                    Console.ReadKey();
                    continue;
                }

                if (secim == 0) break;

                Console.Clear();
                switch (secim)
                {
                    case 1: SingletonExample.Run(); break;
                    case 2: FactoryMethodExample.Run(); break;
                    case 3: AdapterExample.Run(); break;
                    case 4: DecoratorExample.Run(); break;
                    case 5: ObserverExample.Run(); break;
                    case 6: StrategyExample.Run(); break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}