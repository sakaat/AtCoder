// https://atcoder.jp/contests/abc121/submissions/12277497

let [| H; W |] = stdin.ReadLine().Split() |> Array.map int
let [| h; w |] = stdin.ReadLine().Split() |> Array.map int

(H - h) * (W - w) |> stdout.WriteLine
