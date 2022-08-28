// 16.1
let notDivisible (m,n) = m % n = 0

// 16.2
let prime n = 
    let sqrttoint n = (int (sqrt (float n)))
    let iterations = sqrttoint(n)
    let rec primeInternal = function
      | (n, c) when n <= 1 -> false
      | (n, c) when c < 2 -> true
      | (n, c) -> notDivisible(n, c) = false && primeInternal(n, c - 1)
    primeInternal(n, iterations)