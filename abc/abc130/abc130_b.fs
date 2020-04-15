// https://atcoder.jp/contests/abc130/submissions/11959532

let [| N; X |] = stdin.ReadLine().Split() |> Array.map int
let L = stdin.ReadLine().Split() |> Array.map int

let rec resolver s n =
    if s > X then n
    elif n = N then N + 1
    else resolver (s + L.[n]) (n + 1)

resolver 0 0 |> stdout.WriteLine
