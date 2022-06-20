using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Wolf : Beasts
    {
        public Wolf()
        {
            _name = "Wolf";
            _health = 40;
            _exp = 100;
            _damage = 10;
            _special = "Howl";
            _speed = 4;
        }
    }
