# _Word Counter_

#### _A program that counts selected words in a given sentence, Created 2/15/19 Updated 2/20/19, 2/21/19, 2/22/19, 2/28/19_

#### By _**Micaela Jawor**_

## Description

A program (using C#) that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would **not** be counted.)

## Specifications

| Behavior | Example Input | Expected Output |
| --- | :---: | :---: |
| User inputs a letter as a string | word = "a" | true |
| User inputs a single letter string as the word and a single letter as the sentence, and the program outputs 1 match | word = "a" and sentence = "a" | 1 |
| User inputs a single letter string as the word and multiple letters as the sentence, and the program outputs 2 matches | word = "a" and sentence = "a a" | 2 |
| User inputs the string "hey" as the word and a sentence containing multiple instances of the word "hey", and the program outputs 2 matches | word = "hey" and sentence = "hey hey listen" | 2 |
| User inputs the string "cat" as the word and a sentence containing multiple words with only one instance of the word "cat" and with other words containing the string "cat". The Program should only match the inputted string word and not words containing the inputted string word. The Program should output 1 match. | word =  "cat" sentence = "the cat in the cathedral caught the other cats chasing the rat" | 1 |

## Setup/Installation Requirements

* _Download .NET Core 1.1.4 SDK and .NET Core Runtime 1.1.2 and install them._
* _Download Mono and install it._

* _Please visit the Word Counter repository <a href="https://github.com/MicaelaDJ/Word-Counter">at this link</a>._
* _Clone repository or download to desktop_
* _Change into the work directory: $ cd WordCounter.Solution
* _Open files using IDE (Atom or Visual Code Studio) to view code._
* _To run the program, first navigate to the location of the WordCounter folder then compile and execute: $ mcs Program.cs Models/Counter.cs; mono Program.exe;_
* _To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test_

* _Open Mac Terminal or Windows Command Prompt._
* _Type "cd WordCounter.Solution" and press enter to go to the solution directory._
* _Type "cd WordCounter" and press enter to go to the application directory._
* _Type "dotnet restore" and press enter_
* _Type "dotnet build" and press enter_
* _Type "dotnet run" and press enter_
* _Open a web browser and go to http://localhost:5000/_

## Known Bugs

_No known bugs_

## Support and contact details

_If you run into any issues or have questions, ideas or concerns.  Please email me @ micaelajawor@yahoo.com_

## Technologies Used

* _Atom_
* _C#_

### License

*MIT*

Copyright (c) 2019 **_Micaela Jawor_**
