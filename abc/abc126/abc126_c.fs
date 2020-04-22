// https://atcoder.jp/contests/abc126/submissions/12208940

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int

let r = Array.zeroCreate<float> N

let solver =
    let rec loop i =
        if i = N then ()
        else
            let mutable s = i + 1
            r.[i] <- 1. / (float N)
            while s < K do
                s <- s * 2
                r.[i] <- r.[i] * 0.5
            loop (i + 1)
    loop 0

solver
r
|> Array.sum
|> stdout.WriteLine
