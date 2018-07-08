# WordCount2

#### Epicodus C# - Week 2 Independent Project

#### By Scott Fraser

## Exercise in MVC's with C#
This is a program that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check. The program will check for full word matches only. This is only the logic for the program, any reference to user interface is hard coded for testing purposes.

| Behavior	| INPUT	| OUTPUT |
| :----------:| :-----: | :-------:|
|User inputs first word and program set it as string | "hello" | "hello"|
|If user inputs more than one word, there is an error message | "hello world" | "something went wrong, enter a word"|
|If user enters nothing, there is an error message | "" | "something went wrong, enter a word" |
|If user enters a number, there is an error message | "h3ll0" |"something went wrong, enter a word"|
|If user enters capital letters, the program makes them all lowercase| "HeLlO"| "hello"|
|User inputs several words and program saves it as a string *empty and number errors apply, all words made lowercase as well*| "hello word"|"hello world"|
|The program takes list of words and splits it into a string array| "hello word"| { "hello", "world" }
|The program compares each string in string array to original user input word and counts instances of a match| "hello hello world"| 2|

## Setup/Contribution Requirements

1. Clone the repo
1. Open Solutions folder in Visual Studio
1. Run Tests

## Technologies Used

* C# / .net
* Visual Studio
* Atom (for README)

## Links

* https://github.com/scottafraser/WordCounter.git

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Scott Fraser**
