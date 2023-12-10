using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class OopConcept : ProgrammingConcept
    {
        public OopConcept(IUseLanguage useLanguage):base(useLanguage)
        {

        }
        public override string DetermineConcept()
        {
            return "Implementing OOP: " + useLanguage.UseLanguage();
        }
    }
}
