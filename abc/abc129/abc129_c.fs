// https://atcoder.jp/contests/abc129/submissions/12152311

let MOD = 1000000007

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

let a =
    [| for _ in [ 1..M ] do
        yield (stdin.ReadLine() |> int) |]

let dp = Array.zeroCreate<int> (N + 1)

dp.[0] <- 1

let rec resolver idx i =
    if i = N + 1 then ()
    elif idx < M && a.[idx] = i then
        dp.[i] <- 0
        resolver (idx + 1) (i + 1)
    else
        dp.[i] <- (dp.[i - 1] + if i <> 1 then dp.[i - 2]
                                else 0)
                  % MOD
        resolver idx (i + 1)

resolver 0 1

dp.[N] |> stdout.WriteLine
