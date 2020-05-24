// https://atcoder.jp/contests/past201912-open/submissions/13557747

open System.Linq
open System.Text.RegularExpressions

let S = stdin.ReadLine()

let result = Regex.Split(S, "([A-Z][a-z]*?[A-Z])") |> fun x -> x.OrderBy(fun x -> x)

for r in result do
    r |> stdout.Write
