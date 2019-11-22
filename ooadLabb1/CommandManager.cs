using System;
using System.Collections.Generic;

namespace ooadLabb1
{
    public sealed class CommandManager
    {
        private Stack<IAction> normalStack = new Stack<IAction>();
        private Stack<IAction> reverseStack = new Stack<IAction>();

        public static CommandManager Instance { get; } = new CommandManager();

        static CommandManager(){}
        private CommandManager(){}
  
        public void Execute(IAction action)
        {
            action.Execute();
            normalStack.Push(action);
        }

        public void Undo()
        {
            if (normalStack.Count > 0)
            {
                var action = normalStack.Pop();
                action.Undo();
                reverseStack.Push(action);
            }
        }

        public void Redo()
        {
            if (reverseStack.Count > 0)
            {
                var action = reverseStack.Pop();
                action.Execute();
                normalStack.Push(action);
            }
        }
    }
}
