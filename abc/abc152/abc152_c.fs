// https://atcoder.jp/contests/abc152/submissions/11925451

let N = stdin.ReadLine() |> int
let P = stdin.ReadLine().Split() |> Array.map int

let rec solver m (r : int) n =
    if n = N + 1 || m = 1 then r
    elif P.[n] < m then solver P.[n] (r + 1) (n + 1)
    else solver m r (n + 1)

solver (N + 1) 0 0 |> stdout.WriteLine
