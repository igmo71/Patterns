namespace Patterns.CreationalPatterns.AbstractFactory
{
    // движение полета
    internal class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
