open System
open System.IO

let convertFromCodeToSec c = 
    match c with 
    | 'A' | 'B' | 'C' -> 3
    | 'D' | 'E' | 'F' -> 4
    | 'G' | 'H' | 'I' -> 5
    | 'J' | 'K' | 'L' -> 6
    | 'M' | 'N' | 'O' -> 7
    | 'P' | 'Q' | 'R' | 'S' -> 8
    | 'T' | 'U' | 'V' -> 9
    | 'W' | 'X' | 'Y' | 'Z' -> 10
    | _ -> 0

let solve (s: string) =
    s |> Seq.map convertFromCodeToSec |> Seq.sum


// CEREMONY CODES
[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let codes = sr.ReadLine()

    // PROCESSING
    let answer = solve codes

    // PRINT
    sw.WriteLine answer

    0