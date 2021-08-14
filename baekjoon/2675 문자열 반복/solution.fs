open System
open System.IO

let solve (count: int, s: string): string = 
    s
    |> Seq.map (string >> String.replicate count)
    |> String.concat ""

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let linesCount = sr.ReadLine() |> int
    let lines = 
        List.init linesCount (fun _ -> sr.ReadLine().Split([|' '|]))
        |> List.map (fun ss -> (Array.head ss |> int), Array.last ss)

    // PROCESSING
    let answers = lines |> List.map solve

    // OUTPUT
    answers |> List.iter sw.WriteLine
    0