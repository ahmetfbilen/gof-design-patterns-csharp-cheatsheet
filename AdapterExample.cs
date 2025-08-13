using System;

namespace GoFDesignPatterns
{
    public interface ITarget
    {
        void Request();
    }

    public class OldSystem
    {
        public void SpecificRequest() => Console.WriteLine("Eski sistem çalıştı.");
    }

    public class Adapter : ITarget
    {
        private OldSystem _oldSystem = new OldSystem();
        public void Request() => _oldSystem.SpecificRequest();
    }

    public static class AdapterExample
    {
        public static void Run()
        {
            Console.WriteLine("=== [Adapter] ===\n");

            Console.WriteLine("Amaç:");
            Console.WriteLine("Uyumsuz arayüzleri birbirine bağlamak.\n");

            Console.WriteLine("Problem:");
            Console.WriteLine("Eski sistemin metot imzası yeni sistemin beklediği formatla uyuşmuyor.\n");

            Console.WriteLine("Çözüm Mantığı:");
            Console.WriteLine("- Yeni sistemin beklediği arayüzü uygula");
            Console.WriteLine("- İçeride eski sistemi çağırarak uyum sağla\n");

            Console.WriteLine("Kod:");
            Console.WriteLine("public class Adapter : ITarget { private OldSystem _oldSystem; public void Request() => _oldSystem.SpecificRequest(); }\n");

            Console.WriteLine("Çıktı:");
            ITarget target = new Adapter();
            target.Request();
        }
    }
}