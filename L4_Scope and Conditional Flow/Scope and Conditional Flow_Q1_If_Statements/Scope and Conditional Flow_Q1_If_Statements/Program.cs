//Part 1
// Get two inputs from the userds and store them in two variables and use and if statement to check if the two inputs are equal and print out a message to the console.
// Hint: You can use the == operator to check if two values are equal.


//Part 2
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than the second input and print out a message to the console.
// Hint: You can use the > operator to check if the first input is greater than the second input.

//Part 3
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than the second input and print out a message to the console.
// Hint: You can use the < operator to check if the first input is less than the second input.

//Part 4
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is not equal to the second input and print out a message to the console.
// Hint: You can use the != operator to check if two values are not equal.

//Part 5
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than or equal to the second input and print out a message to the console.
// Hint: You can use the >= operator to check if the first input is greater than or equal to the second input.

//Part 6
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than or equal to the second input and print out a message to the console.
// Hint: You can use the <= operator to check if the first input is less than or equal to the second input.

//Part 7
// Create a math quiz that asks the user a math question and checks if the user's answer is correct. If the user's answer is correct, print out a message to the console. If the user's answer is incorrect, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user's answer is correct.


//Part 8
// Create a program that asks the user for their age and checks if the user is old enough to vote. If the user is old enough to vote, print out a message to the console. If the user is not old enough to vote, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user is old enough to vote.


//Part 9
// Create a program that check whihc state a enemy is in based on their health points. If the enemy has 100 health points, print out a message to the console. If the enemy has 50 health points, print out a different message to the console. If the enemy has 25 health points, print out a different message to the console. If the enemy has 0 health points, print out a different message to the console.
// Hint: You can use an if-else statement to check the enemy's health points and print out a message based on the enemy's health points.

//Part 10
// Create a program that checks if a user is eligible for a discount based on their age. If the user is 18 years old or older, print out a message to the console. If the user is younger than 18 years old, print out a different message to the console.
// Hint: You can use an if-else statement to check the user's age and print out a message based on the user's age.






////////////// Break , Continue Statements //////////////


//Part 1
// Create a program that counts from 1 to 20, but skips counting the number 5.
// Hint: Use a for loop to iterate through the numbers and a continue statement to skip the number 5.

//Part 2
// Create a program that prints the numbers from 1 to 10, but breaks the loop if the number 7 is encountered.
// Hint: Use a for loop to iterate through the numbers and a break statement to exit the loop when 7 is encountered.

//Part 3
// Write a program to print all even numbers from 1 to 20, but skip printing the number 10.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 10.

//Part 4
// Create a program that searches for the word "apple" in a list of fruits. If found, print "Apple found!"; otherwise, continue searching.
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement to check if the current fruit is "apple". Use a continue statement to continue searching if "apple" is not found.

//Part 5
// Write a program to count from 1 to 100, but skip counting by 10s.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip counting by 10s.

//Part 6
// Create a program to print the letters of the alphabet from A to G, but skip printing the letter 'E'.
// Hint: Use a for loop to iterate through the alphabet and an if statement with a continue statement to skip printing 'E'.

//Part 7
// Write a program to find and print all prime numbers between 1 and 50, skipping non-prime numbers.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip non-prime numbers.

//Part 8
// Create a program to print the numbers from 1 to 10, but skip printing the number 3.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 3.

//Part 9
// Write a program to search for the number 20 in an array of integers. If found, print its index; otherwise, continue searching.
// Hint: Use a for loop to iterate through the array and an if statement to check if the current element is 20. Use a continue statement to continue searching if 20 is not found.

//Part 10
// Create a program that prints the names of different fruits, but skips printing the name "banana".
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement with a continue statement to skip printing "banana".





////////////// Extra Challenges //////////////

/*
Part 11

ABC Company pays its sales agents on a commission basis. 
Each agent is paid 10% commission for monthly sales above or equal to $10,000 and 5% commission for monthly sales below $10,000.

Write a program to accept the monthly sales of a particular agent and based on the amount, determine and print out the commission earned.

Example:
Enter the monthly sales: 12000
Commission earned: $1200.00

*/


/*
Part 12

Write a program that generates two integers between 0 and 100 inclusive and prompts the user to enter the sum of these 2 integers. The program reports if the answer is correct or wrong (program will also print the correct answer if the user's answer is wrong).

Hint: You need to use the random module.

Example:
Enter the sum of 43 and 58: 100
Correct!

 */



/*
 Part 13

The grade that you get for a module depends on your marks. The table below shows the grade for each range of marks.

Marks   |   Grade   |   Comment
---------------------------------
>= 85   |     A+    |  Excellent!
>= 80   |     A     |  Well done.
>= 75   |     B+    |
>= 70   |     B     |
>= 65   |     C+    |
>= 60   |     C     |
>= 55   |     D+    |
>= 50   |     D     |
< 50    |     F     |  See me.

Write a program that asks for a student’s marks, then displays the correct grade and the corresponding comment (if any).

Example:
Enter student's marks: 82
Grade: A
Comment: Well done.
 

 
 */




/*
 Part 14

 A guard in a computer game acts as follows:

If sees_player == False, he will wait

If sees_player == True:
    - If dist_from_player <= 1, he will attack
    - If 2 <= dist_from_player <= 4, he will advance
    - If dist_from_player >= 5, he will wait

Write a program that shows how the guard will act.

Example:
sees_player = True
dist_from_player = 3

The guard will advance.

 
 
 */