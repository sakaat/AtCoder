// https://atcoder.jp/contests/abc122/submissions/12205358

let [| N; Q |] = stdin.ReadLine().Split() |> Array.map int
let S = stdin.ReadLine()

let lr = Array.zeroCreate<int []> Q

for i in [ 0..Q - 1 ] do
    lr.[i] <- stdin.ReadLine().Split() |> Array.map int

let t = Array.zeroCreate<int> (N + 1)

for i in [ 1..N - 1 ] do
    if S.[i - 1] = 'A' && S.[i] = 'C' then t.[i + 1] <- t.[i] + 1
    else t.[i + 1] <- t.[i]

for i in [ 0..Q - 1 ] do
    t.[lr.[i].[1]] - t.[lr.[i].[0]] |> stdout.WriteLine
