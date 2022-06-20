using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireElemental : Elementals
    {
        public FireElemental()
        {
            _name = "Fire Elemental";
            _health = 150;
            _exp = 300;
            _damage = 50;
            _special = "Burn";
            _range = 1;
            _speed = 1;
        }
    }
