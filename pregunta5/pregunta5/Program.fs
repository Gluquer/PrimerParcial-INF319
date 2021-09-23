// Más información acerca de F# en http://fsharp.org
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
 
[<EntryPoint>]
let main argv = 
    
    let n=6
    let m=2
    let mutable r = 0
    for i = 1 to n do
       r <- r + m
    printfn "Resultado :%i " r
    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
