// https://atcoder.jp/contests/abc164/submissions/12399811

let [| A; B; C; D |] = stdin.ReadLine().Split() |> Array.map int

let rec solver a c i =
    if a <= 0 then "No"
    elif c <= 0 then "Yes"
    elif i % 2 = 1 then solver (a - D) c (i + 1)
    else solver a (c - B) (i + 1)

solver A C 0 |> stdout.WriteLine
