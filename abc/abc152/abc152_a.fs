// https://atcoder.jp/contests/abc152/submissions/11921603

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

if N = M then "Yes"
else "No"
|> stdout.WriteLine
