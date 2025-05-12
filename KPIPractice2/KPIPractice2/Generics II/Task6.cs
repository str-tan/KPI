namespace KPIPractice2
{
    // Factory<T> where T : class, new()
    // - Створіть class Factory<T> where T:class,new() { T Create(); }.
    // - Напишіть DeliveryCenter із public конструктором за замовчуванням.
    // - У Main: var f=new Factory<DeliveryCenter>(); DeliveryCenter p=f.Create();
    public class Task6
    {
        public void Main()
        {
            var f = new Factory<DeliveryCenter>();
            DeliveryCenter p = f.Create();
            p.Location = "Lviv";
            p.PrintInfo();
        }
    }

    public class Factory<T> where T : class, new()
    {
        public T Create()
        {
            return new T();
        }
    }

    public class DeliveryCenter
    {
        public string Location { get; set; } = "Unknown";

        public void PrintInfo()
        {
            Console.WriteLine($"DeliveryCenter at: {Location}");
        }
    }


}
