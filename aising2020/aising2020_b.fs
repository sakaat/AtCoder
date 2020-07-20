// https://atcoder.jp/contests/aising2020/submissions/15324338

let N = stdin.ReadLine()
let a = stdin.ReadLine().Split() |> Array.map int

a
|> Array.mapi (fun i x -> (i + 1, x))
|> Array.filter (fun y -> fst y % 2 <> 0 && snd y % 2 <> 0)
|> Array.length
|> stdout.WriteLine
