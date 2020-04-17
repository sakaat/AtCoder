// https://atcoder.jp/contests/abc139/submissions/12017644

let S = stdin.ReadLine()
let T = stdin.ReadLine()

[ 0..2 ]
|> List.map (fun x ->
    if S.[x] = T.[x] then 1
    else 0)
|> List.sum
|> stdout.WriteLine
