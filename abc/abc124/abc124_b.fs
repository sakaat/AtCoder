// https://atcoder.jp/contests/abc124/submissions/12208581

let N = stdin.ReadLine() |> int
let H = stdin.ReadLine().Split() |> Array.map int

let solver =
    let rec loop t r i =
        if i = N then r
        elif H.[i] >= t then loop (max H.[i] t) (r + 1) (i + 1)
        else loop (max H.[i] t) r (i + 1)
    loop H.[0] 0 0

solver |> stdout.WriteLine
