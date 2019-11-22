using System;
namespace ooadLabb1
{
    public class ChangeHasShieldAction : IAction
    {
        private bool hasShield;
        private bool oldHasShield;
        private Warrior warrior;

        public ChangeHasShieldAction(bool hasShield, Warrior warrior)
        {
            this.hasShield = hasShield;
            this.warrior = warrior;
            this.oldHasShield = warrior.HasShield;
        }

        public void Execute()
        {
            warrior.HasShield = hasShield;
        }

        public void Undo()
        {
            warrior.HasShield = oldHasShield;
        }
    }
}
