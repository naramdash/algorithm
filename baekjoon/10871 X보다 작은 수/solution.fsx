open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let length, threshold = 
        sr.ReadLine().Split([|' '|])
        |> Array.map int
        |> (fun a -> a.[0], a.[1])

    let numbers = 
        sr.ReadLine().Split([|' '|])
        |> Array.map int

    numbers 
    |> Array.filter ((>) threshold)
    |> Array.map string
    |> String.concat " "
    |> sw.WriteLine

solve()