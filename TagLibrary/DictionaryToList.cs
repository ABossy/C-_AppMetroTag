using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLibrary
{
   public class DictionaryToList
    {
        public DictionaryToList(string arret, List<ChampRoute> lines)
        {
            ArretName = arret;
            ArretLigne = lines;
        }

        public string ArretName
        {
            get;
            private set;
        }

        public List<ChampRoute> ArretLigne
        {
            get;
            private set;
        }

    }
}
