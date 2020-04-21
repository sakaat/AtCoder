// https://atcoder.jp/contests/abc136/submissions/11990618

let N = stdin.ReadLine() |> int
let H = stdin.ReadLine().Split() |> Array.map int

let rec solver i =
    if i = 0 then "Yes"
    elif H.[i] + 1 < H.[i - 1] then "No"
    elif H.[i] + 1 = H.[i - 1] then
        H.[i - 1] <- H.[i - 1] - 1
        solver (i - 1)
    else solver (i - 1)

solver (N - 1) |> stdout.WriteLine
