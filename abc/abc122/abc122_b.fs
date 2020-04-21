// https://atcoder.jp/contests/abc122/submissions/12205902

open System.Text.RegularExpressions

let S = stdin.ReadLine()

let r = Regex("[ACGT]{1,}").Matches S

if r
   |> Seq.cast
   |> Seq.length = 0
then 0
else
    r
    |> Seq.cast
    |> Seq.map (fun (x : Match) -> x.Length)
    |> Seq.max
|> stdout.WriteLine
