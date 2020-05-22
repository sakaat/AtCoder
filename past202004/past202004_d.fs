// https://atcoder.jp/contests/past202004-open/submissions/13484733

open System.Text.RegularExpressions

let S = stdin.ReadLine()

let a =
    [ "a"; "b"; "c"; "d"; "e"; "f"; "g"; "h"; "i"; "j"; "k"; "l"; "m"; "n"; "o"; "p"; "q"; "r"; "s"; "t"; "u"; "v"; "w"; "x"; "y"; "z"; "." ]

let pairs list1 list2 = List.allPairs list1 list2 |> List.map (fun x -> fst x + snd x)

let counter list1 =
    list1
    |> List.filter (fun x -> Regex.IsMatch(S, x))
    |> List.length

let r1 = a |> counter

let r2 = pairs a a |> counter

let r3 = pairs a (pairs a a) |> counter

(r1 + r2 + r3) |> stdout.WriteLine
