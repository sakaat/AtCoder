// https://atcoder.jp/contests/abc162/submissions/12039332

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int64

let MOD = 1000000007L

let modsub (x : int64) (y : int64) = (x + MOD - y) % MOD

let modmul (x : int64) (y : int64) = ((x % MOD) * (y % MOD)) % MOD

let modpow2 (x : int64) = x * x

let rec modpow (x : int64) (y : int64) =
    if y = 0L then 1L
    elif y = 1L then x % MOD
    elif y % 2L = 0L then modpow2 (modpow x (y / 2L)) % MOD
    else modmul x (modpow2 (modpow x (y / 2L))) % MOD

let p = Array.zeroCreate<int64> (int K)

for i in [ int K..(-1)..1 ] do
    p.[i - 1] <- modpow (K / (int64 i)) N
    for j in [ 2 * i..i..int K ] do
        p.[i - 1] <- modsub p.[i - 1] p.[j - 1]

p
|> Array.mapi (fun i x -> modmul (int64 (i + 1)) x)
|> Array.sum
|> fun x -> x % MOD
|> stdout.WriteLine
