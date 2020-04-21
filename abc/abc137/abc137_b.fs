// https://atcoder.jp/contests/abc137/submissions/11991208

let [| K; X |] = stdin.ReadLine().Split() |> Array.map int

let rec solver i =
    if i = X + K then ()
    elif i < -1000000 || 1000000 < i then solver (i + 1)
    else
        printf "%d" i
        printf " "
        solver (i + 1)

solver (X - K + 1)
