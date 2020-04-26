// https://atcoder.jp/contests/abc164/submissions/12399036

let [| S; W |] = stdin.ReadLine().Split() |> Array.map int

if S > W then "safe"
else "unsafe"
|> stdout.WriteLine
