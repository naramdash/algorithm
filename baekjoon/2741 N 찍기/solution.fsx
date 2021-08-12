open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    sr.ReadLine() |> int
    |> fun i -> seq {1..i}
    |> Seq.iter (fun i -> sw.WriteLine $"{i}")

solve()