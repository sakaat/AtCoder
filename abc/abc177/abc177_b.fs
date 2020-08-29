// https://atcoder.jp/contests/abc177/submissions/16373675

let S = stdin.ReadLine()
let T = stdin.ReadLine()

let mutable result = 0

for i in [ 0..S.Length - T.Length ] do
    let mutable count = 0
    for j in [ 0..T.Length - 1 ] do
        if S.[i + j] = T.[j] then count <- count + 1
    if count > result then result <- count

T.Length - result |> stdout.WriteLine
