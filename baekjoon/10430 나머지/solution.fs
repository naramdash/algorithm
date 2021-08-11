open System

[<EntryPoint>]
let main args = 
    let inputs = Console.ReadLine().Split(" ") |> Array.map int
    let a = inputs.[0]
    let b = inputs.[1]
    let c = inputs.[2]
    printfn $"{(a + b) % c}"
    printfn $"{((a % c) + (b % c)) % c}"
    printfn $"{(a * b) % c}"
    printfn $"{((a % c) * (b % c)) % c}"
    0