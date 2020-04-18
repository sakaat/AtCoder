// https://atcoder.jp/contests/abc144/submissions/12054821

let N = stdin.ReadLine() |> int

[ 1..9 ]
|> List.filter (fun x -> N % x = 0)
|> List.filter (fun x -> N / x < 10)
|> List.length
|> fun x ->
    if x > 0 then "Yes"
    else "No"
|> stdout.WriteLine
