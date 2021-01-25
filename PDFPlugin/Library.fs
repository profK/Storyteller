namespace PDFPlugin 

open Plugins
open STPluginUtils
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml

type Plugin =
    interface ISTPlugin with
     member this.Icon = SymbolIcon(Symbol.Audio) :> IconElement
