﻿using Characters.Warriors;
using CSharpOOP.Weapons;
using Interfaces;
using System;

namespace Characters.Spellcasters
{
    public class Mage : Character, ISpellcaster, ICalculator
    {
        private int mana;
        private Spell mySpell;


        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 30 && value <= 60)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Please use age between 30 and 60");
                }
            }
        }

        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                this.mana = value;
            }
        }
        public Spell MySpell
        {
            get
            {
                return this.mySpell;
            }
            set
            {
                this.mySpell = value;
            }
        }

        public Mage()
        {
            this.Mana = 100;
            this.MySpell = new Spell();
        }

        public Mage(int healthPoints, int weight, int age)
            : base(healthPoints, weight, age)
        {
        }

        public override string Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            return "I just moved 10 times, I am a Mage";
        }

        public void CastSpell(Character character)
        {
            character.HealthPoints = character.HealthPoints - this.mySpell.Damage;
            this.mana = this.mana - this.mySpell.ManaCost;
        }

        public override int Addition(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}
