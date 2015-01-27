#G. Lee

print "what is your height in inches: "
height = gets.to_i

print "what is your weight in pounds: "
weight = gets.to_i

bmi = (weight * 703) / (height * height)



if bmi < 16
 puts "seriously underweight"
elsif bmi >=16 && bmi <=18
  print "underweight"
elsif bmi >=19 && bmi <=24
  puts "normal"
elsif bmi >=30 && bmi <=35
  puts "overweight"
elsif bmi >=25 && bmi<=29
  puts "overweight"

elsif bmi > 35
  puts "gravely overweight"
end

puts "You are #{height} inches tall and weigh #{weight} pounds abd your BMI = #{bmi}"

puts "you are seriously underweight"