// https://atcoder.jp/contests/past202004-open/submissions/13540536

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int

let solver i =
    let rec loop c n =
        if i = n then c
        else loop (c + 1) A.[n - 1]
    loop 1 A.[i - 1]

[ 1..N ]
|> List.map (fun i -> solver i)
|> List.iter (printf "%d ")
