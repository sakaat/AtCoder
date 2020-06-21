// https://atcoder.jp/contests/abc171/submissions/14588148

open System

stdin.ReadLine()
|> fun c ->
    if Char.IsLower(char c) then 'a'
    else 'A'
|> stdout.WriteLine
