module Generators

// define the fibonnaci generator
// this uses an internal recursive function to generate an infinite list
// of fibonacci numbers, starting with 1, 1
let fibonnaci = 
    // define a recursive function which computes fibonnaci numbers
    let rec fibgenerator n1 n2 =
        seq { let next = n1 + n2
              yield next
              yield! fibgenerator next n1 }
    // start a sequence with 1,1, then generate the rest
    seq { yield 1; yield 1; yield! fibgenerator 1 1 }
