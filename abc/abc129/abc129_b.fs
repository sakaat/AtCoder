// https://atcoder.jp/contests/abc129/submissions/12152057

let N = stdin.ReadLine() |> int
let W = stdin.ReadLine().Split() |> Array.map int

let rec solver l r t i =
    if i = -1 then t
    else
        let ln = l - W.[i]
        let rn = r + W.[i]
        if t < abs (ln - rn) then t
        else solver ln rn (abs (ln - rn)) (i - 1)

solver (Array.sum W) 0 (Array.sum W) (N - 1) |> stdout.WriteLine
