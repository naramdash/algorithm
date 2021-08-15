open System
open System.IO

let solve (a: int) (b: int): int = 
    let reverse = string >> Seq.rev >> Seq.map string >> String.concat "" >> int
    let revA, revB = reverse a, reverse b
    if revA > revB then revA else revB

[<EntryPoint>]
let main argv = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    // INPUT
    let a, b = 
        sr.ReadLine().Split(" ")
        |> Array.map int
        |> fun a -> a.[0], a.[1]

    // PROCESSING
    let answer = solve a b

    // PRINT
    sw.WriteLine answer

    0