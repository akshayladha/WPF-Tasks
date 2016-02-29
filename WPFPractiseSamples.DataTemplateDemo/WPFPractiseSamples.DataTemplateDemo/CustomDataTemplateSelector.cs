using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFPractiseSamples.DataTemplateDemo
{

    public class CustomDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var vehicleType = item as Vehicle;
            if (vehicleType == null) return DefaultTemplate;
            return vehicleType.NumberOfDoors == 0 ? BikeTemplate : CarTemplate;
        }

        public DataTemplate CarTemplate { get; set; }
        public DataTemplate BikeTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

    }
}
