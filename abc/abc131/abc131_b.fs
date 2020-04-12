// https://atcoder.jp/contests/abc131/submissions/11785599

let [| N; L |] = stdin.ReadLine().Split() |> Array.map int

let list = [ 1..N ] |> List.map (fun i -> L + i - 1)
let sum = list |> List.sum
let min = list |> List.minBy abs

sum - min |> stdout.WriteLine
