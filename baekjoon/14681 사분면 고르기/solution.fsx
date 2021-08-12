let readInt = System.Console.ReadLine >> int
let position = readInt(), readInt()

let getQuadrantFrom position = 
    match position with 
    | (x, y) when (x > 0) && (y > 0) -> Some 1
    | (x, y) when (x < 0) && (y > 0) -> Some 2
    | (x, y) when (x < 0) && (y < 0) -> Some 3
    | (x, y) when (x > 0) && (y < 0) -> Some 4
    | _ -> None

match position |> getQuadrantFrom with 
| Some n -> printfn "%d" n
| None -> printfn "no quadrant"