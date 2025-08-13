using System;
using System.Collections.Generic;

namespace GoFDesignPatterns
{
    public interface IObserver
    {
        void Update(string message);
    }

    public class User : IObserver
    {
        public string Name { get; }
        public User(string name) => Name = name;
        public void Update(string message) => Console.WriteLine($"{Name} bildirimi aldı: {message}");
    }

    public class NotificationService
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer) => observers.Add(observer);
        public void Unsubscribe(IObserver observer) => observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in observers)
                observer.Update(message);
        }
    }

    public static class ObserverExample
    {
        public static void Run()
        {
            Console.WriteLine("=== [Observer] ===\n");

            Console.WriteLine("Amaç:");
            Console.WriteLine("Bir nesnedeki değişiklikleri diğerlerine bildirmek.\n");

            Console.WriteLine("Problem:");
            Console.WriteLine("Bir nesne değiştiğinde, ona bağlı diğer nesnelerin otomatik olarak güncellenmesi gerekir.\n");

            Console.WriteLine("Çözüm Mantığı:");
            Console.WriteLine("- Observer arayüzü tanımla");
            Console.WriteLine("- Subject nesnesi, observer listesini tutar ve değişiklikte hepsini bilgilendirir\n");

            Console.WriteLine("Kod:");
            Console.WriteLine("public void Notify(string message) { foreach (var o in observers) o.Update(message); }\n");

            Console.WriteLine("Çıktı:");
            var service = new NotificationService();
            var user1 = new User("Ahmet");
            var user2 = new User("Mehmet");

            service.Subscribe(user1);
            service.Subscribe(user2);

            service.Notify("Yeni mesajınız var!");
        }
    }
}