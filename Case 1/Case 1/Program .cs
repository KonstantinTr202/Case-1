using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.SqlServer.Server;

public class Program
{
    static void Main(string[] args)
    {
        DostupResur dostup_Resur = new DostupResur();
        Result result = new Result();
        Marka_A marka_A = new Marka_A();
        Marka_B marka_B = new Marka_B();
        Marka_C marka_C = new Marka_C();
        Reader reader = new Reader();
        reader.Read();
        result.result();
    }
}

