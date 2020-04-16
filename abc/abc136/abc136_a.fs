// https://atcoder.jp/contests/abc136/submissions/11990859

let [| A; B; C |] = stdin.ReadLine().Split() |> Array.map int

max 0 (C - (A - B)) |> stdout.WriteLine
