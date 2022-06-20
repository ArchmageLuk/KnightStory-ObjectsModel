using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Goblin : Humanoids
{
    public Goblin()
    {
        _health = 100;
        _exp = 200;
        if (_whatweapon == 1)
        {
            _name = "Sword Goblin";
            _weapon = "sword";
            _damage = 30;
        }
        else
        {
            _name = "Bow Goblin";
            _weapon = "bow";
            _damage = 10;
            _range = 2;
            _speed = 2;
        }
    }
}
