open System

//==== Zad 01 ====
let list = 25::14::4::7::[]

let rec aritMean total i list =  
  match list with
  | [] -> total / i                                 // suma liczb / ilosc
  | x::xs -> 
     aritMean (x + total) (i + 1) xs                // sumowanie liczb, oraz ich ilosci
             
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
            let list03 = removeAbove total xs                     // utworzenie nowej listy, bez liczb powyzej sredniej
            if x>total then list03 else x::list03
     removeAbove total list04
  | x::xs -> 
      removeAboveAverage (x + total) (i + 1) xs list04           // sumowanie liczb i ich ilosci

  
removeAboveAverage 0 1 list03 list03


//==== Zad 04 ====

let list04 = 1::2::3::4::5::6::[]

let rec numberOfEvenAndDivBy3 list04 =
    match list04 with
    | [] -> (0, 0)
    | x::xs ->
        let tuple = numberOfEvenAndDivBy3 xs
        if x % 2 = 0 && x % 3 = 0 then (fst tuple + 1, snd tuple + 1)              // gdy podzielna przez 2 i 3 > pierwszy i drugi element w krotce +1
        elif x % 2 = 0 && not(x % 3 = 0) then (fst tuple + 1, snd tuple)           // gdy tylko przez 2, pierwszy element +1
        elif not(x % 2 = 0) && x % 3 = 0 then (fst tuple, snd tuple + 1)           // gdy tylko przez 3, drugi element +1
        else (fst tuple, snd tuple)

numberOfEvenAndDivBy3 list04



//==== Zad 05 ====

let list05 = 1::2::3::4::5::6::[]

let rec listsOfEvenAndDivBy3 list05 =
    match list05 with
    | [] -> ([], [])                          
    | x::xs ->
        let lists = listsOfEvenAndDivBy3 xs
        if x % 2 = 0 && x % 3 = 0 then  (x::fst lists, x::snd lists)           // gdy podzielna przez 2 i 3, dodanie elementu do obu list
        elif x % 2 = 0 && not(x % 3 = 0) then (x::fst lists, snd lists)        // gdy tylko przez 2 zaktualizowanie pierwszej listy
        elif not(x % 2 = 0) && x % 3 = 0 then (fst lists, x::snd lists)        // gdy tylko przez 3 zaktualizowanie drugiej listy
        else (fst lists, snd lists)


listsOfEvenAndDivBy3 list05



//==== Zad 06 ====

let list06 = -1::-9::-3::-5::-4::4::8::11::5::3::4::-6::-6::-7::-5::[]
//let list06 = 1::9::3::[]

let rec longestAP list06 resList tmpList =
    match list06 with
    | [] -> let res = if snd tmpList > snd resList then fst tmpList
                      else fst resList
            let rec rewrite res res2 =
                match res with
                | [] -> res2 
                | x::xs -> rewrite xs (x::res2)     
            rewrite res []
    | x::xs -> 
           if x < 0 then longestAP xs resList (x::fst tmpList, snd tmpList + 1)             // dodawanie kolejnych liczb ujemnych do listy tymczasowej
           elif snd tmpList > snd resList then longestAP xs tmpList ([], 0)                 // gdy liczba dodatnia, porownanie ilosci liczb ujemnych w obecnym najdluzszym ciagu z ciagiem w liscie tymczasowej,
                                                                                            // w przypadku gdy lista tymczasowa posiada dluzszy ciag, zastepienie obecnego najdluzszego ciagu i wyzerowanie listy tymczasowej
           else longestAP xs resList tmpList


longestAP list06 ([] , 0) ([] , 0) 


//==== Zad 07 ====

let list07 = 1::2::3::4::5::6::-1::-2::-3::5::4::3::2::1::[]

let rec numbersSequences list07 tmpList prev res =
    match list07 with
    | [] -> let res2 = tmpList::res
            let rec reverse1 res2 res3 =                                                      // rewersja nadlisty
                match res2 with
                | [] -> res3 
                | x1::xs1 -> let rec reverse2 xs1 x1 res4 =                                   // rewersja list
                               match x1 with
                               | [] -> reverse1 xs1 (res4::res3)
                               | x2::xs2 -> reverse2 xs1 xs2 (x2::res4) 
                             reverse2 xs1 x1 []
            reverse1 res2 [] 
    | x::xs -> if x > 0 && prev >= 0 then numbersSequences xs (x::tmpList) x res              // dodawanie liczb dodatnich(i 0) do listy
               elif x > 0 && prev < 0 then numbersSequences xs (x::[]) x (tmpList::res)       // jesli poprzednia liczba jest ujemna, dodanie elementu do nowej listy, dodanie poprzedniej listy do nadlisty
               elif x < 0 && prev < 0 then numbersSequences xs (x::tmpList) x res             // dodawanie liczb ujemnych  do listy
               elif x < 0 && prev >= 0 then numbersSequences xs (x::[]) x (tmpList::res)      // jesli poprzednia liczba jest dodatnia, dodanie elementu do nowej listy, dodanie poprzedniej listy do nadlisty
               else numbersSequences xs tmpList x res
    
        

numbersSequences list07 [] 0 []