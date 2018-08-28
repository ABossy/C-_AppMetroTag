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
            Routes = new ObservableCollection<ChampRoute>();
            Routes.Add(new ChampRoute { LongName = "C", Mode = "Tram" });
            Routes.Add(new ChampRoute { LongName = "16", Mode = "Bus" });
            Routes.Add(new ChampRoute { LongName = "13", Mode = "Bus" });
        }

        public ObservableCollection<ChampRoute> Routes
        {
            get;
            set;
        }
    }
}
