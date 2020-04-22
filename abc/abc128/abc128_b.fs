// https://atcoder.jp/contests/abc128/submissions/12224700

open System.Linq

type Restaurant =
    { id : int
      s : string
      p : int }

let N = stdin.ReadLine() |> int
let restaurant = Array.zeroCreate<Restaurant> N

for i in [ 0..N - 1 ] do
    let [| S; P |] = stdin.ReadLine().Split()
    restaurant.[i] <- { id = i
                        s = S
                        p = int P }

let sorted = restaurant.OrderBy(fun x -> x.s).ThenByDescending(fun x -> x.p)

sorted
|> Seq.map (fun x -> x.id + 1)
|> Seq.iter (printfn "%d")
