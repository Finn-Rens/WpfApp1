using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    
    
     
    class AutoController
    {
        public ObservableCollection<Auto> Autos { get; set; }

        public AutoController() 
        {
            Autos = new ObservableCollection<Auto>();
        }

        public void Verwijderen(Auto auto) 
        {
            Autos.Remove(auto);
        }

        public void Wijzigen(Auto auto) 
        {
            
        }

    }
}
