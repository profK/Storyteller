using STPluginUtils;
using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ExamplePlugin
{
    public class Plugin :ISTPlugin
    {
        public IconElement Icon
        {
            get
            {
                return new SymbolIcon(Symbol.Audio);
            }
        }
        public string Label {
            get
            {
                return "Sample";
            }
        }

        public RoutedEventHandler OnClick
        {
            get
            {
                return null;
            }
        }
    }
}
