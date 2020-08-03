// https://atcoder.jp/contests/abc174/submissions/15666387

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine()

let rec solver l r i =
    if r <= l then i
    elif S.[l] = 'R' then solver (l + 1) r i
    elif S.[r] = 'W' then solver l (r - 1) i
    else solver (l + 1) (r - 1) (i + 1)

solver 0 (S.Length - 1) 0 |> stdout.WriteLine
