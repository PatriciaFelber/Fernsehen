using System;
using System.IO;
using System.Linq

namespace Fernsehen;
class Reader
{
    static void Main(string[]args)
    {
        var reader = new StreamReader(@"/workspaces/Fernsehen/Fernsehen/TvData.csv");
        string line;
        while((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

    }
}
    
