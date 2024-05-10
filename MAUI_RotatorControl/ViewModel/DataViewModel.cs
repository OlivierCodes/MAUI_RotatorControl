using System;
using Syncfusion.Maui.Rotator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MAUI_RotatorControl.ViewModel
{
    public class DataViewModel
    {
        public ObservableCollection<SfRotatorItem>  RotatorItems { get; set; }


        public DataViewModel() 
        {
            RotatorItems = new ObservableCollection<SfRotatorItem>();

            RotatorItems.Add(new SfRotatorItem() { Image = "image1.png", ItemText = "Oiseau 1" });
            RotatorItems.Add(new SfRotatorItem() { Image = "image2.png", ItemText = "Oiseau 2" });
            RotatorItems.Add(new SfRotatorItem() { Image = "image3.png", ItemText = "Oiseau 3" });
            RotatorItems.Add(new SfRotatorItem() { Image = "image4.png", ItemText = "Oiseau 4" });
            RotatorItems.Add(new SfRotatorItem() { Image = "image5.png", ItemText = "Oiseau 5" });
            


        }







    }
}
