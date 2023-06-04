This program was not easy to make, and I ran out of time to polish it as I had wanted.
With that in mind, here are some useful things to know:

1. There is no exception handling in the code. Anything that is entered contrary to what the program is looking for
    can and will crash it.
2. There are some points where a Console.ReadLine() method was used to allow the user to read information, but there
    isn't any notice other than the program seems to be frozen. Pressing enter will allow the user to continue.
3. I wasn't able to make time to insert trim methods to strings. This means that when dollar and percentage amounts 
    are asked, the program is looking for a number without any symbols other than a decimal.
4. Any request for a percentage, such as interest rate, should be entered as the percentage and not the decimal (i.e. 
    100 instead of 1, or 5.27 instead of 0.0527). Once again, please don't add a % or $ symbol to any numbers.
5. I had forgotten that C# includes a decimal variable on top of a float. My program would have been made better with 
    a decimal variable; however, the program will still function as expected.
6. There is currently no function that saves the transactions, only the budget itself.

Other than that, please enjoy my program.