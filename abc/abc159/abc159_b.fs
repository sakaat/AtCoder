// https://atcoder.jp/contests/abc159/submissions/11756705

let S = stdin.ReadLine()
let sr = new string(S.ToCharArray() |> Array.rev)

let s1 = (0, (S.Length - 1) / 2) |> S.Substring
let s1r = new string(s1.ToCharArray() |> Array.rev)

let s2 = ((S.Length + 1) / 2) |> S.Substring
let s2r = new string(s2.ToCharArray() |> Array.rev)

if (S = sr && s1 = s1r && s2 = s2r) then "Yes"
else "No"
|> printfn "%s"
