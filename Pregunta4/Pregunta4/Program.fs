// Más información acerca de F# en http://fsharp.org
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

[<EntryPoint>]
let main argv = 
    let list1 = [ 1; 2; 3; 4; 66; 3 ]
    let listpares = []
    let listimpares = []
    printf "%A" list1
    let listpares = List.filter (fun x -> x % 2 = 0) list1
    let listimpares = List.filter (fun x -> x % 2 = 1) list1   
    printfn ""
    printfn "Lista Pares: %A" listpares
    printfn "Lista Impares: %A" listimpares
    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
    

    
