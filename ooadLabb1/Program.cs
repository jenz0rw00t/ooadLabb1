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
            PresenterNotifier presenterNotifier = new PresenterNotifier();
            presenterNotifier.addPresenter(consolePresenter);
            presenterNotifier.addPresenter(imagePresenter);

            CommandManager manager = CommandManager.Instance;

            manager.Execute(new ChangeNameAction("Pelle", w1));

            presenterNotifier.notifyPresenters(w1);

            manager.Execute(new ChangeHasShieldAction(false, w1));

            presenterNotifier.notifyPresenters(w1);

            manager.Undo();

            presenterNotifier.notifyPresenters(w1);

            manager.Undo();

            presenterNotifier.notifyPresenters(w1);


        }
    }
}
