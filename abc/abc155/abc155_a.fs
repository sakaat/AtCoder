// https://atcoder.jp/contests/abc155/submissions/11908774

let [| A; B; C |] = stdin.ReadLine().Split() |> Array.map int

if (A = B && B = C) || (A <> B && B <> C && C <> A) then "No"
else "Yes"
|> stdout.WriteLine
