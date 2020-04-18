// https://atcoder.jp/contests/abc142/submissions/12052804

let _ = stdin.ReadLine()

stdin.ReadLine().Split()
|> Array.mapi (fun i x -> (i + 1, int x))
|> Array.sortBy snd
|> Array.map fst
|> Array.iter (printf "%d ")
