using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Journey
{
    public void StartJourney()
    {
        EvilWizard evilWizard = new EvilWizard();
        TheKnight knight = new TheKnight();

        Console.WriteLine("The Knight starts journey to defeat the ultimate evil");
        for (int i = 0; i < 51; i++)
        {
            Console.WriteLine(" ");
            Console.WriteLine("The Evil Wizard appears!");
            Monsters newmonster = evilWizard.SummoningSpell();
            Console.WriteLine($"The Evil Wizard summoned {newmonster}");
            knight.FightMonster(newmonster);

            if (knight._isalive == false)
            {
                Console.WriteLine("The journey is ended! Evil is victorious!");
                break;
            }

            if (i == 50)
            {
                Console.WriteLine(" ");
                Console.WriteLine("The Knight found and beheaded the Evil Wizard! Evil magic is no match for bravery!");
                Console.WriteLine("The Knight finished his journey! During it the Knight:");
                Console.WriteLine($"-Gained level {knight._level} with {knight._exp} XP in total");
                Console.WriteLine($"-Has now {knight.Potions} healing potions and {knight.Arrows} arrows");
                Console.WriteLine($"Also, he have {knight._health} HP");
            }
        }
    }
}
