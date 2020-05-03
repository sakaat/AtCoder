// https://atcoder.jp/contests/abc166/submissions/12789378

let X = stdin.ReadLine() |> int

let s = 120

let pow5 x = x * x * x * x * x

let rec solver i j =
    if j = s then solver (i + 1) -s
    elif pow5 i - pow5 j = X then
        i.ToString() + " " + j.ToString() |> stdout.WriteLine
        ()
    else solver i (j + 1)

solver -s -s
