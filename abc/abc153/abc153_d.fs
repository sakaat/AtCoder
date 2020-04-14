// https://atcoder.jp/contests/abc153/submissions/11915331

let H = stdin.ReadLine() |> float
let l = (log H) / (log 2.0) |> int

pown 2L (l + 1) - 1L |> stdout.WriteLine
