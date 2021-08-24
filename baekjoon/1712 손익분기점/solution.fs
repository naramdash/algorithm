open System
open System.IO

let (|Minus|Zero|Plus|) income = 
    match income with 
    | income when income > 0 -> Plus
    | income when income = 0 -> Zero
    | _ -> Minus

let solve (fix: int) (costPer: int) (pricePer: int): int option = 
    let incomePer = pricePer - costPer

    match incomePer with
    | Zero | Minus -> None
    | Plus -> Some ((fix / incomePer) + 1)

// CEREMONY CODES
[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let inputs = sr.ReadLine().Split([|' '|]) |> Array.map int
    let a, b, c = inputs.[0], inputs.[1], inputs.[2]

    // PROCESSING
    let answer = solve a b c

    // PRINT
    match answer with
    | Some n -> sw.WriteLine n
    | _ -> sw.WriteLine -1
    |> ignore

    0