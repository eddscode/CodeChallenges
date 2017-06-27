multiplesOfThree = [x | x <- [1..999], x `mod` 3 == 0]
multiplesOfFive = [x | x <- [1..999], x `mod` 5 == 0, x `mod` 3 /= 0]
answer = sum multiplesOfThree + sum multiplesOfFive
