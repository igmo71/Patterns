namespace Patterns.CreationalPatterns.AbstractFactory
{
    internal class DwarfFactory : HeroFactory
    {
        // Фабрика создания бегущего героя с мечом
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
