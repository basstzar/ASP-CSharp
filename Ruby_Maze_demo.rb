##########################G's Methods#########################

def print_maze(maze)
  maze.each do |row|
    puts row.join("")
  end
end

def count_to_s(maze)
  look = 0
  replace = 1
  o_row = 0
  o_col = 0
      found_s = false
  count = 0

  while !found_s

    row = 0
    while row < maze.length

      col = 0
      while col < maze[row].length
        if maze[row][col] == look
          o_row = row
          o_col = col

          if maze[o_row -1][o_col] == " "
            maze[o_row -1][o_col] = replace
          end
          if maze[o_row +1][o_col] == " "
            maze[o_row +1][o_col] = replace
          end
          if maze[o_row][o_col-1] == " "
            maze[o_row][o_col-1] = replace
          end
          if maze[o_row][o_col+1] == " "
            maze[o_row][o_col+1] = replace
          end
          if maze[o_row -1][o_col] == "S"
            found_s = true
          end
          if maze[o_row +1][o_col] == "S"
            found_s = true
          end
          if maze[o_row][o_col-1] == "S"
            found_s = true
          end
          if maze[o_row][o_col+1] == "S"
            found_s = true
          end
        end
        col += 1

      end
      row += 1

    end
    count +=1
    look +=1
    replace +=1
  end
end


def count_down(maze, s_col, s_row)

  num = 20
  index = 1

  if maze[s_row - 1][s_col].class == Fixnum
    num = maze[s_row - 1][s_col]
    maze[s_row - 1][s_col] = "*"
    home_row = s_row - 1
    home_col = s_col
    count = num
  elsif maze[s_row + 1][s_col].class == Fixnum
    num = maze[s_row + 1][s_col]
    maze[s_row + 1][s_col] = "*"
    home_row = s_row + 1
    home_col = s_col
    count = num
  elsif  maze[s_row][s_col + 1].class == Fixnum
    num = maze[s_row][s_col + 1]
    maze[s_row][s_col + 1] = "*"
    home_row = s_row
    home_col = s_col +1
    count = num
  elsif  maze[s_row][s_col - 1].class == Fixnum
    num = maze[s_row][s_col - 1]
    maze[s_row][s_col - 1] = "*"
    home_row = s_row
    home_col = s_col - 1
    count = num
  end

  while count >=  0
    if maze[home_row - index][home_col].class == Fixnum
      if maze[home_row - index][home_col] < num
        num = maze[home_row - index][home_col]
        maze[home_row - index][home_col] = "*"
        home_row = home_row - index
        home_col = home_col
      end
    end
    if maze[home_row + index][home_col].class == Fixnum
      if maze[home_row + index][home_col] < num
        num = maze[home_row + index][home_col]
        maze[home_row + index][home_col] = "*"
        home_row = home_row + index
        home_col = home_col
      end
    end
    if maze[home_row][home_col + index].class == Fixnum
      if maze[home_row][home_col + index] < num
        num = maze[home_row][home_col + index]
        maze[home_row][home_col + index] = "*"
        home_row = home_row
        home_col = home_col + index
      end
    end
    if maze[home_row][home_col - index].class == Fixnum
      if maze[home_row][home_col - index] < num
        num = maze[home_row][home_col - index]
        maze[home_row][home_col - index] = "*"
        home_row = home_row
        home_col = home_col - index
      end

    end

    index +1
    count -=1
  end
  return count, home_col, home_row, index, num
end

def remove_numbers(maze)
  row = 0
  while row < maze.length
    col = 0
    while col < maze[row].length
      if maze[row][col].class == Fixnum
        maze[row][col] = " "
      end
      col += 1
    end
    row += 1
  end
end

########################################################begin main loop
go = true
while go

puts "Enter 1 for Maze 1"
puts "Enter 2 for Maze 2"
puts "Enter 3 for Maze 3"
puts "Enter 4 for Maze 4"
puts "Enter 5 for Maze 5"
puts "Enter 6 for Maze 6"
puts "Enter 7 for Maze 7"
puts "Enter 8 for Maze 8"
puts "Enter 9 for Maze 9"
puts "Enter 10 for Maze 10"
puts "Enter 11 to quit"
puts
print "Name your poison: "

choice = gets.to_i
if choice == 11
  go = false
  puts "Thanks for using G's painful CIS282 app!"
end

case choice

when 1

maze = []

maze_file = File.open ("maze1.mz")
while ! maze_file.eof?

first_line =  maze_file.gets.chomp.split("")
maze << first_line

end
maze_file.close

f_row = 0
f_col = 0

row = 0
while row < maze.length
  col = 0
  while col < maze[row].length
    if maze[row][col] == 'F'
      f_row = row
      f_col = col
    end
    col += 1
  end
  row += 1
end

north = maze[f_row - 1][f_col]
south = maze[f_row + 1][f_col]
west = maze[f_row][f_col - 1]
east = maze[f_row][f_col + 1]

print_maze(maze)

maze[f_row -1][f_col] = 0 if north == " "
maze[f_row +1][f_col] = 0 if south == " "
maze[f_row][f_col-1] = 0 if west == " "
maze[f_row][f_col+1] = 0 if east == " "


s_row = 0
s_col = 0

row = 0
while row < maze.length
  col = 0
  while col < maze[row].length
    if maze[row][col] == 'S'
      s_row = row
      s_col = col
    end
    col += 1
  end
  row += 1
  end
count_to_s(maze)

count_down(maze, s_col, s_row)


remove_numbers(maze)

print_maze(maze)


########################################### Maze 2
when 2

maze = []

maze_file = File.open ("maze2.mz")
while ! maze_file.eof?

  first_line =  maze_file.gets.chomp.split("")
  maze << first_line

end
maze_file.close

f_row = 0
f_col = 0

row = 0
while row < maze.length
  col = 0
  while col < maze[row].length
    if maze[row][col] == 'F'
      f_row = row
      f_col = col
    end
    col += 1
  end
  row += 1
end

north = maze[f_row - 1][f_col]
south = maze[f_row + 1][f_col]
west = maze[f_row][f_col - 1]
east = maze[f_row][f_col + 1]

print_maze(maze)

maze[f_row -1][f_col] = 0 if north == " "
maze[f_row +1][f_col] = 0 if south == " "
maze[f_row][f_col-1] = 0 if west == " "
maze[f_row][f_col+1] = 0 if east == " "


s_row = 0
s_col = 0

row = 0
while row < maze.length
  col = 0
  while col < maze[row].length
    if maze[row][col] == 'S'
      s_row = row
      s_col = col
    end
    col += 1
  end
  row += 1
end

count_to_s(maze)

count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

remove_numbers(maze)

print_maze(maze)



#####################################################Maze 3
  when 3

    maze = []

    maze_file = File.open ("maze03.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

    print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end

    count_to_s(maze)

    count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

    remove_numbers(maze)

    print_maze(maze)

###################################################Maze 4
  when 4
    puts
    puts "This ain't never gonna work!" * 40
    puts

    # maze = []
    # maze_file = File.open ("maze04.mz")
    # while ! maze_file.eof?
    #
    #   first_line =  maze_file.gets.chomp.split("")
    #   maze << first_line
    #
    # end
    # maze_file.close
    #
    # f_row = 0
    # f_col = 0
    #
    # row = 0
    # while row < maze.length
    #   col = 0
    #   while col < maze[row].length
    #     if maze[row][col] == 'F'
    #       f_row = row
    #       f_col = col
    #     end
    #     col += 1
    #   end
    #   row += 1
    # end
    #
    # north = maze[f_row - 1][f_col]
    # south = maze[f_row + 1][f_col]
    # west = maze[f_row][f_col - 1]
    # east = maze[f_row][f_col + 1]
    #
    # print_maze(maze)
    #
    # maze[f_row -1][f_col] = 0 if north == " "
    # maze[f_row +1][f_col] = 0 if south == " "
    # maze[f_row][f_col-1] = 0 if west == " "
    # maze[f_row][f_col+1] = 0 if east == " "
    #
    #
    # s_row = 0
    # s_col = 0
    #
    # row = 0
    # while row < maze.length
    #   col = 0
    #   while col < maze[row].length
    #     if maze[row][col] == 'S'
    #       s_row = row
    #       s_col = col
    #     end
    #     col += 1
    #   end
    #   row += 1
    # end
    # count_to_s(maze)
    #
    # count, home_col, home_row, index, num = count_down(maze, s_col, s_row)
    #
    # remove_numbers(maze)
    #
    # print_maze(maze)
###################################################Maze 5
  when 5
    maze = []

    maze_file = File.open ("maze05.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

     print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end
    
look = 0
replace = 1
o_row = 0
o_col = 0
found_s = false
count = 0
while !found_s
  row = 0
  while row < maze.length

    col = 0
    while col < maze[row].length
      if maze[row][col] == look
        o_row = row
        o_col = col

        if (o_row - 1 > 0) && maze[o_row -1][o_col] == " "
          maze[o_row -1][o_col] = replace
        end
        if ( o_row + 1 < maze.length ) && maze[o_row + 1][o_col] == " "
          maze[o_row + 1][o_col] = replace
        end
        if  (o_col - 1 >= 0) &&  maze[o_row][o_col - 1]  == " "
          maze[o_row][o_col - 1 ] = replace
        end
        if (o_col + 1 < maze[row].length) && maze[o_row][o_col + 1] == " "
          maze[o_row][o_col + 1] = replace
        end
        if (o_row - 1 > 0) && maze[o_row -1][o_col]  == "S"
          found_s = true
        end
        if ( o_row + 1 < maze.length ) && maze[o_row +1][o_col] == "S"
          found_s = true
        end
        if  (o_col - 1 >= 0) && maze[o_row][o_col - 1 ] == "S"
          found_s = true
        end
        if (o_col + 1 < maze[row].length) && maze[o_row][o_col +1] == "S"
          found_s = true
        end
      end
      col += 1

    end
    row += 1

  end
  count +=1
  look +=1
  replace +=1
end



num = 20
index = 1

if maze[s_row - 1][s_col].class == Fixnum
  num = maze[s_row - 1][s_col]
  maze[s_row - 1][s_col] = "*"
  home_row = s_row - 1
  home_col = s_col
  count = num
elsif maze[s_row + 1][s_col].class == Fixnum
  num = maze[s_row + 1][s_col]
  maze[s_row + 1][s_col] = "*"
  home_row = s_row + 1
  home_col = s_col
  count = num
elsif  maze[s_row][s_col + 1].class == Fixnum
  num = maze[s_row][s_col + 1]
  maze[s_row][s_col + 1] = "*"
  home_row = s_row
  home_col = s_col +1
  count = num
elsif  maze[s_row][s_col - 1].class == Fixnum
  num = maze[s_row][s_col - 1]
  maze[s_row][s_col - 1] = "*"
  home_row = s_row
  home_col = s_col - 1
  count = num
end

while count >=  0
  if maze[home_row - index][home_col].class == Fixnum
    if maze[home_row - index][home_col] < num
      num = maze[home_row - index][home_col]
      maze[home_row - index][home_col] = "*"
      home_row = home_row - index
      home_col = home_col
    end
  end
  if maze[home_row + index][home_col].class == Fixnum
    if maze[home_row + index][home_col] < num
      num = maze[home_row + index][home_col]
      maze[home_row + index][home_col] = "*"
      home_row = home_row + index
      home_col = home_col
    end
  end
  if maze[home_row][home_col + index].class == Fixnum
    if maze[home_row][home_col + index] < num
      num = maze[home_row][home_col + index]
      maze[home_row][home_col + index] = "*"
      home_row = home_row
      home_col = home_col + index
    end
  end
  if maze[home_row][home_col - index].class == Fixnum
    if maze[home_row][home_col - index] < num
      num = maze[home_row][home_col - index]
      maze[home_row][home_col - index] = "*"
      home_row = home_row
      home_col = home_col - index
    end

  end

    index +1
    count -=1
end


    remove_numbers(maze)

    print_maze(maze)
###################################################Maze 6
  when 6
    maze = []

    maze_file = File.open ("maze06.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

    # print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end

    count_to_s(maze)

    count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

    remove_numbers(maze)

    print_maze(maze)

###################################################Maze 7

  when 7
    maze = []
    maze_file = File.open ("maze07.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

    print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end
    count_to_s(maze)

    count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

    remove_numbers(maze)

    print_maze(maze)

####################################################################Maze 8

  when 8
    maze = []
    maze_file = File.open ("maze08.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

    print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end
    count_to_s(maze)

    count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

    remove_numbers(maze)

    print_maze(maze)

#############################################################Maze 9
  when 9

    maze = []

    maze_file = File.open ("maze09.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

    print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end

    count_to_s(maze)

    count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

    remove_numbers(maze)

    print_maze(maze)
##################################################################Maze 10

  when 10

    maze = []

    maze_file = File.open ("maze010.mz")
    while ! maze_file.eof?

      first_line =  maze_file.gets.chomp.split("")
      maze << first_line

    end
    maze_file.close

    f_row = 0
    f_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'F'
          f_row = row
          f_col = col
        end
        col += 1
      end
      row += 1
    end

    north = maze[f_row - 1][f_col]
    south = maze[f_row + 1][f_col]
    west = maze[f_row][f_col - 1]
    east = maze[f_row][f_col + 1]

    print_maze(maze)

    maze[f_row -1][f_col] = 0 if north == " "
    maze[f_row +1][f_col] = 0 if south == " "
    maze[f_row][f_col-1] = 0 if west == " "
    maze[f_row][f_col+1] = 0 if east == " "


    s_row = 0
    s_col = 0

    row = 0
    while row < maze.length
      col = 0
      while col < maze[row].length
        if maze[row][col] == 'S'
          s_row = row
          s_col = col
        end
        col += 1
      end
      row += 1
    end

    count_to_s(maze)

    count, home_col, home_row, index, num = count_down(maze, s_col, s_row)

    remove_numbers(maze)

    print_maze(maze)



end #end case
end #end main while loop
