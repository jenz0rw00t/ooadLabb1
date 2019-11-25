using System.Collections.Generic;

namespace ooadLabb1
{
    public class Warrior
    {
        private string _name;
        private string _weapon;
        private string _battlecry;
        private bool _hasShield;
        private int _health;
        private int _strength;
        private int _dexterity;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                notifyObservers();
            }
        }
        public string Weapon
        {
            get => _weapon;
            set
            {
                _weapon = value;
                notifyObservers();
            }
        }
        public string Battlecry
        {
            get => _battlecry;
            set
            {
                _battlecry = value;
                notifyObservers();
            }
        }
        public bool HasShield
        {
            get => _hasShield;
            set
            {
                _hasShield = value;
                notifyObservers();
            }
        }
        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                notifyObservers();
            }
        }
        public int Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                notifyObservers();
            }
        }
        public int Dexterity
        {
            get => _dexterity;
            set
            {
                _dexterity = value;
                notifyObservers();
            }
        }

        private List<IWarriorPresenter> presenters = new List<IWarriorPresenter>();

        public Warrior(string name, string weapon, string battlecry, bool hasShield, int health, int strength, int dexterity)
        {
            Name = name;
            Weapon = weapon;
            Battlecry = battlecry;
            HasShield = hasShield;
            Health = health;
            Strength = strength;
            Dexterity = dexterity;
        }

        public void addObserver(IWarriorPresenter presenter)
        {
            presenters.Add(presenter);
        }

        public void removeObserver(IWarriorPresenter presenter)
        {
            presenters.Remove(presenter);
        }

        private void notifyObservers()
        {
            foreach (var presenter in presenters)
            {
                presenter.update(this);
            }
        }

        public class Builder
        {
            private string name = "Unnamed warrior";
            private string weapon = "Wooden sword";
            private string battlecry = "AAAAHHHH!!!";
            private bool hasShield = false;
            private int health = 100;
            private int strength = 10;
            private int dexterity = 10;

            public static Builder StartBuild()
            {
                return new Builder();
            }

            public Warrior CreateWarrior()
            {
                return new Warrior(name, weapon, battlecry, hasShield, health, strength, dexterity);
            }

            public Builder SetName(string name)
            {
                this.name = name;
                return this;
            }

            public Builder SetWeapon(string weapon)
            {
                this.weapon = weapon;
                return this;
            }

            public Builder SetBattlecry(string battlecry)
            {
                this.battlecry = battlecry;
                return this;
            }

            public Builder setHasShield(bool hasShield)
            {
                this.hasShield = hasShield;
                return this;
            }

            public Builder SetHealth(int health)
            {
                this.health = health;
                return this;
            }

            public Builder SetStrength(int strength)
            {
                this.strength = strength;
                return this;
            }

            public Builder SetDexterity(int dexterity)
            {
                this.dexterity = dexterity;
                return this;
            }
        }
    }
}