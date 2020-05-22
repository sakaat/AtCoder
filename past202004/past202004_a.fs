// https://atcoder.jp/contests/past202004-open/submissions/13481181

let floors =
    [ "B9"; "B8"; "B7"; "B6"; "B5"; "B4"; "B3"; "B2"; "B1"; "1F"; "2F"; "3F"; "4F"; "5F"; "6F"; "7F"; "8F"; "9F" ]

let [| S; T |] = stdin.ReadLine().Split()

let si = floors |> List.findIndex ((=) S)
let ti = floors |> List.findIndex ((=) T)

si - ti
|> abs
|> stdout.WriteLine
