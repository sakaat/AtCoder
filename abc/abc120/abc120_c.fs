// https://atcoder.jp/contests/abc120/submissions/16643101

let S = stdin.ReadLine().ToCharArray()

S
|> Array.sumBy (fun c -> int c - int '0')
|> fun x -> 2 * min x (S.Length - x)
|> printfn "%d"
