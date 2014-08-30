#load "Generators.fs"

open Generators

Seq.skip 1 fibonnaci |> Seq.takeWhile (fun x -> x <= 4000000) |> Seq.where (fun x -> x % 2 = 0) |> Seq.sum