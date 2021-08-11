open System

[<EntryPoint>]
let main args =
    Console.ReadLine().Split(" ")
    |> Array.map int
    |> (fun array -> array.[0] - array.[1])
    |> (fun diff -> diff.ToString())
    |> Console.WriteLine
    0