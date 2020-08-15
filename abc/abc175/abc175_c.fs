// https://atcoder.jp/contests/abc175/submissions/15967342

let [| X; K; D |] = stdin.ReadLine().Split() |> Array.map int64
let absX = abs X
let r = min K (absX / D)
let X1 = absX - r * D

if (K - r) % 2L = 1L then abs (X1 - D)
else X1
|> stdout.WriteLine
