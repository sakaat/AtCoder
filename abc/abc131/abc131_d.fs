// https://atcoder.jp/contests/abc131/submissions/12885032

let N = stdin.ReadLine() |> int
let AB = Array.zeroCreate<int []> N

for i in [ 0..N - 1 ] do
    AB.[i] <- stdin.ReadLine().Split() |> Array.map int

let sAB = AB |> Array.sortBy (fun x -> x.[1])

let rec solver t n =
    if n = N then "Yes"
    else
        let time = t + sAB.[n].[0]
        if time > sAB.[n].[1] then "No"
        else solver time (n + 1)

solver 0 0 |> stdout.WriteLine
