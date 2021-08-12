open System
open System.IO

let solve () = 
    use sr = new StreamReader(Console.OpenStandardInput())
    use sw = new StreamWriter(Console.OpenStandardOutput())

    let numbersCount = 9
    let getNumber = sr.ReadLine >> int

    let numbers = 
        Array.init numbersCount (fun _ -> getNumber())

    let rec findMinIndexValue maxIndex maxValue index =
        if index >= numbersCount then
            maxIndex, maxValue
        else 
            let number = numbers |> Array.item index
            if number > maxValue then
                findMinIndexValue index number (index + 1) 
            else 
                findMinIndexValue maxIndex maxValue (index + 1)
    
    let maxIndex, maxValue = findMinIndexValue 0 (numbers |> Array.head) 1 

    sw.WriteLine maxValue
    sw.WriteLine (maxIndex + 1)

solve()