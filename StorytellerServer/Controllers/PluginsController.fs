namespace StorytellerServer.Controllers

open System
open System.Collections.Generic
open System.IO
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open StorytellerServer

[<ApiController>]
[<Route("plugins")>]
type PluginsController (logger : ILogger<PluginsController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        Directory.GetDirectories("wwwroot/plugins") |> Array.map (fun s -> s.Replace("\\","/"))
        