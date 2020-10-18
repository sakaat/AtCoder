// https://atcoder.jp/contests/abc180/submissions/17491157

let N = stdin.ReadLine() |> int
let x = stdin.ReadLine().Split() |> Array.map double

x
|> Array.map abs
|> Array.sum
|> stdout.WriteLine
x
|> Array.map (fun a -> a * a)
|> Array.sum
|> sqrt
|> stdout.WriteLine
x
|> Array.map abs
|> Array.max
|> stdout.WriteLine
