// https://atcoder.jp/contests/abc147/submissions/12160720

let S = stdin.ReadLine().ToCharArray()

[| 0..S.Length / 2 - 1 |]
|> Array.filter (fun i -> S.[i] <> S.[S.Length - 1 - i])
|> Array.length
|> stdout.WriteLine
