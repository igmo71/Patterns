namespace Patterns.CreationalPatterns.AbstractFactory
{
    // класс арбалет
    internal class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
