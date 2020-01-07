open System

//==== Zad 01 ====
let list = 25::14::4::7::[]

let rec aritMean total i list = 
  match list with
  | [] -> total / i
  | x::xs -> 
     let ntotal = x + total
     aritMean ntotal (i+1) xs
             
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

let list03 = 25::14::4::7::[]

let rec removeAboveAverage total i list03 = 
  match list03 with
   | [] -> total / i
   | x::xs -> 
      let ntotal = x + total
      removeAboveAverage ntotal (i+1) xs;
  match list03 with
   | [] -> printfn "test1", 5
   | x::xs -> printfn "test2", 5

  

             
removeAboveAverage 0 0 list03