#load "Generators.fs"
#load "MiscMath.fs"

open System
open MiscMath

let target = 600851475143L
let maxFactor = MiscMath.primeFactorize target |> Seq.max