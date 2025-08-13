using System;

namespace GoFDesignPatterns
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }

    public static class SingletonExample
    {
        public static void Run()
        {
            Console.WriteLine("=== [Singleton] ===\n");

            // 1. Tanım
            Console.WriteLine("Amaç:");
            Console.WriteLine("Bir sınıfın yalnızca tek bir örneğinin olmasını sağlamak.\n");

            // 2. Problem
            Console.WriteLine("Problem:");
            Console.WriteLine("Uygulamanın farklı yerlerinde aynı nesneye ihtiyaç duyulduğunda,\n" +
                              "birden fazla kopya oluşması bellek ve veri tutarlılığı sorunlarına yol açar.\n");

            // 3. Çözüm Mantığı
            Console.WriteLine("Çözüm Mantığı:");
            Console.WriteLine("- Yapıcıyı (constructor) private yap");
            Console.WriteLine("- Tek bir static Instance alanı oluştur");
            Console.WriteLine("- Dışarıdan erişimi Instance üzerinden sağla\n");

            // 4. Kod Gösterimi
            Console.WriteLine("Kod:");
            Console.WriteLine("private static Singleton _instance;");
            Console.WriteLine("private Singleton() { }");
            Console.WriteLine("public static Singleton Instance => _instance ??= new Singleton();\n");

            // 5. Çıktı
            Console.WriteLine("Çıktı:");
            Singleton.Instance.Log("Uygulama başlatıldı.");
        }
    }
}