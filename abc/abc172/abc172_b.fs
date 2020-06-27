// https://atcoder.jp/contests/abc172/submissions/14779160

let S = stdin.ReadLine().ToCharArray()
let T = stdin.ReadLine().ToCharArray()

Array.zip S T
|> Array.filter (fun (s, t) -> s <> t)
|> Array.length
|> stdout.WriteLine
