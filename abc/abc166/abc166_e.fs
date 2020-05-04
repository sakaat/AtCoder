// https://atcoder.jp/contests/abc166/submissions/12815277

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int64

let d = Array.zeroCreate<int64> N
let s = Array.zeroCreate<int64> N

let calc ope cond (a : int64 []) =
    A
    |> Array.indexed
    |> Array.filter (fun x -> cond ((ope) (fst x) (snd x |> int)))
    |> Array.map (fun x -> (ope) (fst x) (snd x |> int))
    |> Array.groupBy id
    |> Array.map (fun x -> (fst x, Array.length (snd x)))
    |> Array.map (fun x -> a.[fst x] <- snd x |> int64)
    |> ignore

calc (-) (fun x -> x >= 0) d
calc (+) (fun x -> x < N) s

Array.zip d s
|> Array.map (fun x -> fst x * snd x)
|> Array.sum
|> stdout.WriteLine
