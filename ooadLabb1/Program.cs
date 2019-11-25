using System;

namespace ooadLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior w1 = Warrior.Builder.StartBuild()
                .SetName("Garrosh")
                .SetWeapon("Battle Axe")
                .SetBattlecry("Face me!")
                .setHasShield(true)
                .SetHealth(130)
                .SetStrength(15)
                .SetDexterity(8)
                .CreateWarrior();

            Warrior w2 = Warrior.Builder.StartBuild().SetName("Jens").CreateWarrior();

            IWarriorPresenter consolePresenter = new WarriorConsolePresenter();
            IWarriorPresenter imagePresenter = new WarriorImagePresenter();
            w1.addObserver(consolePresenter);
            w1.addObserver(imagePresenter);
            w2.addObserver(consolePresenter);
            w2.addObserver(imagePresenter);

            CommandManager manager = CommandManager.Instance;

            manager.Execute(new ChangeNameAction("Pelle", w1));

            manager.Execute(new ChangeHasShieldAction(false, w1));

            manager.Execute(new ChangeHasShieldAction(true, w2));

            w1.removeObserver(imagePresenter);

            manager.Undo();

            manager.Undo();

            manager.Redo();

        }
    }
}
