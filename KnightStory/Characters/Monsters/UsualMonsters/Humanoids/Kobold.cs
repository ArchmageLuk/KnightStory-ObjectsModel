using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kobold : Humanoids
    {
        public Kobold()
        {
            _health = 70;
            _exp = 150;
            if (_whatweapon == 1)
            {
                _name = "Spear Kobold";
                _weapon = "spear";
                _damage = 15;
                _speed = 4;
            }
            else
            {
                _name = "Sling Kobold";
                _weapon = "sling";
                _damage = 5;
                _range = 2;
            }
        }
    }
