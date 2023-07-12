namespace Patterns.CreationalPatterns.FactoryMethod
{
    // абстрактный класс строительной компании
    internal abstract class Developer
    {
        public string? Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        // фабричный метод
        abstract public House Create();
    }
}
