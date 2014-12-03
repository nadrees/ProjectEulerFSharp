#load "Libs.fs"

open Libs

let products = seq {
    for i in 100..999 do
        for j in i..999 do
            yield i * j
}

let palindromeProducts = [for x in products do if Libs.isPalindrome (x.ToString()) then yield x]

printfn "%A" (List.max palindromeProducts)