// https://atcoder.jp/contests/abc135/submissions/11958270

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int64
let B = stdin.ReadLine().Split() |> Array.map int64

let rec resolver s n =
    if n = N then s
    else
        let mutable t = 0L
        if B.[n] > A.[n] then
            B.[n] <- B.[n] - A.[n]
            t <- t + A.[n]
            A.[n] <- 0L
        else
            A.[n] <- A.[n] - B.[n]
            t <- t + B.[n]
            B.[n] <- 0L
        if B.[n] > A.[n + 1] then
            B.[n] <- B.[n] - A.[n + 1]
            t <- t + A.[n + 1]
            A.[n + 1] <- 0L
        else
            A.[n + 1] <- A.[n + 1] - B.[n]
            t <- t + B.[n]
            B.[n] <- 0L
        resolver (s + t) (n + 1)

resolver 0L 0 |> stdout.WriteLine
