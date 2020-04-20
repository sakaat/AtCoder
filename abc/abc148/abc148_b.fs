// https://atcoder.jp/contests/abc148/submissions/12180640

let N = stdin.ReadLine() |> int
let [| S; T |] = stdin.ReadLine().Split()

[ 0..(N - 1) ]
|> List.map (fun i -> S.[i].ToString() + T.[i].ToString())
|> List.iter stdout.Write
