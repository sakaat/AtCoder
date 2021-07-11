// https://atcoder.jp/contests/abc209/submissions/24164531

let [| N; X |] = stdin.ReadLine().Split() |> Array.map int

stdin.ReadLine().Split() |> Array.map int
|> fun A -> if Array.sum A - N / 2 <= X then "Yes" else "No"
|> stdout.WriteLine
