// https://atcoder.jp/contests/practice/submissions/12059878

let a = stdin.ReadLine() |> int
let [| b; c |] = stdin.ReadLine().Split() |> Array.map int
let s = stdin.ReadLine()

a + b + c |> printf "%d "
s |> printfn "%s"
