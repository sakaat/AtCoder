// https://atcoder.jp/contests/abc159/submissions/11756804

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

(N * (N - 1) / 2 + M * (M - 1) / 2) |> printfn "%d"
