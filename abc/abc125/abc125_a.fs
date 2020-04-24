// https://atcoder.jp/contests/abc125/submissions/12275689

let [| A; B; T |] = stdin.ReadLine().Split() |> Array.map int

T / A * B |> stdout.WriteLine
