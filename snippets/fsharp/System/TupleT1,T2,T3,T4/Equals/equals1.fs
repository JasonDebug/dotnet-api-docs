﻿module equals1

// <Snippet1>
open System

let temperatures = 
    [| Tuple.Create(DateTime(2009, 1, 16), 3.0, 5.0, 4.0)
       Tuple.Create(DateTime(2009, 4, 22), 9.0, 14.0, 11.0)
       Tuple.Create(DateTime(2009, 4, 22), 9.0, 14.0, 10.0)
       Tuple.Create(DateTime(2009, 6, 1), 23.0, 28.0, 21.0)
       Tuple.Create(DateTime(2009, 4, 22), 9.0, 14.0, 11.0)
       Tuple.Create(DateTime(2009, 9, 6), 25.0, 30.0, 25.0) |]

// Compare each item with every other item for equality.
for ctr = 0 to temperatures.Length - 1 do
    let temperatureInfo = temperatures[ctr]
    for ctr2 = ctr + 1 to temperatures.Length - 1 do
        printfn $"{temperatureInfo} = {temperatures[ctr2]}: {temperatureInfo.Equals temperatures[ctr2]}"
    printfn ""   
// The example displays the following output:
//    (1/16/2009 12:00:00 AM, 3, 5, 4) = (4/22/2009 12:00:00 AM, 9, 14, 11): False
//    (1/16/2009 12:00:00 AM, 3, 5, 4) = (4/22/2009 12:00:00 AM, 9, 14, 10): False
//    (1/16/2009 12:00:00 AM, 3, 5, 4) = (6/1/2009 12:00:00 AM, 23, 28, 21): False
//    (1/16/2009 12:00:00 AM, 3, 5, 4) = (4/22/2009 12:00:00 AM, 9, 14, 11): False
//    (1/16/2009 12:00:00 AM, 3, 5, 4) = (9/6/2009 12:00:00 AM, 25, 30, 25): False
//    
//    (4/22/2009 12:00:00 AM, 9, 14, 11) = (4/22/2009 12:00:00 AM, 9, 14, 10): False
//    (4/22/2009 12:00:00 AM, 9, 14, 11) = (6/1/2009 12:00:00 AM, 23, 28, 21): False
//    (4/22/2009 12:00:00 AM, 9, 14, 11) = (4/22/2009 12:00:00 AM, 9, 14, 11): True
//    (4/22/2009 12:00:00 AM, 9, 14, 11) = (9/6/2009 12:00:00 AM, 25, 30, 25): False
//    
//    (4/22/2009 12:00:00 AM, 9, 14, 10) = (6/1/2009 12:00:00 AM, 23, 28, 21): False
//    (4/22/2009 12:00:00 AM, 9, 14, 10) = (4/22/2009 12:00:00 AM, 9, 14, 11): False
//    (4/22/2009 12:00:00 AM, 9, 14, 10) = (9/6/2009 12:00:00 AM, 25, 30, 25): False
//    
//    (6/1/2009 12:00:00 AM, 23, 28, 21) = (4/22/2009 12:00:00 AM, 9, 14, 11): False
//    (6/1/2009 12:00:00 AM, 23, 28, 21) = (9/6/2009 12:00:00 AM, 25, 30, 25): False
//    
//    (4/22/2009 12:00:00 AM, 9, 14, 11) = (9/6/2009 12:00:00 AM, 25, 30, 25): False
// </Snippet1>