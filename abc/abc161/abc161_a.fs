// https://atcoder.jp/contests/abc161/submissions/11738710

let input = stdin.ReadLine().Split()
let X = input.[0]
let Y = input.[1]
let Z = input.[2]

[ Z; X; Y ]
|> String.concat (" ")
|> printfn "%s"
