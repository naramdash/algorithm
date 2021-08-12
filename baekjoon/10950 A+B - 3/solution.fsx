let getAB = 
    System.Console.ReadLine
    >> (fun s -> s.Split([|' '|]))
    >> Array.map int
    >> (fun inputs -> inputs.[0], inputs.[1])

let problemCount = System.Console.ReadLine() |> int
for _ in [1..problemCount] do
    let a, b = getAB()
    printfn "%d" (a + b)