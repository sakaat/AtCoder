// https://atcoder.jp/contests/abc205/submissions/23917931

let N = stdin.ReadLine() |> int

stdin.ReadLine().Split()
|> Array.map int
|> Array.sort
|> Array.mapi (fun i x -> i + 1 = x)
|> Array.filter id
|> fun x -> if x.Length = N then "Yes" else "No"
|> stdout.WriteLine
