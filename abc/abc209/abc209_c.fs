// https://atcoder.jp/contests/abc209/submissions/24165053

let MOD = 1000000007L
let modmul x y = ((x % MOD) * (y % MOD)) % MOD

stdin.ReadLine()
stdin.ReadLine().Split() |> Array.map int64
|> Array.sort
|> Array.mapi(fun i x -> max 0L (x - int64 i))
|> Array.fold(fun s x -> modmul s x) 1L
|> stdout.WriteLine
