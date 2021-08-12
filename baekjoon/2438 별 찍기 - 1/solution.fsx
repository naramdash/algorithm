open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let infiniteStars = Seq.initInfinite (fun _ -> '*')

    sr.ReadLine() |> int
    |> fun i -> seq {1..i}
    |> Seq.map (fun i -> infiniteStars |> Seq.take i )
    |> Seq.iter (fun s -> 
        s |> Seq.iter sw.Write
        sw.WriteLine "")

solve()