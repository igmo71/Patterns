namespace Patterns.CreationalPatterns.FactoryMethod
{
    internal class Pattern
    {
        public static void Run()
        {
            Console.WriteLine("CreationalPatterns FactoryMethod");

            Developer developer = new PanelDeveloper("ООО КирпичСтрой");
            House house1 = developer.Create();

            developer = new WoodDeveloper("Частный застройщик");
            House house2 = developer.Create();
        }
    }
}
