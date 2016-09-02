using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Counter
{
    private int val = 0;
    public void Add(int x) { val += x; }
    public int Val() { return val; }
}
