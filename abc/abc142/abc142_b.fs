// https://atcoder.jp/contests/abc142/submissions/12050946

let [| _; K |] = stdin.ReadLine().Split() |> Array.map int

stdin.ReadLine().Split()
|> Array.map int
|> Array.filter (fun x -> x >= K)
|> Array.length
|> stdout.WriteLine
