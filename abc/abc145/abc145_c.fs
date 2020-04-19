// https://atcoder.jp/contests/abc145/submissions/12155167

let N = stdin.ReadLine() |> int

let xy =
    [| for _ in [ 1..N ] do
        yield (stdin.ReadLine().Split() |> Array.map int) |]

let rec fact r n =
    if n = 1 then r
    else fact (r * n) (n - 1)

let rec resolver r i j =
    if i = N then r / float (fact 1 N)
    else
        let rec loop r j =
            if j = N then resolver r (i + 1) 0
            elif i = j then loop r (j + 1)
            else
                let x = abs (xy.[i].[0] - xy.[j].[0]) * abs (xy.[i].[0] - xy.[j].[0])
                let y = abs (xy.[i].[1] - xy.[j].[1]) * abs (xy.[i].[1] - xy.[j].[1])
                loop (r + float (fact 1 (N - 1)) * sqrt (float (x + y))) (j + 1)
        loop r j

resolver 0.0 0 0 |> stdout.WriteLine
