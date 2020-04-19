// https://atcoder.jp/contests/abc146/submissions/12155746

let [| A; B; X |] = stdin.ReadLine().Split() |> Array.map int64

let rec resolver n =
    if A * n + B * int64 (n.ToString().Length) <= X then min (n * 10L - 1L) ((X - B * int64 (n.ToString().Length)) / A)
    else resolver (n / 10L)

if A + B >= X then 0L
elif A * pown 10L 9 + B * 10L <= X then pown 10L 9
else resolver (pown 10L 9)
|> stdout.WriteLine
