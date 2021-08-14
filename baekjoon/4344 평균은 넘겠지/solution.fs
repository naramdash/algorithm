open System
open System.IO

let solve (count: int, scores: int array): string = 
    let scores = scores |> Array.map float
    let average = scores |> Array.average
    
    scores 
    |> Array.filter ((<) average)
    |> Array.length
    |> (fun length -> 
            let length, count = float length, float count
            length / count * 100.0)
    |> sprintf "%0.3f%%"

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let count = sr.ReadLine() |> int
    let scoress = 
        (fun _ -> sr.ReadLine().Split([|' '|]) |> Array.map int)
        |> List.init count 
        |> List.map (fun ns -> Array.head ns, Array.tail ns)

    // PROCESSING
    let answers = scoress |> List.map solve

    // PRINT
    answers |> List.iter sw.WriteLine

    0