open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let input = sr.ReadLine() |> int

    let getNextNumber number = 
        let sumOfDigit = 
            let number = 
                if number < 10 then number * 10 else number
            number / 10 + number % 10
        let leftDigit = 
            (number % 10)
        let rightDigit = 
             sumOfDigit % 10
        
        leftDigit * 10 + rightDigit

    let nextNumbers init = 
        init 
        |> Seq.unfold (fun state -> 
            let nextNumber = getNextNumber state
            Some (nextNumber, nextNumber)) 

    nextNumbers input
    |> Seq.tryFindIndex ((=) input)
    |> (fun s -> 
        match s with 
        | Some n -> n + 1
        | None -> 0)
    |> sw.Write

solve()