// https://atcoder.jp/contests/m-solutions2020/submissions/15462454

let [| A; B; C |] = stdin.ReadLine().Split() |> Array.map int
let K = stdin.ReadLine() |> int

let rec solver x y i =
    if x < y then i
    else solver x (y * 2) (i + 1)

let s1 = solver A B 0
let s2 = solver (B <<< s1) C 0

if s1 + s2 <= K then "Yes"
else "No"
|> stdout.WriteLine
