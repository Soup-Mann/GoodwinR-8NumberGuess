# GoodwinR-8NumberGuess
Reed Goodwin
10/20/2022
MiniChallenge#8 Guess It
This program generates a random number 1-10 and asks you to try and guess it

Peer Review by; Pedro Castaneda - When you follow the instructions and input a number or say 'yes' or 'no' the code runs perfectly! But the validation has bugs. For example, if the input is not a number it will say 'Invalid Entry' but it will still go ahead and run the while loop containing the guessing game. It will still proceed with the game even though you gave an invalid entry. There is also validation for the play again feature. When the game starts you prompted to 'Please Input a Number!' but it is not clear why. I would suggest adding a Console.WriteLine(); that says what game you are playing and what numbers to guess between. I like how you used Int64 to account for longer numbers. Let me know when you fix the issues so I can update your review!
