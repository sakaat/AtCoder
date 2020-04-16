// https://atcoder.jp/contests/abc138/submissions/11992427

let N = stdin.ReadLine() |> int

stdin.ReadLine().Split()
|> Array.map float
|> Array.sumBy (fun x -> 1.0 / x)
|> fun x -> 1.0 / x
|> stdout.WriteLine
