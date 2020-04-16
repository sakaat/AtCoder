// https://atcoder.jp/contests/abc132/submissions/11967575

stdin.ReadLine().ToCharArray()
|> Array.sort
|> fun S ->
    if S.[0] = S.[1] && S.[1] <> S.[2] && S.[2] = S.[3] then "Yes"
    else "No"
|> stdout.WriteLine
