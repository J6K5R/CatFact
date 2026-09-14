using System;
using System.Collections.Generic;
using System.Text;

namespace CatFact
{
    public class CatFactFileWriter
    {
        public void Save(CatFactDto catfact)
        {
            using (StreamWriter outputFile = new StreamWriter("CatFact.txt", true))
            {
                outputFile.WriteLine($"Length: {catfact.length} Fact: {catfact.fact}");
            }
        }
    }
}
