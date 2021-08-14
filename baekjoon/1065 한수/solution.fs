open System
open System.IO

let isHansu (number: int): bool = 
    let digits = number |> string |> Seq.map (string >> Int32.Parse)

    let diffs = 
        digits
        |> Seq.pairwise
        |> Seq.map (fun (a,b) -> a - b)
        |> Seq.cache

    if diffs |> Seq.length = 0 then 
        true
    else
        diffs |> Seq.distinct |> Seq.length |> (=) 1

let countHansusTo (limit: int): int = 
    [1..limit]
    |> List.filter isHansu
    |> List.length

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let number = sr.ReadLine() |> int

    // PROCESSING
    let answer = countHansusTo number

    // PRINT
    sw.WriteLine answer

    0