open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let count = sr.ReadLine() |> int

    for i in [1..count] do
        sr.ReadLine().Split([|' '|]) 
        |> Array.map int
        |> (fun a -> sw.WriteLine $"Case #{i}: {a.[0] + a.[1]}")

solve()