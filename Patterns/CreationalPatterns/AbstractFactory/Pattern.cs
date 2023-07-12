namespace Patterns.CreationalPatterns.AbstractFactory
{
    internal class Pattern
    {
        public static void Run()
        {
            Hero elf = new Hero( new ElfFactory());
            elf.Move();
            elf.Hit();

            Hero dwarf = new Hero(new DwarfFactory());
            dwarf.Move();
            dwarf.Hit();
        }
    }
}
