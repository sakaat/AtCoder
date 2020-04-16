// https://atcoder.jp/contests/abc133/submissions/11968764

let [| L; R |] = stdin.ReadLine().Split() |> Array.map int64

let rec resolver m i j =
    if i = R then m
    elif m = 0L then m
    elif j = R + 1L then resolver m (i + 1L) (i + 2L)
    elif i * j % 2019L < m then resolver (i * j % 2019L) i (j + 1L)
    else resolver m i (j + 1L)

resolver 2019L L (L + 1L) |> stdout.WriteLine
