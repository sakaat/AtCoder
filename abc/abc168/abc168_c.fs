// https://atcoder.jp/contests/abc168/submissions/13389077

open System

let [| A; B; H; M |] = stdin.ReadLine().Split() |> Array.map float

let hour = 30. * H + 0.5 * M
let minute = 6. * M
let angle = abs (hour - minute)
let radian = angle * Math.PI / 180.

A * A + B * B - 2. * A * B * Math.Cos radian
|> Math.Sqrt
|> stdout.WriteLine
