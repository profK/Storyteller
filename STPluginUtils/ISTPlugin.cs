using System;
using Plugins;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

namespace STPluginUtils
{
    public interface ISTPlugin : IPlugin
    {
        IconElement Icon { get; } 
        string Label { get; }
        RoutedEventHandler OnClick { get; }
    }
}
