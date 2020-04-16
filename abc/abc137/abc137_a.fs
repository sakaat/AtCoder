// https://atcoder.jp/contests/abc137/submissions/11991041

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

Array.max
    [| A + B
       A - B
       A * B |]
|> stdout.WriteLine
