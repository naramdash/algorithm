open System
open System.IO

let solve (paragraph: string): int = 
    if paragraph |> String.IsNullOrWhiteSpace then
        0
    else 
        paragraph.Trim().Split(" ") |> Array.length


[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let paragraph = sr.ReadLine()

    // PROCESSING
    let answer = solve paragraph

    // PRINT
    sw.WriteLine answer

    0