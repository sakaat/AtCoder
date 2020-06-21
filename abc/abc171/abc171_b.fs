// https://atcoder.jp/contests/abc171/submissions/14588214

let [| _; K |] = stdin.ReadLine().Split() |> Array.map int

stdin.ReadLine().Split()
|> Array.map int
|> Array.sort
|> Array.take K
|> Array.sum
|> stdout.WriteLine
