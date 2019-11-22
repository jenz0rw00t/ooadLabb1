using System;
namespace ooadLabb1
{
    public class WarriorImagePresenter : IWarriorPresenter
    {

        public void update(Warrior warrior)
        {
            if (warrior.HasShield)
            {
                Console.WriteLine("        .--.");
                Console.WriteLine("       /.--.\\");
                Console.WriteLine("       |====|  " + warrior.Name);
                Console.WriteLine("       |`::`| ");
                Console.WriteLine("   .-;`\\..../`;_.-^-._");
                Console.WriteLine("  /  |...::..|`   :   `|");
                Console.WriteLine(" |   /'''::''|   .:.   |");
                Console.WriteLine(" ;--'\\   ::  |..:::::..|");
                Console.WriteLine(" <__> >._::_.| ':::::' |");
                Console.WriteLine(" |  |/   ^^  |   ':'   |");
                Console.WriteLine(" \\::/|       \\    :    /");
                Console.WriteLine(" |||\\|        \\   :   / ");
                Console.WriteLine(" ''' |___/\\___|`-.:.-`");
                Console.WriteLine("      \\_ || _/");
                Console.WriteLine("      <_ >< _>");
                Console.WriteLine("      |  ||  |");
                Console.WriteLine("      |  ||  |");
                Console.WriteLine("     _\\.:||:./_");
                Console.WriteLine("    /____/\\____\\");
            }
            else if (!warrior.HasShield)
            {
                Console.WriteLine("        .--.");
                Console.WriteLine("       /.--.\\");
                Console.WriteLine("       |====|  " + warrior.Name);
                Console.WriteLine("       |`::`|");
                Console.WriteLine("   .-;`\\..../`;-.");
                Console.WriteLine("  /  |...::...|  \\");
                Console.WriteLine(" |   /'''::'''\\   |");
                Console.WriteLine(" ;--'\\   ::   /\\--;");
                Console.WriteLine(" <__>,>._::_.<,<__>");
                Console.WriteLine(" |  |/   ^^   \\|  |");
                Console.WriteLine(" \\::/|        |\\::/");
                Console.WriteLine(" |||\\|        |/|||");
                Console.WriteLine(" ''' |___/\\___| '''");
                Console.WriteLine("      \\_ || _/");
                Console.WriteLine("      <_ >< _>");
                Console.WriteLine("      |  ||  |");
                Console.WriteLine("      |  ||  |");
                Console.WriteLine("     _\\.:||:./_");
                Console.WriteLine("    /____/\\____\\");
            }

        }   
    }
}
