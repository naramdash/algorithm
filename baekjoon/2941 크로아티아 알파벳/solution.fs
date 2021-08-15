open System
open System.IO

let croatiaAlphabets = [ "c=";"c-";"dz=";"d-";"lj";"nj";"s=";"z=" ]

let replaceToSpace (croatiaAlphabet: string) (s: string) = 
    s.Replace(croatiaAlphabet, " ")

let replaceAll (s: string): string = 
    croatiaAlphabets
    |> List.map replaceToSpace
    |> List.fold (fun acc replace -> acc >> replace) id
    |> fun f -> f s

let countCroatiaAlphabet s =
    s
    |> replaceAll
    |> Seq.length

// CEREMONY CODES
[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let word = sr.ReadLine()

    // PROCESSING
    let answer = countCroatiaAlphabet word

    // PRINT
    sw.WriteLine answer

    0