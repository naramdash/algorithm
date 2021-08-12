open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    while not sr.EndOfStream do
        sr.ReadLine().Split([|' '|]) 
        |> Array.map int
        |> (fun a -> sw.WriteLine $"{a.[0] + a.[1]}")

solve()