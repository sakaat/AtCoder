// https://atcoder.jp/contests/abc115/submissions/16818144

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int

let h =
    [| for i in [ 0..N - 1 ] do
        yield (stdin.ReadLine() |> int) |]
    |> Array.sort

[| 0..N - K |]
|> Array.map (fun i -> h.[i + K - 1] - h.[i])
|> Array.min
|> stdout.WriteLine
