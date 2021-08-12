open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let nsCount = sr.ReadLine() |> int
    let ns = sr.ReadLine().Split([|' '|]) |> Array.map int
    
    printfn $"{ns |> Array.min} {ns |> Array.max}"

solve()