// Observer pattern - mushahidechi
// Also known as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscribers

ProductManager productManager = new ProductManager();
var customer = new Customer();
var employee = new Employee();

productManager.Attach(customer);
productManager.Attach(employee);

productManager.UpdatePrice();

Console.WriteLine();

productManager.Detach(customer);

productManager.UpdatePrice();
