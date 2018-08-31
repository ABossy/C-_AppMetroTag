using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMetroTag.Model;
using System.Collections.ObjectModel;
using TagLibrary;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfAppMetroTag.ViewModel
{
   public class TagViewModel : INotifyPropertyChanged
    {
        Station _stationData;

      public TagViewModel()
      {
            Latitude = "45.185270";
            Longitude = "5.727231";
            Rayon = "600";

            Request = new RelayCommand(DoRequest);
            _stationData = new Station();
            DoRequest();

      }

        private void DoRequest()
        {
            Dictionary<string, List<ChampRoute>> stationResult = _stationData.GetStation(Latitude, Longitude, Rayon); //je récupere les données traitées de type dictionnaire.
            List<DictionaryToList> champListe = _stationData.GetDataList(stationResult); // je les transforme en liste de type dictionarytolist
            DataView = new ObservableCollection<DictionaryToList>(champListe); // je rend accessible ma liste.
            RaisePropertyChanged("DataView");
        }

        public ObservableCollection<DictionaryToList> DataView
        {
            get;
            set;
        }

        public string Latitude
        {
            get;
            set;
        }

        public string Longitude
        {
            get;
            set;
        }

        public string Rayon
        {
            get;
            set;
        }

        public ICommand Request
        {
            get;
            set;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
   }
}
