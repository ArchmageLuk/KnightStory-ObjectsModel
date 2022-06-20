using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Humanoids : UsualMonsters
{
    public bool _hasweapon = true;
    public string? _weapon;
    public int _whatweapon = new Random().Next(1, 3);
}
