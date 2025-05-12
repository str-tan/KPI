namespace KPIPractice2
{
    //  SendPackage<T> where T : DeliveryCenter, IDelivery
    // - Оголосіть DeliveryCenter та IDelivery { void Deliver(); }.
    // - Реалізуйте NovaPoshta : DeliveryCenter, IDelivery.
    // - Метод void SendPackage<T>(T c) where T:DeliveryCenter,IDelivery { c.Deliver(); }.
    public class Task7
    {
        public void Main()
        {
            var f = new Factory<DeliveryCenter>();
            DeliveryCenter p = f.Create();
            p.Location = "Lviv";
            p.PrintInfo();

            NovaPoshta np = new NovaPoshta();
            np.Location = "Kyiv";
           // SendPackage(np);
        }

        public static void SendPackage<T>(T c) where T : DeliveryCenter, IDelivery
        {
            c.Deliver();
        }

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

    public interface IDelivery
    {
        void Deliver();
    }

    public class NovaPoshta : DeliveryCenter, IDelivery
    {
        public void Deliver()
        {
            Console.WriteLine($"NovaPoshta delivers from {Location}");
        }
    }

