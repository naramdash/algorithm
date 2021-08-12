let isMultipleOf factor number = 
    number % factor = 0

let isLeapYear year = 
    match year with 
    | year when year |> isMultipleOf 400 -> true
    | year when (year |> isMultipleOf 4) && not (year |> isMultipleOf 100) -> true
    | _ -> false

let input = System.Console.ReadLine() |> int
let result = isLeapYear input

printfn "%d" (if result then 1 else 0)