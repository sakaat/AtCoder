// https://atcoder.jp/contests/abc126/submissions/12208984

let S = stdin.ReadLine() |> int
let l = S / 100
let r = S % 100

if 1 <= l && l <= 12 then
    if 1 <= r && r <= 12 then "AMBIGUOUS"
    else "MMYY"
elif 1 <= r && r <= 12 then "YYMM"
else "NA"
|> stdout.WriteLine
