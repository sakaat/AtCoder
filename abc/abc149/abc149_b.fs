// https://atcoder.jp/contests/abc149/submissions/12183880

let [| A; B; K |] = stdin.ReadLine().Split() |> Array.map int64

if K <= A then (A - K, B)
elif K <= A + B then (0L, B - (K - A))
else (0L, 0L)
||> printfn "%d %d"
