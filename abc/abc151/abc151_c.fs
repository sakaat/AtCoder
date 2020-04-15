// https://atcoder.jp/contests/abc151/submissions/11939654

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

let waas = Array.zeroCreate<int> N
let flags = Array.zeroCreate<bool> N

let rec resolver ac wa n =
    if n = M then [| ac; wa |]
    else
        let input = stdin.ReadLine().Split()
        let p = input.[0] |> int
        let S = input.[1]

        if not flags.[p - 1] then
            if S = "WA" then
                waas.[p - 1] <- waas.[p - 1] + 1
                resolver ac wa (n + 1)
            else
                flags.[p - 1] <- true
                resolver (ac + 1) (wa + waas.[p - 1]) (n + 1)
        else resolver ac wa (n + 1)

resolver 0 0 0 |> Array.iter (printf "%d ")
