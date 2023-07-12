namespace Patterns.CreationalPatterns.AbstractFactory
{
    // класс абстрактной фабрики
    internal abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
