// https://atcoder.jp/contests/abc167/submissions/13103963

let [| A; B; C; K |] = stdin.ReadLine().Split() |> Array.map int

if A >= K then K
elif A + B >= K then A
else A - (K - A - B)
|> stdout.WriteLine
