// https://atcoder.jp/contests/abc121/submissions/12277754

let [| N; M; C |] = stdin.ReadLine().Split() |> Array.map int
let B = stdin.ReadLine().Split() |> Array.map int

let rec solver r i =
    if i = N then r
    else
        let A = stdin.ReadLine().Split() |> Array.map int

        let s =
            Array.zip A B
            |> Array.map (fun x -> (fst x) * (snd x))
            |> Array.sum
        if s + C > 0 then solver (r + 1) (i + 1)
        else solver r (i + 1)

solver 0 0 |> stdout.WriteLine
