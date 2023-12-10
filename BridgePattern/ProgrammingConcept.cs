using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public  abstract class ProgrammingConcept
    {

        protected IUseLanguage useLanguage;

        public ProgrammingConcept (IUseLanguage useLanguage)
        {
            this.useLanguage = useLanguage;
        }

       
        

        public IUseLanguage getconcept()
        {
            return useLanguage;
        }
        public void setconcept(IUseLanguage useLanguage)
        {
            this.useLanguage = useLanguage;
        }
        public abstract  string DetermineConcept();
    }
}
