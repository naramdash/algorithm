open System
open System.IO

let solve (input: string) : string = 
    ['a'..'z']
    |> Seq.map (fun alphabet -> 
        input |> Seq.tryFindIndex ((=) alphabet) |> (fun o -> 
            match o with 
            | Some index -> $"{index}"
            | None -> "-1"))
    |> String.concat " "

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let input = sr.ReadLine()

    // PROCESSING
    let answer = solve input

    // PRINT
    sw.WriteLine answer

    0