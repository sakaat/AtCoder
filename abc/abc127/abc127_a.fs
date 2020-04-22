// https://atcoder.jp/contests/abc127/submissions/12233536

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

if A < 6 then 0
elif 6 <= A && A <= 12 then B / 2
else B
|> stdout.WriteLine
