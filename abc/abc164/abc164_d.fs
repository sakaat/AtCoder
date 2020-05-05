// https://atcoder.jp/contests/abc164/submissions/12844734

let S = stdin.ReadLine().ToCharArray()
let T = Array.zeroCreate<int> (S.Length + 1)
let MOD = 2019

let rec solver m n =
    if n = -1 then ()
    else
        T.[n] <- (T.[n + 1] + m * (int S.[n] - int '0')) % MOD
        solver (m * 10 % MOD) (n - 1)

solver 1 (T.Length - 2)

T
|> Array.countBy id
|> Array.sumBy (fun x -> snd x * (snd x - 1) / 2)
|> stdout.WriteLine
