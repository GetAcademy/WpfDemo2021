using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo2021
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;

    namespace WpfDemo2021
    {
        class OldProgram
        {
            private static int _counter = 0;
            private static Label _label;
            [STAThread]
            public static void Mainx(string[] args)
            {
                var application = new Application();
                var window = new Window();
                var button = new Button();
                button.Content = "Trykk på meg";
                _label = new Label();
                _label.Content = "Trykk på knappen";
                var stackPanel = new StackPanel();
                stackPanel.Children.Add(button);
                stackPanel.Children.Add(_label);
                window.Content = stackPanel;

                button.Click += ButtonClick;

                application.Run(window);
            }

            private static void ButtonClick(object sender, RoutedEventArgs e)
            {
                _counter++;
                _label.Content = _counter;
            }
        }
    }

}
