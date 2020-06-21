// https://atcoder.jp/contests/abc125/submissions/14523283

let N = stdin.ReadLine()
let A = stdin.ReadLine().Split() |> Array.map int64
let AA = Array.map abs A

if A
   |> Array.contains 0L
   || (A
       |> Array.filter (fun x -> x < 0L)
       |> Array.length) % 2 = 0
then Array.sum AA
else (Array.sum AA) - 2L * (Array.min AA)
|> stdout.WriteLine
