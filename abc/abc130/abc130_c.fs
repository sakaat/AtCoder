// https://atcoder.jp/contests/abc130/submissions/11959844

let [| W; H; x; y |] = stdin.ReadLine().Split() |> Array.map float

W * H / 2.0 |> printf "%f "
if 2.0 * x = W && 2.0 * y = H then 1
else 0
|> printfn "%d"
