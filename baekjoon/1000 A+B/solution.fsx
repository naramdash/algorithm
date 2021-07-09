open System

[<EntryPoint>]
let main args =
    Console.ReadLine().Split [|' '|]
    |> Array.map int
    |> Array.sum
    |> fun x -> Console.WriteLine(x)

    0