"""

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.

"""


# List Comprehension method (slightly verbose for clarity)

numbers = list(range(1, 1000))
multiples_of_three = [x for x in numbers if x % 3 == 0]
multiples_of_five = [x for x in numbers if x % 5 == 0 and x not in multiples_of_three]

answer = sum(multiples_of_three) + sum(multiples_of_five)

print(answer)

multiples_of_three = 0
multiples_of_five = 0


# Loop method

i = 0

while i < 1000:
    if i % 3 == 0:
        multiples_of_three += i
    elif i % 5 == 0:
        multiples_of_five += i
    i += 1

answer = multiples_of_three + multiples_of_five

print(answer)


# One liner

print(sum([i for i in range(1, 1000) if i % 3 == 0 or (i % 3 != 0 and i % 5 == 0)]))
