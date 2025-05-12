namespace KPIPractice2
{
    // IStorage<T> & ListStorage<T>
    // - Оголосіть interface IStorage<T>
    // {
    //  void Add(T);
    //  T Get(int);
    //  int Count;
    // }.
    // - Реалізуйте ListStorage<T> на базі List<T>.
    // - У Main додайте/отримайте елементи int, string тощо.
    public class Task4
    {
        public void Main()
        {
            ListStorage<int> intStorage = new ListStorage<int>();
            intStorage.Add(60);
            intStorage.Add(50);
            intStorage.Add(20);
            intStorage.Add(25);

            Console.WriteLine("Int storage:");
            for (int i = 0; i < intStorage.Count; i++)
            {
                Console.WriteLine(intStorage.Get(i));
            }

            IStorage<string> stringStorage = new ListStorage<string>();
            stringStorage.Add("Hello");
            stringStorage.Add("World");
            stringStorage.Add("Tatiana");
            stringStorage.Add("KPIPractice2");

            Console.WriteLine("String storage:");
            for (int i = 0; i < stringStorage.Count; i++)
            {
                Console.WriteLine(stringStorage.Get(i));
            }

        }

        public interface IStorage<T>
        {
            void Add(T item);
            T Get(int index);
            int Count { get; }
        }

        public class ListStorage<T> : IStorage<T>
        {
            private List<T> smth = new List<T>();

            public void Add(T item)
            {
                smth.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= smth.Count)
                    throw new IndexOutOfRangeException("Index is out of range.");
                return smth[index];
            }

            public int Count
            {
                get
                {
                    return smth.Count;
                }
            }
        }
    }
}
