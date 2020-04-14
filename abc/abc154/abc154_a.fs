// https://atcoder.jp/contests/abc154/submissions/11913045

let [| S; T |] = stdin.ReadLine().Split()
let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

stdin.ReadLine()
|> fun x ->
    match x with
    | x when x = S -> printfn "%d %d" (A - 1) B
    | x when x = T -> printfn "%d %d" A (B - 1)
