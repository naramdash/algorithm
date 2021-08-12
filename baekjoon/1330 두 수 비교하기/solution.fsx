open System

let inputs = Console.ReadLine().Split(" ") |> Array.map int
let a = inputs.[0]
let b = inputs.[1]

if a > b then
    printfn ">"
elif a = b then
    printfn "=="
else
    printfn "<"