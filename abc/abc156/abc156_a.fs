// https://atcoder.jp/contests/abc156/submissions/11879087

let [| N; R |] = stdin.ReadLine().Split() |> Array.map int

if N >= 10 then R
else R + 100 * (10 - N)
|> stdout.WriteLine
