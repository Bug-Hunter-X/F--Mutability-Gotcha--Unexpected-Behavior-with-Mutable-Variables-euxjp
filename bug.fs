let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y

//Modify x
x <- 20

printfn "%d" x