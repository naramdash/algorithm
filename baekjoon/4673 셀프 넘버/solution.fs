open System
open System.IO

let getNextNumber (number: int) : int =
    let digits =
        number
        |> string
        |> Seq.map (string >> Int32.Parse)

    (Seq.sum digits) + number

let rec getNotSelfNumbers (generator: int) (limit: int) (acc: int Set) =
    let nextGenerator = generator |> getNextNumber

    if (acc |> Set.contains nextGenerator)
       || (nextGenerator > limit) then
        acc
    else
        getNotSelfNumbers nextGenerator limit (acc |> Set.add nextGenerator)

let notSelfNumbersTo (limit: int) =
    let rec getNotSelfNumbersTo (generator: int) (limit: int) (acc: int Set) =
        if generator > limit then
            acc
        elif acc |> Set.contains generator then
            getNotSelfNumbersTo (generator + 1) limit acc
        else
            let nextAcc = getNotSelfNumbers generator limit acc
            getNotSelfNumbersTo (generator + 1) limit nextAcc

    getNotSelfNumbersTo 1 limit Set.empty

let selfNumbersTo limit =
    let notSelfNumbers = notSelfNumbersTo limit

    [ 1 .. limit ]
    |> List.filter (fun n -> notSelfNumbers |> Set.contains n |> not)

[<EntryPoint>]
let main argv =
    use sw =
        new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let limit = 10000

    // PROCESSING
    let answer = selfNumbersTo limit

    // PRINT
    answer |> List.iter sw.WriteLine

    0
