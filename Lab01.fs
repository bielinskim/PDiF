open System

//==== Zad 1 a) ====
let sqrSideLength = 5.0

let squareArea side : float = side * side
let sqrAreaValue = squareArea sqrSideLength            
printfn "Pole kwadratu: %f" sqrAreaValue

let squarePerimeter side : float = 4.0 * side
let sqrPerimeterValue = squarePerimeter sqrSideLength 
printfn "Obwód kwadratu: %f" sqrPerimeterValue


//==== Zad 1 b) ====
let rectSideALength = 4.0
let rectSideBLength = 6.0

let rectangleArea sideA sideB : float = sideA * sideB
let rectAreaValue = rectangleArea rectSideALength rectSideBLength
printfn "Pole prostokąta: %f" rectAreaValue

let rectanglePerimeter sideA sideB : float = 2.0 * sideA + 2.0 * sideB
let rectPerimeterValue = rectanglePerimeter rectSideALength rectSideBLength
printfn "Obwód prostokąta: %f" rectPerimeterValue


//==== Zad 1 c) ====
let trianSideALength = 4.0
let trianSideBlength = 6.0
let trianHeight = 5.66

let triangleArea sideA height : float = sideA * height / 2.0
let trianAreaValue = triangleArea trianSideALength trianHeight
printfn "Pole trójkata równoramiennego: %f" trianAreaValue

let trianglePerimeter sideA sideB : float = sideA + 2.0 * sideB
let trianPerimeterValue = trianglePerimeter trianSideALength trianSideBlength
printfn "Obwód trojkąta równoramiennego: %f" trianPerimeterValue


//==== Zad 1 d) ====
let circleRadius = 5.0

let circleArea radius : float = 3.14 * radius ** 2.0
let circleAreaValue = circleArea circleRadius
printfn "Pole koła: %f" circleAreaValue

let circlePerimeter radius : float = 2.0 * 3.14 * radius
let circlePerimeterValue = circlePerimeter circleRadius
printfn "Obwód koła %f" circlePerimeterValue


//==== Zad 2 a) ====
let n = 5
let rec factorial n = if n < 2 then 1 
                      else n * factorial (n - 1)
printfn "Wartość %i! = : %i" n (factorial n)


//==== Zad 2 b) ====
let m = 8
let rec fib n = if n < 2 then 1
                else fib (n - 2) + fib(n - 1)
printfn "%i wyraz ciagu Fibonacciego to: %i" m (fib m)


//==== Zad 2 c) ====
let a = 1122
let b = 867
let rec gcdbs a b = if a > b then gcdbs (a-b) b
                    elif b > a then gcdbs (b-a) a
                    else a
printfn "NWD liczb a= %i i b= %i to %i" a b (gcdbs a b)


//==== Zad 2 d) ====
let c = 610
let d = 377
let rec gcdbea a b = if b = 0 then a
                     else gcdbea b (a % b)
printfn "NWD liczb a= %i i b= %i to %i" c d (gcdbea c d)


//==== Zad 2 e) ====
let number = 12345
let rec sumOfDigits number = if number < 10 then number % 10
                             else number % 10 + sumOfDigits(number/10)
printfn "Suma cyfr %i wynosi %i" number (sumOfDigits number)

[<EntryPoint>]
let main argv =
 
   
    0 // return an integer exit code
