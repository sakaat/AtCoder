// https://atcoder.jp/contests/abc153/submissions/11914877

let [| H; N |] = stdin.ReadLine().Split() |> Array.map int

let As =
    stdin.ReadLine().Split()
    |> Array.map int
    |> Array.sum

if H - As <= 0 then "Yes"
else "No"
|> stdout.WriteLine
