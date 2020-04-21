// https://atcoder.jp/contests/abc161/submissions/11747064

open System.Collections.Generic

let K = stdin.ReadLine() |> int

let queue = new Queue<int64>()

[ 1L..9L ] |> List.iter queue.Enqueue

let mutable n = 0L

let rec solver k =
    n <- queue.Dequeue()
    match n % 10L with
    | 0L ->
        [ n * 10L + n % 10L
          n * 10L + n % 10L + 1L ]
    | 9L ->
        [ n * 10L + n % 10L - 1L
          n * 10L + n % 10L ]
    | _ ->
        [ n * 10L + n % 10L - 1L
          n * 10L + n % 10L
          n * 10L + n % 10L + 1L ]
    |> List.iter queue.Enqueue
    if k = K - 1 then ()
    else solver (k + 1)

solver 0
n |> printfn "%d"
