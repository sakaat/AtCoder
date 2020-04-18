// https://atcoder.jp/contests/abc141/submissions/12024273

let [| N; K; Q |] = stdin.ReadLine().Split() |> Array.map int

let A = Array.zeroCreate<int> N

[ 1..Q ]
|> List.map (fun _ -> stdin.ReadLine() |> int)
|> List.map (fun i -> A.[i - 1] <- A.[i - 1] + 1)
|> ignore

A
|> Array.map (fun x ->
    if K - Q + x > 0 then "Yes"
    else "No")
|> Array.iter stdout.WriteLine
