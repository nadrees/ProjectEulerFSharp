module Libs

open System.Linq

let isPalindrome (str : string) : bool =
    let reversed = str.ToCharArray().Reverse() |> Seq.map (fun c -> c.ToString()) |> Seq.reduce (fun str c -> str + c)
    reversed = str