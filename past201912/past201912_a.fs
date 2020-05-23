// https://atcoder.jp/contests/past201912-open/submissions/13492111

System.Int32.TryParse(stdin.ReadLine())
|> fun x ->
    if fst x then (snd x * 2).ToString()
    else "error"
|> stdout.WriteLine
