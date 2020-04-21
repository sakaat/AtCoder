// https://atcoder.jp/contests/abc143/submissions/12054197

let N = stdin.ReadLine() |> int
let d = stdin.ReadLine().Split() |> Array.map int

let rec solver r i =
    if i = N then r
    else
        let rec loop r j =
            if j = N then solver r (i + 1)
            else loop (r + d.[i] * d.[j]) (j + 1)
        loop r (i + 1)

solver 0 0 |> stdout.WriteLine
