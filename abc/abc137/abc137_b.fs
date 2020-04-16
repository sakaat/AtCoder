// https://atcoder.jp/contests/abc137/submissions/11991208

let [| K; X |] = stdin.ReadLine().Split() |> Array.map int

let rec resolver i =
    if i = X + K then ()
    elif i < -1000000 || 1000000 < i then resolver (i + 1)
    else
        printf "%d" i
        printf " "
        resolver (i + 1)

resolver (X - K + 1)
