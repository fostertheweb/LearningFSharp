// Learn more about F# at http://fsharp.org

open System
open FSharp.Data
open Newtonsoft.Json

type Sighting =
  { EventDateTime: DateTime;
    City: String;
    State: String;
    Shape: String;
    Duration: String;
    Summary: String;
    PostedDate: DateTime; }

let createSighting (tableRow: HtmlNode) =
    let tableData = tableRow.CssSelect("td") |> List.map (fun td -> td.InnerText().Trim())
    Console.Write "boop"

[<EntryPoint>]
let main argv =
    let doc = HtmlDocument.Load("http://www.nuforc.org/webreports/ndxe202005.html")
    let sightings = doc.CssSelect("tr") |> List.map createSighting

    0 // return an integer exit code
