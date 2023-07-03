using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace W5VisibilityAttachedProp
{
    public class VisibilityProp
    {
        public static bool GetToggleVisibility(DependencyObject obj)
        {
            return (bool)obj.GetValue(ToggleVisibilityProperty);
        }

        public static void SetToggleVisibility(DependencyObject obj, int value)
        {
            obj.SetValue(ToggleVisibilityProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToggleVisibilityProperty =
            DependencyProperty.RegisterAttached("ToggleVisibility", typeof(bool), typeof(VisibilityProp), new PropertyMetadata(true, (a,b) =>
            {
                var CurrentValue = a.GetValue(ToggleVisibilityProperty);

                UIElement t = (UIElement)a;
                if (CurrentValue != null && CurrentValue is true)
                    t.Visibility = Visibility.Visible;
                else if(CurrentValue != null && CurrentValue is false)
                    t.Visibility = Visibility.Collapsed;
            }));


    }
}
