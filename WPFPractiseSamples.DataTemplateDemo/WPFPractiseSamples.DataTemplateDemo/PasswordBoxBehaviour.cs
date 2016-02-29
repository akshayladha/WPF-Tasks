using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace WPFPractiseSamples.DataTemplateDemo
{
    public class PasswordBoxBehaviour : Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.TextChanged += AssociatedObject_TextChanged;
            base.OnAttached();
        }

        private void AssociatedObject_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!String.IsNullOrEmpty(tb.Text))
            {
                Actualtext += tb.Text.Last().ToString();
                foreach (var letter in tb.Text)
                {
                    Actualtext = Actualtext.Replace("*", "");
                    tb.Text = tb.Text.Replace(letter.ToString(), "*");
                }
                tb.CaretIndex = tb.Text.Length;
            }
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.TextChanged -= AssociatedObject_TextChanged;
            base.OnDetaching();
        }

        protected override void OnChanged()
        {
            
        }

        



        public string Actualtext
        {
            get { return (string)GetValue(ActualtextProperty); }
            set { SetValue(ActualtextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Actualtext.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActualtextProperty =
            DependencyProperty.Register("Actualtext", typeof(string), typeof(PasswordBoxBehaviour), new PropertyMetadata(string.Empty));


    }
}
