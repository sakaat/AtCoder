// https://atcoder.jp/contests/abc133/submissions/11971637

let [| N; D |] = stdin.ReadLine().Split() |> Array.map int

let X =
    [| for i in [ 1..N ] do
        yield (stdin.ReadLine().Split() |> Array.map int) |]

let rec solver s i j =
    if i = N then s
    elif j = N then solver s (i + 1) (i + 2)
    else
        let d = Array.map2 (fun x y -> (x - y) * (x - y)) X.[i] X.[j] |> Array.sum

        let t =
            d
            |> float
            |> sqrt
            |> ceil
            |> int
        if t * t = d then solver (s + 1) i (j + 1)
        else solver s i (j + 1)

solver 0 0 1 |> stdout.WriteLine
