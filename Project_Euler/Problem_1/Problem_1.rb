multiples_of_three = 0
multiples_of_five = 0

numbers = [1..999].inject do |x|
  if x % 3 == 0
    multiples_of_three += x
  elsif x % 5 == 0
    multiples_of_five += x
  end
end

puts multiples_of_three + multiples_of_five
