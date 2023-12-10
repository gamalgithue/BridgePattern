using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class DsConcept :ProgrammingConcept
    {
        public DsConcept(IUseLanguage useLanguage) : base(useLanguage)
        {

        }
        public override string DetermineConcept()
        {
            return "Implementing Data Strucure: " + useLanguage.UseLanguage();
        }
    }
}
