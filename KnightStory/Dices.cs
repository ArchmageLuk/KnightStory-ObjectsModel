using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dices
{
    public int ThrowD(int faces)
    {
        int diceResult = new Random().Next(1, faces + 1);
        return diceResult;
    }
}
