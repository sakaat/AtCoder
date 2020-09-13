// https://atcoder.jp/contests/abc178/submissions/16727716

let MOD = 1000000007L

let modadd (x : int64) (y : int64) = (x + y) % MOD

let modsub (x : int64) (y : int64) = (x + MOD - y) % MOD

let modmul (x : int64) (y : int64) = ((x % MOD) * (y % MOD)) % MOD

let modpow2 (x : int64) = x * x

let rec modpow (x : int64) (y : int64) =
    if y = 0L then 1L
    elif y = 1L then x % MOD
    elif y % 2L = 0L then modpow2 (modpow x (y / 2L)) % MOD
    else modmul x (modpow2 (modpow x (y / 2L))) % MOD

let N = stdin.ReadLine() |> int64

modadd (modsub (modsub (modpow 10L N) (modpow 9L N)) (modpow 9L N)) (modpow 8L N) |> stdout.WriteLine
