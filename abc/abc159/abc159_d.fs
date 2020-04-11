// https://atcoder.jp/contests/abc159/submissions/11755736

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int

let B = Array.zeroCreate<int64> (N + 1)

A
|> Array.groupBy (fun n -> n)
|> Array.map (fun (k, v) ->
    B.[k] <- (v
              |> Array.length
              |> int64))
|> ignore

let sum =
    B
    |> Array.map (fun x -> x * (x - 1L) / 2L)
    |> Array.sum

[| 0..(N - 1) |]
|> Array.map (fun i -> sum - (B.[A.[i]] - 1L))
|> Array.iter (printfn "%d")
