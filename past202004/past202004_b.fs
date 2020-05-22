// https://atcoder.jp/contests/past202004-open/submissions/13481596

stdin.ReadLine().ToCharArray()
|> Array.groupBy id
|> Array.sortByDescending (fun x -> (snd x).Length)
|> fun x -> fst x.[0]
|> stdout.WriteLine
