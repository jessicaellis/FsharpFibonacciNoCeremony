// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let fib n = 
    let rec fib n acc =
        match n with
        | 0 -> []
        | 1 -> acc
        | _ -> 
            match acc with 
            | a::b::_ -> (a + b)::acc |> fib (n-1)
            | _ -> (acc |> List.sum)::acc |> fib (n-1)

    [1] |> fib n |> List.rev

let shouldBecome expected n = 
    let result1 = fib n
    printfn "got %A expected %A is correct %b" expected result1 (expected = result1)

[<EntryPoint>]
let main argv =  
    
   (* 1 |> shouldBecome [1]
    2 |> shouldBecome [1; 1]
    3 |> shouldBecome [1; 1; 2]
    4 |> shouldBecome (1::1::2::3::[])
    0 |> shouldBecome [] //*)
    printf "Please choose a number between 1 and 100 : "
    let input = System.Console.ReadLine ()
    let (_, value) = System.Int32.TryParse input
    printfn "" 
    printf "["
    value |> fib |> List.iter (fun v -> printf "%d; " v)
    printfn "]"


    System.Console.ReadKey true |> ignore
    0 // return an integer exit code
