open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let infiniteStars = Seq.initInfinite (fun _ -> '*')
    let infiniteSpaces = Seq.initInfinite (fun _ -> ' ')

    let lineCount = sr.ReadLine() |> int

    seq {1..lineCount}
    |> Seq.map (fun i -> 
        infiniteSpaces |> Seq.take (lineCount - i) , infiniteStars |> Seq.take i )
    |> Seq.iter (fun (spaces, stars) -> 
        spaces |> Seq.iter sw.Write
        stars |> Seq.iter sw.Write
        sw.WriteLine "")

solve()