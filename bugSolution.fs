let x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y // Output: 11

x <- 20

printfn "%d" x // Output: 20

//Alternative using a copy of x:

let addOneCopy x = 
  let xCopy = x
  xCopy + 1

let x2 = 10

let y2 = addOneCopy x2

printfn "%d" y2 // Output: 11

x2 <- 20

printfn "%d" x2 // Output: 20

//Output remains consistent even though x2 is updated after the function call