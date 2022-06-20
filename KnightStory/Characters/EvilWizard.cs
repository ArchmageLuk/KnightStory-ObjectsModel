using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EvilWizard
    {
        public Monsters SummoningSpell()
        {
            int whatmonster = new Random().Next(1, 9);
            Monsters randomMonster = new Monsters();

            switch (whatmonster)
            {
                case 1:
                    randomMonster = new FireElemental();
                    break;
                case 2:
                    randomMonster = new WaterElemental();
                    break;
                case 3:
                    randomMonster = new WraithOfDeath();
                    break;
                case 4:
                    randomMonster = new WraithOfFury();
                    break;
                case 5:
                    randomMonster = new GiantBat();
                    break;
                case 6:
                    randomMonster = new Wolf();
                    break;
                case 7:
                    randomMonster = new Goblin();
                    break;
                case 8:
                    randomMonster = new Kobold();
                    break;
            }

            return randomMonster;
        }
    }
