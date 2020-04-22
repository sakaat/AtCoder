// https://atcoder.jp/contests/abc127/submissions/12233589

let [| r; D; x |] = stdin.ReadLine().Split() |> Array.map int

let rec solver t i =
    if i = 10 then ()
    else
        let temp = r * t - D
        temp |> printfn "%d"
        solver temp (i + 1)

solver x 0
