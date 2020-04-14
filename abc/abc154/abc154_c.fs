// https://atcoder.jp/contests/abc154/submissions/11913275

let N = stdin.ReadLine() |> int

stdin.ReadLine().Split()
|> Array.distinct
|> Array.length
|> fun x ->
    match x with
    | x when x = N -> "YES"
    | _ -> "NO"
|> stdout.WriteLine
