// https://atcoder.jp/contests/abc170/submissions/14389431

let [| X; N |] = stdin.ReadLine().Split() |> Array.map int

let solver =
    let p = stdin.ReadLine()
    if N = 0 then X
    else
        let pi = p.Split() |> Array.map int
        let np = [ 0..102 ] |> List.filter (fun i -> Array.contains i pi |> not)

        let idx =
            np
            |> List.mapi (fun i y -> i, abs (y - X))
            |> List.minBy snd
            |> fst
        np.[idx]

solver |> stdout.WriteLine
