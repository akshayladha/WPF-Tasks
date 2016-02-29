using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace WPFPractiseSamples.DataTemplateDemo
{
    public class AutoScrollBehavior : Behavior<Selector>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.SelectionChanged += AssociatedObject_SelectionChanged;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.SelectionChanged -= AssociatedObject_SelectionChanged;
        }

        void AssociatedObject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collectionControl = sender as Selector;
            if (collectionControl?.SelectedItem != null)
            {
                collectionControl.UpdateLayout();
                //collectionControl.ScrollIntoView(collectionControl.SelectedItem, null);
                var container = collectionControl.ItemContainerGenerator.ContainerFromItem(collectionControl.SelectedItem) as FrameworkElement;
                container?.BringIntoView();
            }
        }
    }
}

