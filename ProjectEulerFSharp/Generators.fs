module Generators

open System
open System.Collections

let fibonnaci = 
    // define a recursive function which computes fibonnaci numbers
    let rec fibgenerator n1 n2 =
        seq { let next = n1 + n2
              yield next
              yield! fibgenerator next n1 }
    // start a sequence with 1,1, then generate the rest
    seq { yield 1; yield 1; yield! fibgenerator 1 1 }    


 
let primes max =
    let isPrime n =
        let stopAt = 1L + (int64) (Math.Sqrt (float n))
        let rec loop n i =
            match (n%i, i) with
            | (_, i) when i = stopAt -> true
            | (0L, _)                -> false
            | _                      -> loop n (i+1L)
 
        loop n 2L
    seq {
        for i in 2L..max do
            if isPrime i then
                yield i
    }