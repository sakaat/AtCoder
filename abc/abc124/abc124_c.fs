// https://atcoder.jp/contests/abc124/submissions/12208668

let S = stdin.ReadLine()

let solver =
    let rec loop r1 r2 i =
        if i = S.Length then min r1 r2
        elif i % 2 = 0 then
            loop
                (if S.[i] = '0' then r1
                 else r1 + 1)
                (if S.[i] = '1' then r2
                 else r2 + 1) (i + 1)
        else
            loop
                (if S.[i] = '1' then r1
                 else r1 + 1)
                (if S.[i] = '0' then r2
                 else r2 + 1) (i + 1)
    loop 0 0 0

solver |> stdout.WriteLine
