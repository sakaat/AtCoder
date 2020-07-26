// https://atcoder.jp/contests/m-solutions2020/submissions/15465914

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int64

let rec solver money i =
    if i = N - 1 then money
    elif A.[i] < A.[i + 1] then
        let stocks = money / A.[i]
        solver (money + (A.[i + 1] - A.[i]) * stocks) (i + 1)
    else solver money (i + 1)

solver 1000L 0 |> stdout.WriteLine
