// https://atcoder.jp/contests/aising2020/submissions/15324317

let [| L; R; d |] = stdin.ReadLine().Split() |> Array.map int

R / d - (L - 1) / d |> stdout.WriteLine
