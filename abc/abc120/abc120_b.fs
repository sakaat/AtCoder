// https://atcoder.jp/contests/abc120/submissions/16642589

let [| A; B; K |] = stdin.ReadLine().Split() |> Array.map int

let rec solver r i =
    if A % i = 0 && B % i = 0 then
        if K = r + 1 then i
        else solver (r + 1) (i - 1)
    else solver r (i - 1)

solver 0 (min A B) |> stdout.WriteLine
