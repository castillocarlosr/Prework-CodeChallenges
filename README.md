# Prework-CodeChallenges
Code401

# Code Challenges 
<!-- For each of the challenges below, create a new method in a single Console application. All of your code should live in the `Program.cs`
file. Utilize the `Main()` method to call each challenge method, you may create additional external methods as appropriate.  -->

## Problem 1: Array Max Result

#### Problem Statement
Given an array select a number that exists, and output the computated "score". The method will take in both an array of integers and the integer "you" the user selected.

The console will ask you "the user" for 5 numbers between 1-10.  Press enter when done.
The console will now ask the user for another number from the list.  Press enter.

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

The console will ask "the user" to enter a year.  Press enter when done.
The console will display the year the user entered and whether it is a leap year or not.

#### Sample Input
2000

#### Sample Output
The year 2000 is a leap year!

##### Screen capture of successful output.
![](ScreenShots/Capture2.PNG?raw=true)


<hr />

## Problem 3: Perfect Sequence

#### Problem Statement
Given a sequence. Return "Yes" if the sequence is considered a perfect sequence. Otherwise, return "No"

#### Perfect Sequences
A perfect sequence is a sequence such that all of its elements are non-negative integers and the product of all of them is equal to their sum. 
For example: [2,2], [1,3,2] and [0,0,0,0] are perfect sequences and [4,5,6] and [0,2,-2] are not perfect sequences. Negative numbers of any kind are not valid in 
a perfect sequence

#### Input Format
An array of integers (may not be sorted)

#### Sample Input
[1,3,2]

#### Sample Output
Yes

#### Explanation
1 * 3 * 2 = 6 && 1 + 3 + 2 = 6

#### Readme
A section of your readme should contain basic information outlining the requirements for the challenge
1. Name of Challenge
2. Instructions of Challenge
3. Screen capture of successful output. 


<hr />

## Problem 4: Sum of Rows

#### Problem Statement
Given a matrix of integers. Return the sum of each row in a single dimensional array. 

#### Input Format
a multidimensional array with the dimensions of **m x n** (m = rows, n = columns).

1. duplicate integers are possible.
2. Negative numbers are possible
3. both **m** and **n** can vary in length

#### Sample Input
```csharp
int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
```

^^ The actual input would just be `myArray`, but the above code shows the pre-initialization before the method is called. 

#### Sample Output

{10,40,65} <-- an integer array

#### HINTS
- for loops are your best friend
- GetLength() is a method you should look into
	- i.e. in the array above myArray.GetLength(0) is equal to 3
	- myArray.GetLength(1) is equal to 5
	

#### Readme
A section of your readme should contain basic information outlining the requirements for the challenge
1. Name of Challenge
2. Instructions of Challenge
3. Screen capture of successful output. 
