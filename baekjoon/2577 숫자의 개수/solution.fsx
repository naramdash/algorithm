open System
open System.IO

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let readInt = sr.ReadLine >> int
    let a, b, c = readInt(), readInt(), readInt()

    let multipled = a * b * c

    let digitCountMap =
        multipled
        |> string
        |> Seq.countBy id
        |> Map.ofSeq

    ['0'..'9']
    |> List.map (fun key -> 
        digitCountMap
        |> Map.tryFind key
        |> (fun o -> 
            match o with 
            | Some v -> v
            | None -> 0))
    |> List.iter Console.WriteLine
    0