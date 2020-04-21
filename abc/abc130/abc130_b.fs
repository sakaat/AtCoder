// https://atcoder.jp/contests/abc130/submissions/11959532

let [| N; X |] = stdin.ReadLine().Split() |> Array.map int
let L = stdin.ReadLine().Split() |> Array.map int

let rec solver s n =
    if s > X then n
    elif n = N then N + 1
    else solver (s + L.[n]) (n + 1)

solver 0 0 |> stdout.WriteLine
