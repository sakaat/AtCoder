// https://atcoder.jp/contests/abc122/submissions/12205438

stdin.ReadLine()
|> fun b ->
    match b with
    | "A" -> "T"
    | "C" -> "G"
    | "G" -> "C"
    | "T" -> "A"
    | _ -> ""
|> stdout.WriteLine
