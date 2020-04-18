// https://atcoder.jp/contests/abc143/submissions/12054197

let N = stdin.ReadLine() |> int
let d = stdin.ReadLine().Split() |> Array.map int

let rec resolver r i =
    if i = N then r
    else
        let rec loop r j =
            if j = N then resolver r (i + 1)
            else loop (r + d.[i] * d.[j]) (j + 1)
        loop r (i + 1)

resolver 0 0 |> stdout.WriteLine
