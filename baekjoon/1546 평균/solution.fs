open System
open System.IO

let solve (count: int) (scores: float array): float = 
    let maxScore = scores |> Array.max

    scores
    |> Array.map (fun n -> n / maxScore * 100.0)
    |> Array.sum
    |> (fun sumScore -> sumScore / (float count))

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let count = sr.ReadLine() |> int
    let scores = 
        sr.ReadLine().Split([|' '|]) 
        |> Array.map float

    // PROCESSING
    let answer = solve count scores

    // PRINT
    sw.WriteLine answer

    0