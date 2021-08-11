open System

[<EntryPoint>]
let main args =
    let operations = [ (+); (-); (*); (/); (%) ]

    let array =
        Console.ReadLine().Split(" ") |> Array.map int

    let a = array.[0]
    let b = array.[1]

    operations
    |> List.map (fun op -> op array.[0] array.[1])
    |> List.iter Console.WriteLine

    0
