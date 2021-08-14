open System
open System.IO

let solve (numberInString: string): int = 
    numberInString |> Seq.map (string >> Int32.Parse) |> Seq.sum

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let digitCount = sr.ReadLine() |> int
    let numberInString = sr.ReadLine() 

    // PROCESSING
    let answer = solve numberInString

    // PRINT
    sw.WriteLine answer

    0