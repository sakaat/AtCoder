// https://atcoder.jp/contests/abc126/submissions/12209156

let [| _; K |] = stdin.ReadLine().Split() |> Array.map int

stdin.ReadLine().ToCharArray()
|> Array.mapi (fun i x ->
    if i = K - 1 then ((string) x).ToLower().ToCharArray().[0]
    else x)
|> Array.iter stdout.Write
