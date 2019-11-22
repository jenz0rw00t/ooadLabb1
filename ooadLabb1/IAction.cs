using System;
namespace ooadLabb1
{
    public interface IAction
    {
        public void Execute();
        public void Undo();
    }
}
