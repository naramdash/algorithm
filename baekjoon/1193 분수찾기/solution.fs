open System
open System.IO

let getLineCountAndLastIndex(number: int): int * int = 
    let rec fn (n:int) (acc: int) (number: int) = 
        if acc >= number then 
            n, acc
        else 
            fn (n + 1) (acc + n + 1) number
    fn 1 1 number

let (|Odd|Even|) (number: int) = 
    if number % 2 = 0 then Odd else Even

let solve (index: int): int*int = 
    let (lineCount, lastIndex) = getLineCountAndLastIndex index 
    let diff = lastIndex - index
    match lineCount with
    | Odd -> (lineCount - diff, 1 + diff)
    | Even -> (1 + diff, lineCount - diff)

// CEREMONY CODES
[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let input = sr.ReadLine() |> int

    // PROCESSING
    let (n, d) = solve input

    // PRINT
    sw.WriteLine (sprintf "%d/%d" n d)

    0
