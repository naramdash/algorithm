open System
open System.IO

let getScore (os: string): int =
    os.Length
    |> fun count -> [count .. -1 .. 1]
    |> List.sum

let solve (oxs: string): int = 
    oxs.Split("X")
    |> Array.filter (String.IsNullOrWhiteSpace >> not)
    |> Array.map getScore
    |> Array.sum

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let count = sr.ReadLine() |> int
    let oxss = Array.init count (fun _ -> sr.ReadLine())

    // PROCESSING
    let answers = oxss |> Array.map solve

    // PRINT
    answers |> Array.iter sw.WriteLine

    0