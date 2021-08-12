open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    [1..9] |> List.iter(fun i -> printfn $"{n} * {i} = {n * i}")
    0