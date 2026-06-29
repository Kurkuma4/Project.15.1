using Project.Entities.Skills;

namespace Project.Entities
{
    public class Player
    {
        public bool IsLoadedGame { get; set; }
        public string Name { get; set; }
        public string HeroImage { get; set; }

        public int Level { get; set; }
        public int Experience { get; set; }

        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public int Gold { get; set; }

        public bool HasBerserkBuff { get; set; }

        public int Health { get; set; }
        public int Mana { get; set; }

        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public int MaxHealth => Endurance * 10;

        public int MaxMana => Intelligence * 5;

        public List<BaseSkill> skills;

        public Difficulty SavedDifficulty { get; set; }
        public int UniqueSkillCooldown { get; set; }
        public int SavedBossCooldown { get; set; }
        public int BackgroundState { get; set; }
        public Player()
        {
            skills = new List<BaseSkill>();

            skills.Add(new Strike(this));
            skills.Add(new PowerStrike(this));
            skills.Add(new Heal(this));
            skills.Add(new Rest(this));
            skills.Add(new UniqueSkill(this));
        }
        public void ClampStats()
        {
            if (Health > MaxHealth)
                Health = MaxHealth;

            if (Mana > MaxMana)
                Mana = MaxMana;
        }
        /*
        public void ResetStats()
        {
            Health = MaxHealth;
            Mana = MaxMana;
        }
        */
        public int CalculateAttackPower()
        {
            int weaponBonus = Weapon != null ? Weapon.AttackBonus : 0;
            return Strength + weaponBonus;
        }

        public int CalculateDefense()
        {
            int armorBonus = Armor != null ? Armor.DefenseBonus : 0;
            return Agility + armorBonus;
        }
        public void TakeDamage(int damage)
        {
            damage -= CalculateDefense() / 2;

            if (damage < 1)
                damage = 1;

            Health -= damage;

            if (Health < 0)
                Health = 0;
        }

        public void Heal(int value)
        {
            Health += value;

            if (Health > MaxHealth)
                Health = MaxHealth;
        }
    }
}
