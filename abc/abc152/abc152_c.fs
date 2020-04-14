// https://atcoder.jp/contests/abc152/submissions/11925451

let N = stdin.ReadLine() |> int
let P = stdin.ReadLine().Split() |> Array.map int

let rec resolver m (r : int) n =
    if n = N + 1 || m = 1 then r
    elif P.[n] < m then resolver P.[n] (r + 1) (n + 1)
    else resolver m r (n + 1)

resolver (N + 1) 0 0 |> stdout.WriteLine
