// https://atcoder.jp/contests/past201912-open/submissions/13505374

let N = stdin.ReadLine() |> int
let A = Array.zeroCreate<int> N

let mutable d = 0

for i in [ 0..N - 1 ] do
    let a = stdin.ReadLine() |> int
    A.[a - 1] <- A.[a - 1] + 1
    if A.[a - 1] = 2 then d <- a

if d > 0 then d.ToString() + " " + ((A |> Array.findIndex ((=) 0)) + 1).ToString()
else "Correct"
|> stdout.WriteLine
