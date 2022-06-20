using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WaterElemental : Elementals
    {
        public WaterElemental()
        {
            _name = "Water Elemental";
            _health = 125;
            _exp = 250;
            _damage = 50;
            _special = "Drown Bubble";
            _range = 2;
        }
    }
