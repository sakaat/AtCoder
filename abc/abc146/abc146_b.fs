// https://atcoder.jp/contests/abc146/submissions/12155411

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine().ToCharArray()
let A = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()

let rot c =
    A
    |> Array.findIndex (fun x -> x = c)
    |> fun i -> (i + N) % 26
    |> fun i -> A.[i]

S
|> Array.map rot
|> stdout.WriteLine
