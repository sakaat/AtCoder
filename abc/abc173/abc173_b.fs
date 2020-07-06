// https://atcoder.jp/contests/abc173/submissions/15022356

let N = stdin.ReadLine() |> int

let S =
    [| for _ in [ 1..N ] do
        yield stdin.ReadLine() |]

let counter j =
    S
    |> Array.filter (fun s -> s = j)
    |> Array.length
    |> string

"AC x " + (counter "AC") |> stdout.WriteLine
"WA x " + (counter "WA") |> stdout.WriteLine
"TLE x " + (counter "TLE") |> stdout.WriteLine
"RE x " + (counter "RE") |> stdout.WriteLine
