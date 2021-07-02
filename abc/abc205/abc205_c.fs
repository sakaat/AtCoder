// https://atcoder.jp/contests/abc205/submissions/23918068

let [| A; B; C |] = stdin.ReadLine().Split() |> Array.map int64

let vC = if C % 2L = 0L then 2 else 1

if pown A vC = pown B vC then "="
else if pown A vC > pown B vC then ">"
else "<"
|> stdout.WriteLine
