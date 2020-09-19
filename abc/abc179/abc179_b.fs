// https://atcoder.jp/contests/abc179/submissions/16890570

let N = stdin.ReadLine() |> int

let D =
    [ for i in [ 0..N - 1 ] do
        yield (stdin.ReadLine().Split() |> Array.map int) ]

let rec solver n i =
    if i = N then "No"
    elif D.[i].[0] = D.[i].[1] then
        if n + 1 = 3 then "Yes"
        else solver (n + 1) (i + 1)
    else solver 0 (i + 1)

solver 0 0 |> stdout.WriteLine
