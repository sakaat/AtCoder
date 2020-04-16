// https://atcoder.jp/contests/abc136/submissions/11990618

let N = stdin.ReadLine() |> int
let H = stdin.ReadLine().Split() |> Array.map int

let rec resolver i =
    if i = 0 then "Yes"
    elif H.[i] + 1 < H.[i - 1] then "No"
    elif H.[i] + 1 = H.[i - 1] then
        H.[i - 1] <- H.[i - 1] - 1
        resolver (i - 1)
    else resolver (i - 1)

resolver (N - 1) |> stdout.WriteLine
