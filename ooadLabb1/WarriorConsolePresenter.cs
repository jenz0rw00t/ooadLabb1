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
            Console.WriteLine("\n----Warrior----" +
                "\n Name: " + warrior.Name +
                "\n Weapon of choice: " + warrior.Weapon +
                "\n Battlecry: " + warrior.Battlecry +
                "\n Shield: " + $"{(warrior.HasShield ? "Yes" : "No")}" +
                "\n Health: " + warrior.Health +
                "\n Strength: " + warrior.Strength +
                "\n Dexterity: " + warrior.Dexterity);
        }
    }
}
