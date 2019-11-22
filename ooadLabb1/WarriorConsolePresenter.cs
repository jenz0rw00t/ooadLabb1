using System;
namespace ooadLabb1
{
    public class WarriorConsolePresenter : IWarriorPresenter
    {
        private Warrior warrior;

        public void update(Warrior warrior)
        {
            this.warrior = warrior;
            presentWarrior();
        }

        private void presentWarrior()
        {
            Console.WriteLine("\nTHIS WARRIOR HAS CHANGED: ");
            Console.WriteLine(warrior);
        }
    }
}
