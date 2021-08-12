System.Console.ReadLine()
|> int
|> (fun n -> seq {1..n})
|> Seq.sum
|> System.Console.WriteLine