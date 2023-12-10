using BridgePattern;
using System;

namespace BridgPattern
{
    class program
    {
        static void Main(string[] args)
        {

            IUseLanguage csharp = new CSharp();
            IUseLanguage java = new Java();

            ProgrammingConcept oopconcept = new OopConcept(csharp);
            ProgrammingConcept dsconcept = new DsConcept(csharp);
            ProgrammingConcept dsconcept2 = new DsConcept(java);
            ProgrammingConcept oopconcept2 = new OopConcept(java);

            Console.WriteLine(oopconcept2.DetermineConcept());
            Console.WriteLine(oopconcept.DetermineConcept());
            Console.WriteLine(dsconcept.DetermineConcept());
            Console.WriteLine(dsconcept2.DetermineConcept());



        }
    }
}