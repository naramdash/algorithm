let inputs = System.Console.ReadLine().Split(" ") |> Array.map int
let hour, minute = inputs.[0], inputs.[1]

let getFastAlarm hour minute = 
    let fastAlarmByMinute = 
        match hour * 60 + minute with 
        | dayByMinute when dayByMinute < 45 -> dayByMinute + 24 * 60 - 45
        | dayByMinute -> dayByMinute - 45

    fastAlarmByMinute / 60, fastAlarmByMinute % 60

let fastHour, fastMinute = getFastAlarm hour minute

printfn $"{fastHour} {fastMinute}"