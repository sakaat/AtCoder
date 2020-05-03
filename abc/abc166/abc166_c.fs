// https://atcoder.jp/contests/abc166/submissions/12783941

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int
let H = stdin.ReadLine().Split() |> Array.map int

let AB = Array.zeroCreate<int> N

for _ in [ 1..M ] do
    let ab = stdin.ReadLine().Split() |> Array.map int
    AB.[ab.[0] - 1] <- max AB.[ab.[0] - 1] H.[ab.[1] - 1]
    AB.[ab.[1] - 1] <- max AB.[ab.[1] - 1] H.[ab.[0] - 1]

AB
|> Array.indexed
|> Array.filter (fun x -> H.[fst x] > snd x)
|> Array.length
|> stdout.WriteLine
