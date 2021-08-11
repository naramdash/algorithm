open System

[<EntryPoint>]
let main argv =
    let a = Console.ReadLine() |> int
    let bInString = Console.ReadLine()

    let middleResults =
        bInString
        |> Seq.rev
        |> Seq.map2 (fun i n -> n |> string |> int |> (fun n -> i, n * a)) (Seq.initInfinite id)

    let result =
        middleResults
        |> Seq.fold (fun state (i, n) -> state + n * (pown 10 i)) 0

    middleResults
    |> Seq.iter (fun (i, n) -> n |> string |> Console.WriteLine)

    Console.WriteLine result


    0
