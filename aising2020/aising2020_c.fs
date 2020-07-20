// https://atcoder.jp/contests/aising2020/submissions/15333386

let N = stdin.ReadLine() |> float

let result = Array.zeroCreate<int> (int N + 1)

let f i j k = i * i + j * j + k * k + i * j + j * k + k * i

let rec solver i j k =
    if i = int (sqrt N) then ()
    elif j = int (sqrt N) then solver (i + 1) 1 1
    elif k = int (sqrt N) then solver i (j + 1) 1
    else
        let v = f i j k
        if v <= (int N) then result.[v] <- result.[v] + 1
        solver i j (k + 1)

solver 1 1 1

result
|> Array.skip 1
|> Array.iter stdout.WriteLine
