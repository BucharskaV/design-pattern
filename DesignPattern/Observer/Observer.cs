// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; private set; } = userName;

        public void AddSubscriber(ISubject user)
        {
            user.RegisterObserver(this);
        }
        
        public void RemoveSubscriber(ISubject user)
        {
            user.RemoveObserver(this);
        }
        
        public void Update(string availability)
        {
            Console.WriteLine($"{UserName} : current availability: {availability}");
        }
    }
}
