namespace KPIPractice2
{
    /// Box<T> — універсальний контейнер
    /// - Оголосіть клас Box<T>, який має поле чи властивість T Value.
    /// - Додайте метод void Display(), що виводить у консоль значення Value.
    /// - У методі Main продемонструйте роботу Box<int>, Box<string> та Box<Person>,
    /// де Person — ваш власний клас із полями Name і Age.
    public class Task1
    {
        public void Main()
        {
            Box<int> intBox = new Box<int>(654);
            intBox.Display();

            Box<string> strBox = new Box<string>("Hello World");
            strBox.Display();

            Box<Person> personBox = new Box<Person>(new Person("Tatiana", 18));
            personBox.Display();

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public void Display()
        {
            Console.WriteLine(Value);
        }
    }
}
