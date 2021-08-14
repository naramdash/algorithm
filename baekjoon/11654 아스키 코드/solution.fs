open System
open System.IO

let solve (c: char): int = 
    c |> int

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let char = sr.ReadLine() |> Seq.head

    // PROCESSING
    let answer = solve char

    // PRINT
    sw.WriteLine answer

    0