// https://atcoder.jp/contests/abc143/submissions/12054420

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine().ToCharArray()

S
|> Array.pairwise
|> Array.filter (fun (x, y) -> x = y)
|> Array.length
|> fun d -> N - d
|> stdout.WriteLine
