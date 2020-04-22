// https://atcoder.jp/contests/abc127/submissions/12233685

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

let rec solver l r i =
    if i = M then max 0 (r - l + 1)
    else
        let [| L; R |] = stdin.ReadLine().Split() |> Array.map int
        solver (max l L) (min r R) (i + 1)

solver 1 N 0 |> stdout.WriteLine
