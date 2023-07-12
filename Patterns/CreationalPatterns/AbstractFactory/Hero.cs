namespace Patterns.CreationalPatterns.AbstractFactory
{
    // клиент - сам супергерой
    internal class Hero
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }

        public void Move()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
