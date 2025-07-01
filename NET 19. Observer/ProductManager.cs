// Observer pattern - mushahidechi
// Also known as: Event-Subscriber, Listener
class ProductManager // Publisher
{
    private List<Observer> _observers = new List<Observer>();

    public void UpdatePrice() => Notify("Product price changed!!!");

    public void Attach(Observer observer)=> _observers.Add(observer);
    public void Detach(Observer observer)=> _observers.Remove(observer);
    private void Notify(string message) => _observers.ForEach(s => s.Update(message));

}