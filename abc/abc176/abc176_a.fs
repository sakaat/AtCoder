// https://atcoder.jp/contests/abc176/submissions/16152158

let [| N; X; T |] = stdin.ReadLine().Split() |> Array.map int

(N / X + if N % X = 0 then 0
         else 1) * T |> stdout.WriteLine
