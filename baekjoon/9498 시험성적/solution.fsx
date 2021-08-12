let input = System.Console.ReadLine() |> int

match input with 
| input when input >= 90 -> printfn "A"
| input when input >= 80 -> printfn "B"
| input when input >= 70 -> printfn "C"
| input when input >= 60 -> printfn "D"
| _ -> printfn "F"