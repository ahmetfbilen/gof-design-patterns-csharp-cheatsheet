using System;

namespace GoFDesignPatterns
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public class SimpleCoffee : ICoffee
    {
        public string GetDescription() => "Sade kahve";
        public double GetCost() => 5.0;
    }

    public class MilkDecorator : ICoffee
    {
        private ICoffee _coffee;
        public MilkDecorator(ICoffee coffee) => _coffee = coffee;

        public string GetDescription() => _coffee.GetDescription() + ", süt";
        public double GetCost() => _coffee.GetCost() + 2.0;
    }

    public static class DecoratorExample
    {
        public static void Run()
        {
            Console.WriteLine("=== [Decorator] ===\n");

            Console.WriteLine("Amaç:");
            Console.WriteLine("Nesneye dinamik olarak yeni özellik eklemek.\n");

            Console.WriteLine("Problem:");
            Console.WriteLine("Yeni özellik eklemek için sürekli alt sınıf oluşturmak kodu şişirir.\n");

            Console.WriteLine("Çözüm Mantığı:");
            Console.WriteLine("- Ortak arayüzü uygula");
            Console.WriteLine("- İçeride başka bir nesneyi sarmalayarak ek özellik ekle\n");

            Console.WriteLine("Kod:");
            Console.WriteLine("public class MilkDecorator : ICoffee { private ICoffee _coffee; public string GetDescription() => _coffee.GetDescription() + \", süt\"; }\n");

            Console.WriteLine("Çıktı:");
            ICoffee coffee = new SimpleCoffee();
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()}₺");
        }
    }
}