open System


//==== Zad 01 ====

let list01 = [1; 1; 1; 2; 2; 1; 1; 3; 1; 2; 2; 2; 2; 2]


let compress list =
   let rec loop list lastAdded newList =
       match list with
       | [] -> let res = lastAdded::newList
               List.rev res
       | x::xs -> if lastAdded <> x then loop xs x (lastAdded::newList)
                  else loop xs x newList
   loop list (list.Item(0)) []


compress list01


//==== Zad 02 ====
let list02 = [1; 1; 1; 2; 2; 1; 1; 3; 1; 2; 2]

let pack list =
    let rec loop list prev tmpList resList =
        match list with
        | [] -> let resList = tmpList::resList
                List.rev resList
        | x::xs -> if prev = x then loop xs x (x::tmpList) resList
                   else loop xs x (x::[]) (tmpList::resList)
    loop list (list.Item(0)) [] []

pack list02



//==== Zad 03 ====
let list03 = [5; -9; 15; 22; 72; -31; 12; 33; -21; 72; 42]

let mean list = (List.fold (+) 0 list) / (list.Length)

mean list03


//==== Zad 04 ====

let list04 = [5; 9; -15; 22; 72; -31; 12; 33; -21; 72; 42]

let findMinMax list = ((List.min list), (List.max list))

findMinMax list04

//==== Zad 05 ====

let list05 = [5; 9; -15; 22; 72; -31; 12; 33; -21; 72; 42]

let removeAboveMean list =list |> List.filter (fun n -> n<((List.fold (+) 0 list) / (list.Length))) 

removeAboveMean list05
