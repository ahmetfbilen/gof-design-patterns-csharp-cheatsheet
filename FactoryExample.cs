using System;

namespace GoFDesignPatterns
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Daire çizildi.");
    }

    public class Square : Shape
    {
        public override void Draw() => Console.WriteLine("Kare çizildi.");
    }

    public abstract class ShapeFactory
    {
        public abstract Shape CreateShape();
    }

    public class CircleFactory : ShapeFactory
    {
        public override Shape CreateShape() => new Circle();
    }

    public class SquareFactory : ShapeFactory
    {
        public override Shape CreateShape() => new Square();
    }

    public static class FactoryMethodExample
    {
        public static void Run()
        {
            Console.WriteLine("=== [Factory Method] ===\n");

            Console.WriteLine("Amaç:");
            Console.WriteLine("Nesne oluşturma işini alt sınıflara bırakmak.\n");

            Console.WriteLine("Problem:");
            Console.WriteLine("Yeni tip nesneler eklemek istediğimizde, mevcut kodu değiştirmek zorunda kalmak esnekliği azaltır.\n");

            Console.WriteLine("Çözüm Mantığı:");
            Console.WriteLine("- Ortak bir arayüz veya abstract sınıf tanımla");
            Console.WriteLine("- Alt sınıflar kendi nesne oluşturma mantığını uygulasın\n");

            Console.WriteLine("Kod:");
            Console.WriteLine("public abstract class ShapeFactory { public abstract Shape CreateShape(); }");
            Console.WriteLine("public class CircleFactory : ShapeFactory { public override Shape CreateShape() => new Circle(); }\n");

            Console.WriteLine("Çıktı:");
            ShapeFactory factory = new CircleFactory();
            Shape shape = factory.CreateShape();
            shape.Draw();
        }
    }
}