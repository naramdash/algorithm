open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    while not sr.EndOfStream do
        sr.ReadLine().Split([|' '|]) 
        |> Array.map int
        |> (fun a -> 
            if a |> Array.exists ((<) 0) then 
                sw.WriteLine $"{a |> Array.sum}")

solve()