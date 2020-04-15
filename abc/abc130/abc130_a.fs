// https://atcoder.jp/contests/abc130/submissions/11959304

let [| X; A |] = stdin.ReadLine().Split() |> Array.map int

if X < A then 0
else 10
|> stdout.WriteLine
