# Prework-CodeChallenges
Code401

# Code Challenges 
<!-- For each of the challenges below, create a new method in a single Console application. All of your code should live in the `Program.cs`
file. Utilize the `Main()` method to call each challenge method, you may create additional external methods as appropriate.  -->

## Problem 1: Array Max Result

#### Problem Statement
Given an array select a number that exists, and output the computated "score". The method will take in both an array of integers and the integer "you" the user selected.

-The console will ask you "the user" for 5 numbers between 1-10.  Press enter when done. 
<br />-The console will now ask the user for another number from the list.  Press enter. 

#### Selection and Scoring Algorithm
The scoring will be depend on the frequency of the number the user selected and check the frequency of that number to the list of the first 5 numbers the user selected. 
E.g for [2,2,3,5,4] if you pick 2 your score will be "4" (2 * 2).  But if you pick 5 your score will be "5" (5 * 1).

#### Sample Input
[6,4,4,1,4] , 4

#### Sample Output
12

##### Screen capture of successful output. 
![](ScreenShots/Capture1.PNG?raw=true)


<hr />

## Problem 2: Leap Year Calculator

#### Problem Statement
Given a year, the output report will calculate if it is a leap year.

Leap years in the Gregorian calendar occurs as follows:
```
on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400
```

-The console will ask "the user" to enter a year.  Press enter when done. 
<br />-The console will display the year the user entered and whether it is a leap year or not. 

#### Sample Input
2008

#### Sample Output
The year 2008 is a leap year!

##### Screen capture of successful output.
![](ScreenShots/Capture2_1.PNG?raw=true)
![](ScreenShots/Capture2_2.PNG?raw=true)


<hr />

## Problem 3: Perfect Sequence

#### Problem Statement
Given a sequence. Return "Yes" if the sequence is considered a perfect sequence. Otherwise, return "No".

-The console will ask "the user" to enter the first integer. 
<br />-The console will ask "the user" to then enter a second integer. 
<br />-The console will ask "the user" to either enter another integer or press ENTER if done entering integers. 
<br />-The user may enter as many integers as the user want. 
<br />-The console will display the numbers entered in an array and calculate if the numbers entered are a perfect sequence.   
<br />--Explanation of perfect sequence below :arrow_down:. 

#### Perfect Sequences
A perfect sequence is a sequence such that all of its elements are non-negative integers and the product of all of them is equal to their sum. 
For example: [2,2], [1,3,2] and [0,0,0,0] are perfect sequences and [4,5,6] and [0,2,-2] are not perfect sequences. Negative numbers of any kind are not valid in a perfect sequence.
#### Explanation
[1 * 3 * 2] = 6 && [1 + 3 + 2] = 6
<br />[4 * 5] = 20 && [4 + 5] = 9

#### Sample Input
[1,3,2]

#### Sample Output
Yes

##### Screen capture of successful output.
![](ScreenShots/Capture3_1.PNG?raw=true)
![](ScreenShots/Capture3_2.PNG?raw=true)

<hr />

## Problem 4: Sum of Rows

#### Problem Statement
Given a matrix of integers. Return the sum of each row in a single dimensional array. 

-The console will ask "the user" to enter the number of rows the user wants. 
<br />-The console will ask "the user" to enter the number of columns the user wants. 

<br />-The console will display a 2-D array with the number of rows and columns entered. 
<br />-The integers will be randomly be generated from negative 99 to positive 99. 
<br />-The console will display the results on the next line. 

#### Sample Input
```csharp
int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
```
#### Sample Output

{15,40,65} <-- an integer array

##### Screen capture of successful output.
![](ScreenShots/Capture4_1.PNG?raw=true)
