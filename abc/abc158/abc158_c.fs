// https://atcoder.jp/contests/abc158/submissions/11771789

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

let mutable result = 0

let rec solver k =
    if (k * 8 / 100) = A && (k * 10 / 100) = B then
        result <- k
        ()
    elif k = 1009 then ()
    else solver (k + 1)

solver 0
match result with
| 0 -> -1
| _ -> result
|> printfn "%d"
