using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMetroTag.Model;
using System.Collections.ObjectModel;
using TagLibrary;

namespace WpfAppMetroTag.ViewModel
{
   public class TagViewModel 
    {
        

      public TagViewModel()
      {
            Station stationData = new Station(); // initialise un nouyvel objet
            Dictionary<string, List<ChampRoute>> stationResult = stationData.GetStation(); //je récupere les données traitées de type dictionnaire.
            List<DictionaryToList> champListe = stationData.GetDataList(stationResult); // je les transforme en liste de type dictionarytolist
            DataView = new ObservableCollection<DictionaryToList>(champListe); // je rend accessible ma liste.

        }
        public ObservableCollection<DictionaryToList> DataView
        {
            get;
            set;
        }
    }
}
