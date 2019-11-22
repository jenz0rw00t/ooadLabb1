using System;
using System.Collections.Generic;

namespace ooadLabb1
{
    public class PresenterNotifier
    {
        private Warrior warrior;
        private List<IWarriorPresenter> presenters;

        public PresenterNotifier()
        {
            presenters = new List<IWarriorPresenter>();
        }

        public void addPresenter(IWarriorPresenter presenter)
        {
            presenters.Add(presenter);
        }

        public void removePresenter(IWarriorPresenter presenter)
        {
            presenters.Remove(presenter);
        }

        public void notifyPresenters(Warrior warrior)
        {
            this.warrior = warrior;
            foreach (var presenter in presenters)
            {
                presenter.update(warrior);
            }
        }
    }
}
