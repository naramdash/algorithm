open System
open System.IO

let solve (word: string): string = 
    let counts = 
        word.ToUpper()
        |> Seq.countBy id
        |> Seq.sortByDescending (fun (c, count) -> count)
        |> Seq.toArray

    match counts with 
    | c when c |> Array.length = 1 -> c |>  Array.head |> fst |> string
    | c when (snd c.[0]) = (snd c.[1]) -> "?"
    | c -> c |> Array.head |> fst |> string

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let word = sr.ReadLine()

    // PROCESSING
    let answer = solve word

    // PRINT
    sw.WriteLine answer

    0