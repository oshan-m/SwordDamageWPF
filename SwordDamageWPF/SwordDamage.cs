using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamageWPF
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMGE = 2;

        private int roll;
        public int Roll
        {
            get { return roll; }
            set 
            { 
                roll = value;
                CalculateDamage();
            }
        }

        //public decimal MagicMultiplier = 1M;
        //public int FlamingDamage = 0;
        public int Damage { get; private set; }
        //public int Damage;

        public SwordDamage(int roll)
        {
            Roll = roll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.57M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMGE;
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        //public void SetMagic(bool isMagic)
        //{
        //    if (isMagic)
        //    {
        //        MagicMultiplier = 1.75M;
        //    }
        //    else
        //    {
        //        MagicMultiplier = 1M;
        //    }
        //    CalculateDamage();
        //}

        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set 
            {
                flaming = value;
                CalculateDamage();
               // Damage += FLAME_DAMGE;
            }
        }
        //public void SetFlaming(bool isFlaming)
        //{
        //    CalculateDamage();
        //    if (isFlaming)
        //    {
        //        Damage += FLAME_DAMGE;
        //    }
        //}
    }
}
