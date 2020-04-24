// https://atcoder.jp/contests/abc125/submissions/12276077

let _ = stdin.ReadLine()
let V = stdin.ReadLine().Split() |> Array.map int
let C = stdin.ReadLine().Split() |> Array.map int

Array.zip V C
|> Array.map (fun x -> fst x - snd x)
|> Array.filter (fun x -> x > 0)
|> Array.sum
|> stdout.WriteLine
