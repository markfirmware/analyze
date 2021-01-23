open System
open FSharp.Data.GraphQL

type GraphQlClient = GraphQLProvider<"https://api.github.com/graphql">

type A = { X: int }
let a = { X = 0 }

let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#"
    printfn "Hello world %s" message
    0