// https://atcoder.jp/contests/abc155/submissions/11909200

let N = stdin.ReadLine()

stdin.ReadLine().Split()
|> Array.map int
|> Array.filter (fun x -> x % 2 = 0)
|> Array.filter (fun x -> x % 3 > 0)
|> Array.filter (fun x -> x % 5 > 0)
|> Array.isEmpty
|> fun x ->
    match x with
    | true -> "APPROVED"
    | false -> "DENIED"
|> stdout.WriteLine
