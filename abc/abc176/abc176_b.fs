// https://atcoder.jp/contests/abc176/submissions/16152021

stdin.ReadLine().ToCharArray()
|> Array.sumBy (fun x -> (int) x - (int) '0')
|> fun x ->
    if x % 9 = 0 then "Yes"
    else "No"
|> stdout.WriteLine
