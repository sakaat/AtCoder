// https://atcoder.jp/contests/abc152/submissions/11924510

let [| a; b |] = stdin.ReadLine().Split() |> Array.map int

if a > b then new System.String(char b + '0', a)
else new System.String(char a + '0', b)
|> stdout.WriteLine
