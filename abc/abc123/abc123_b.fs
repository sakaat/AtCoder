// https://atcoder.jp/contests/abc123/submissions/12198189

let x = Array.zeroCreate<int> 5

for i in [ 0..4 ] do
    x.[i] <- stdin.ReadLine() |> int

let mutable index = 0
let mutable value = x.[0] % 10

for i in [ 0..4 ] do
    if 0 < x.[i] % 10 && x.[i] % 10 < value then
        value <- x.[i] % 10
        index <- i

let mutable result = 0

for i in [ 0..4 ] do
    if i <> index then result <- result + 10 * int (ceil ((float x.[i]) / 10.))
    else result <- result + x.[i]

result |> stdout.WriteLine
