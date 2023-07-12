namespace Patterns.CreationalPatterns.AbstractFactory
{
    // Фабрика создания летящего героя с арбалетом
    internal class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
