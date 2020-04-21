// https://atcoder.jp/contests/abc150/submissions/12184961

let N = stdin.ReadLine() |> int
let P = stdin.ReadLine().Replace(" ", "")
let Q = stdin.ReadLine().Replace(" ", "")

let rec distribution e =
    function
    | [] -> [ [ e ] ]
    | x :: xs' as xs ->
        (e :: xs) :: [ for xs in distribution e xs' -> x :: xs ]

let rec permutation =
    function
    | [] -> [ [] ]
    | e :: xs -> List.collect (distribution e) (permutation xs)

let find lst s =
    lst
    |> List.find (fun (x, _) -> x = s)
    |> snd

permutation [ 1..N ]
|> List.sort
|> List.map (fun lst -> System.String.Concat(Array.ofList lst))
|> List.mapi (fun i x -> x, (i + 1))
|> fun lst -> abs (find lst P - find lst Q)
|> stdout.WriteLine
