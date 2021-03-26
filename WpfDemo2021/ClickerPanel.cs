using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemo2021
{
    class ClickerPanel : StackPanel
    {
        private  int _counter = 0;
        private  Label _label;

        public ClickerPanel() 
        {
            var button = new Button();
            button.Content = "Trykk på meg";
            _label = new Label();
            _label.Content = "Trykk på knappen";

            Children.Add(button);
            Children.Add(_label);
            
            button.Click += ButtonClick;
        }

        private  void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
    }
}
