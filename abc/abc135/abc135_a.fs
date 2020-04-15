// https://atcoder.jp/contests/abc135/submissions/11954155

stdin.ReadLine().Split()
|> Array.map int
|> fun a ->
    if (a.[0] - a.[1]) % 2 = 0 then (a.[0] + a.[1]) / 2 |> string
    else "IMPOSSIBLE"
|> stdout.WriteLine
