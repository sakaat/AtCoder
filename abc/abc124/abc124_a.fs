// https://atcoder.jp/contests/abc124/submissions/12208254

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

if A > B then 2 * A - 1
elif B > A then 2 * B - 1
else A + B
|> stdout.WriteLine
