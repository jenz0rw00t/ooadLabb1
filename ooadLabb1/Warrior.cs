namespace ooadLabb1
{
    public class Warrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public string Battlecry { get; set; }
        public bool HasShield { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }

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

        public override string ToString()
        {
            return "\n----Warrior----" +
                "\n Name: " + Name +
                "\n Weapon of choice: " + Weapon +
                "\n Battlecry: " + Battlecry +
                "\n Shield: " + $"{(HasShield ? "Yes" : "No")}" +
                "\n Health: " + Health +
                "\n Strength: " + Strength +
                "\n Dexterity: " + Dexterity;
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