############################################################
#
#  Name:         G. Lee
#  Assignment:   Rock, Paper, Scissors
#  Date:         1/28/2015
#  Class:        CIS282
#  Description:  Game with scoring
#
############################################################


print "Wanna play Rock, Paper Scissors? (enter \"y\" or \"n\"):  "
answer = gets.chomp
puts
if answer == "n"
  puts "Doesn't surprise me. I knew you were a loser when you walked into the room. "
elsif answer =="y"
  puts "Cool. You'll have an opportunity to answer either rock, paper, or scissors once for each round. I'll keep score
and let you know how things turn out. Don't get your hopes up...I almost always win."

#variables for scoring
  me_score = 0
  you_score = 0
  tie = 0

  selection = ""
  while selection != 4

    puts "1. Rock"
    puts "2. Paper"
    puts "3. Scissors"
    puts "4. Quit"
    puts
    puts "Choose 1 for rock, 2 for paper, 3 for scissors, or 4 to quit "

    selection = gets.to_i

    wrong = false

    if selection == 1
      choice = "rock"
    elsif selection == 2
      choice = "paper"
    elsif selection == 3
      choice = "scissors"
    elsif selection == 4
      puts
      puts "Final Score: #{me_score} win(s) for me." +" "+ "#{you_score} win(s) for you." +" " + "There were #{tie} tie(s)."
        if me_score > you_score
          puts "I WIN IT ALL! Put a fork in you - you're done!"
        elsif you_score > me_score
          puts "Well, whatever, your match I guess.  But I'm pretty sure you cheated."
        end
      exit!
    elsif selection <= 0 || selection >= 5
      puts "Come on Dave, you can count to four, right? Sheesh!"
      wrong = true

    end



    a = ["rock","paper", "scissors"]
    random = a.sample
    puts

    if wrong == false
      puts "You choose #{choice}, I choose #{random}"
      puts

      if choice == "rock" && random == "paper" || choice == "paper" && random == "scissors" || choice =="scissors" && random == "rock"
        me_score +=1
        puts "I WIN!"
        puts
      elsif choice == "paper" && random == "rock" || choice == "scissors" && random == "paper" || choice =="rock" && random == "scissors"
        you_score +=1
        puts "You win, whatever..."
        puts
      elsif choice == "paper" && random == "paper" || choice == "scissors" && random == "scissors" || choice =="rock" && random == "rock"
        tie +=1
        puts "Its a tie!"
        puts


      end

      puts "My score is: #{me_score}" +" "+ "Your score is: #{you_score}" +" " + "There's been #{tie} tie(s)"
    end
    puts

  end

end

