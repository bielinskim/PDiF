open System

//==== Zad 1 a) ====
let sqrSideLength = 5.0;;

let squareArea side : float = side * side;;
let sqrAreaValue = squareArea sqrSideLength;;                    
printfn "Pole kwadratu: %f" sqrAreaValue;;

let squarePerimeter side : float = 4.0 * side;;
let sqrPerimeterValue = squarePerimeter sqrSideLength;;   
printfn "Obwód kwadratu: %f" sqrPerimeterValue;;


//==== Zad 1 b) ====
let rectSideALength = 4.0;;
let rectSideBLength = 6.0;;

let rectangleArea sideA sideB : float = sideA * sideB;;
let rectAreaValue = rectangleArea rectSideALength rectSideBLength;;
printfn "Pole prostokąta: %f" rectAreaValue;;

let rectanglePerimeter sideA sideB : float = 2.0 * sideA + 2.0 * sideB;;
let rectPerimeterValue = rectanglePerimeter rectSideALength rectSideBLength;;
printfn "Obwód prostokąta: %f" rectPerimeterValue;;


//==== Zad 1 c) ====
let trianSideALength = 4.0;;
let trianSideBlength = 6.0;;
let trianHeight = 5.66;;

let triangleArea sideA height : float = sideA * height / 2.0 ;;
let trianAreaValue = triangleArea trianSideALength trianHeight;;
printfn "Pole trójkata równoramiennego: %f" trianAreaValue;;

let trianglePerimeter sideA sideB : float = sideA + 2.0 * sideB;;
let trianPerimeterValue = trianglePerimeter trianSideALength trianSideBlength;;
printfn "Obwód trojkąta równoramiennego: %f" trianPerimeterValue;;


//==== Zad 1 d) ====
let circleRadius = 5.0;;

let circleArea radius : float = 3.14 * radius ** 2.0;;
let circleAreaValue = circleArea circleRadius;;
printfn "Pole koła: %f" circleAreaValue;;

let circlePerimeter radius : float = 2.0 * 3.14 * radius;;
let circlePerimeterValue = circlePerimeter circleRadius;;
printfn "Obwód koła %f" circlePerimeterValue;;

[<EntryPoint>]
let main argv =
 
   
    0;; // return an integer exit code
