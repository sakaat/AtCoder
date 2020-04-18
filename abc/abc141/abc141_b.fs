// https://atcoder.jp/contests/abc141/submissions/12023896

stdin.ReadLine().ToCharArray()
|> Array.mapi (fun i x ->
    if (i % 2 = 0 && x = 'L') || (i % 2 = 1 && x = 'R') then 1
    else 0)
|> Array.sum
|> fun s ->
    if s > 0 then "No"
    else "Yes"
|> stdout.WriteLine
