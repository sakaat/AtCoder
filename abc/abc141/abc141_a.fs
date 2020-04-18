// https://atcoder.jp/contests/abc141/submissions/12023640

stdin.ReadLine()
|> fun S ->
    if S = "Sunny" then "Cloudy"
    elif S = "Cloudy" then "Rainy"
    else "Sunny"
|> stdout.WriteLine
