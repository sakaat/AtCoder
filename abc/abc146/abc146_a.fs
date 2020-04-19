// https://atcoder.jp/contests/abc146/submissions/12155271

stdin.ReadLine()
|> fun S ->
    match S with
    | "SUN" -> 7
    | "MON" -> 6
    | "TUE" -> 5
    | "WED" -> 4
    | "THU" -> 3
    | "FRI" -> 2
    | "SAT" -> 1
    | _ -> 0
|> stdout.WriteLine
