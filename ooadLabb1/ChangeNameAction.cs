using System;
namespace ooadLabb1
{
    public class ChangeNameAction : IAction
    {
        private string name;
        private string oldName;
        private Warrior warrior;

        public ChangeNameAction(string name, Warrior warrior)
        {
            this.name = name;
            this.warrior = warrior;
            this.oldName = warrior.Name;
        }

        public void Execute()
        {
            warrior.Name = name;
        }

        public void Undo()
        {
            warrior.Name = oldName;
        }
    }
}
