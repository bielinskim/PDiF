open System

//==== Zad 01 ====
let list = 25::14::4::7::[]

let rec aritMean total i list = 
  match list with
  | [] -> total / i
  | x::xs -> 
     aritMean (x + total) (i + 1) xs
             
aritMean 0 0 list

//==== Zad 02 ====
let list02 = 15::-33::44::-7::53::-25::[]

let rec findMinMax min max list02 =
  match list02 with
  | [] -> (min, max)
  | x::xs -> 
     if min = 0 && max = 0 then findMinMax x x xs
     elif x > max then findMinMax min x xs
     elif x < min then findMinMax x max xs
     else findMinMax min max xs

   
findMinMax 0 0 list02


//==== Zad 03 ====

let list03 = 25::14::4::7::[]

let rec removeAboveAverage total i list03 list04 = 
  match list03 with
  | [] -> 
     let total = total / i
     let rec removeAbove total list04 =
       match list04 with
       | [] -> []
       | x::xs -> 
            let list03 = removeAbove total xs
            if x>total then list03 else x::list03
     removeAbove total list04
  | x::xs -> 
      removeAboveAverage (x + total) (i + 1) xs list04

  
removeAboveAverage 0 1 list03 list03


