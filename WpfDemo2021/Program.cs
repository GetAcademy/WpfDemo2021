using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemo2021
{
    class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new Window();
            
            var clickerPanel1 = new ClickerPanel();
            var clickerPanel2 = new ClickerPanel();

            var stackPanel = new StackPanel();
            stackPanel.Children.Add(clickerPanel1);
            stackPanel.Children.Add(clickerPanel2);


            window.Content = stackPanel;

            application.Run(window);
        }


    }
}
