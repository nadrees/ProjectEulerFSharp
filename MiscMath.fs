module MiscMath

open System
open System.Collections
open Generators

let rec primeFactorize num =
    printfn "Started prime factorizing %s" (num.ToString()) |> ignore
    let primeGenerator = Generators.primes
    let isDivisibleBy x = 
        num % x = 0L
    seq {
        let allPrimesLteNum = primeGenerator num
        let firstPrimeDivisor = Seq.tryFind isDivisibleBy allPrimesLteNum
        match firstPrimeDivisor with
        | Some divisor when divisor > 1L -> 
            printfn "Found divisor %s" (divisor.ToString()) |> ignore
            yield divisor
            let next = num / divisor
            yield! primeFactorize next
        | _ -> ()
    }