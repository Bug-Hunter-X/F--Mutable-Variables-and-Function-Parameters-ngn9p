let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d" z

x <- 100
y <- 200

printf "%d %d" x y

let z2 = add x y
printf "%d" z2