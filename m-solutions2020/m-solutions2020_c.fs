// https://atcoder.jp/contests/m-solutions2020/submissions/15465089

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int

[| K..(N - 1) |]
|> Array.map (fun x ->
    if A.[x - K] < A.[x] then "Yes"
    else "No")
|> Array.iter stdout.WriteLine
