// https://atcoder.jp/contests/abc177/submissions/16374136

let [| D; T; S |] = stdin.ReadLine().Split() |> Array.map int

if D > T * S then "No"
else "Yes"
|> stdout.WriteLine
