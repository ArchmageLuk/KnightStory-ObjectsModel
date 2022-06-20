using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TheKnight : Actors
{
    public int LevelUpReq = 200;
    public int Arrows = 5;
    public int Potions = 3;
    public TheKnight()
        {
            _name = "The Knight";
            _level = 1;
            _health = 200;
            _exp = 0;
            _damage = 30;
            _speed = 3;
        }

    public void LevelUp(int exp)
    {
        if (exp >= LevelUpReq)
        {
            _level = _level + 1;
            _health = 200 + (50 * _level);
            _damage = 30 + (5 * _level);
            LevelUpReq = LevelUpReq * 2;
            Console.WriteLine($"The Knight is now LEVEL {_level}! He became stronger!");
        }
    }

    public void KnightAttacks(Monsters monster)
    {
        if (_health < 60 & _health > 0 & Potions > 0)
        {
            Potions = Potions - 1;
            _health = _health + 50;
            Console.WriteLine($"The Knight uses potion to restore health! Now he has {_health} HP. {Potions} are left!");
        }
        else
        {
            Console.WriteLine($"The Knight attacks!");
            if (Arrows <= 0 & monster._range == 2)
            {
                Console.WriteLine("The Knight approaches monster. He cannot hit it now!");
                monster._range = 1;
            }
            else if (Arrows > 0 & monster._range == 2)
            {
                monster._health = monster._health - _damage;
                Arrows = Arrows - 1;
                Console.WriteLine($"{monster._name} suffers {_damage} damage. It has {monster._health} health left");
            }
            else if (monster._range == 1)
            {
                monster._health = monster._health - _damage;
                Console.WriteLine($"{monster._name} suffers {_damage} damage. It has {monster._health} health left");
            }
        }
    }

    public void KnightDefends(Monsters monster)
    {
        int dice = new Dices().ThrowD(20);
        Console.WriteLine($"{monster._name} attacks the Knight");
        if (_level > dice)
        {
            Console.WriteLine("The Knight evaded an attack and suffered no damage!");
        }
        else if (dice == _level)
        {
            _health = _health - (monster._damage % 2);
            Console.WriteLine($"The Knight blocked an attack and suffered half of the damage! He has {_health} health left");
        }
        else
        {
            _health = _health - monster._damage;
            Console.WriteLine($"The Knight suffers {monster._damage} damage. He has {_health} health left");
        }
    }

    public void FightMonster(Monsters monster)
    {
        Console.WriteLine(" ");

        for (int i = 0; i < 20; i++)
            {
                if (_isalive == true & monster._isalive == true)
                {
                if (monster._speed > _speed)
                  {
                    KnightDefends(monster);
                    KnightAttacks(monster);
                  }
                else
                  {
                    KnightAttacks(monster);
                    KnightDefends(monster);
                  }
                }

                if (monster._health <= 0)
                {
                    int dice = new Dices().ThrowD(6);

                    monster._isalive = false;
                    _exp = _exp + monster._exp;
                    Console.WriteLine($"{monster._name} died!");

                    if (dice > 3)
                    {
                        Console.WriteLine("The Knight found a healing potion!");
                        Potions = Potions + 1;
                    }

                    if (dice > 4)
                    {
                        Console.WriteLine("The Knight found an arrow!");
                        Arrows = Arrows + 1;
                    }

                    break;
                }

                if (_health <= 0)
                {
                    _isalive = false;
                    break;
                }
            }

        LevelUp(_exp);
    }
}
