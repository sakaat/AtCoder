// https://atcoder.jp/contests/abc174/submissions/15640794

let [| N; D |] = stdin.ReadLine().Split() |> Array.map int64
let D2 = D * D

let rec solver result i =
    if i = N then result
    else
        let [| X; Y |] = stdin.ReadLine().Split() |> Array.map int64
        if X * X + Y * Y <= D2 then solver (result + 1) (i + 1L)
        else solver result (i + 1L)

solver 0 0L |> stdout.WriteLine
