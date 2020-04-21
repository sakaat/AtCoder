// https://atcoder.jp/contests/abc150/submissions/12184175

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine()

(N - S.Replace("ABC", "+").Length) / 2 |> stdout.WriteLine
