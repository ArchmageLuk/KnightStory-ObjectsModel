using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Actors
{
    public string? _name;
    public int _level;
    public int _health;
    public bool _antimagichurts;
    public int _exp;
    public bool _isalive = true;
    public string? _special;
    public int _damage;
    public int _range = 1; // 1 for melee, 2 for ranged monsters;
    public int _speed = 3; // 1-5, very slow to very fast
}
