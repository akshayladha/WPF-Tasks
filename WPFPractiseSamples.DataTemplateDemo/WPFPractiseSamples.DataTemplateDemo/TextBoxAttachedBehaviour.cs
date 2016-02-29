using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFPractiseSamples.DataTemplateDemo
{
    public static class TextBoxAttachedBehaviour
    {

        public static string GetPasswordText(DependencyObject obj)
        {
            return (string)obj.GetValue(PasswordText);
        }

        public static void SetPasswordText(DependencyObject obj, string value)
        {
            obj.SetValue(PasswordText, value);
        }

        public static readonly DependencyProperty PasswordText =
            DependencyProperty.RegisterAttached("PasswordText",
                typeof(string), typeof(TextBoxAttachedBehaviour),
                new UIPropertyMetadata(string.Empty, OnPasswordTextChanged));

        public static string GetDisplayText(DependencyObject obj)
        {
            return (string)obj.GetValue(DisplayText);
        }

        public static void SetDisplayText(DependencyObject obj, string value)
        {
            obj.SetValue(DisplayText, value);
        }

        public static readonly DependencyProperty DisplayText =
            DependencyProperty.RegisterAttached("DisplayText",
                typeof(string), typeof(TextBoxAttachedBehaviour),
                new UIPropertyMetadata(string.Empty));

        
        private static string actualText = "";

        private static void OnPasswordTextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            TextBox tb = sender as TextBox;
            actualText += tb.Text.Last().ToString();
            if (tb == null) return;
            foreach (var letter in tb.Text)
            {
                SetDisplayText(tb, actualText.Replace("*", ""));
                tb.Text = tb.Text.Replace(letter.ToString(), "*");
            }
        }

    }
}
