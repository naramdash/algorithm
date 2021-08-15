open System
open System.IO

let isGroupWord (word: string) = 
    word
    |> Seq.pairwise
    |> Seq.filter (fun (a,b ) -> a <> b)
    |> Seq.countBy (fun (a,_) -> a)
    |> Map.ofSeq
    |> (fun map -> 
            if map |> Map.containsKey (word |> Seq.last) then
                false
            elif map |> Map.exists (fun key value -> value > 1) then
                false
            else 
                true)

// CEREMONY CODES
[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let lineCount = sr.ReadLine() |> int
    let lines = List.init lineCount (fun _ -> sr.ReadLine())

    // PROCESSING
    let answer = lines |> List.map isGroupWord |> List.filter id |> List.length

    // PRINT
    sw.WriteLine answer

    0