open System
open System.IO

let sectionStarts = 
    seq {
        (1,2)
        yield!
            (1, 2) 
            |> Seq.unfold (fun (distance, start) -> 
                let next = (distance + 1, start + 6 * distance)
                Some (next,next))
    }

let solve (destination: int): int = 
    if destination = 1 then
        1
    else
        sectionStarts 
        |> Seq.takeWhile (fun (distance, start) -> destination >= start)
        |> Seq.last
        |> fst 
        |> (+)1

// CEREMONY CODES
[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let destination = sr.ReadLine() |> int

    // PROCESSING
    let answer = solve destination

    // PRINT
    sw.WriteLine answer

    0