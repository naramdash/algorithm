open System
open System.IO

let solve (numbers: int list): int = 
    0

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let readInt = sr.ReadLine >> int
    let numbers = List.init 10 (fun _ -> readInt())

    // PROCESSING
    let answer = solve numbers

    // PRINT
    sw.WriteLine answer

    0