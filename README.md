# Find and Replace

#### C# Epicodus week 3 project, 02/16/2018

#### By **Nanette Girzi**

## Description

This program is a basic web application where a user will Input 1. A word, and Input 2. A phrase or sentence. The word in input 1 will then be searched for in  the phrase or sentence of input 2 for the number of occurrences.


## Setup/Installation Requirements

* Clone this repository to your desktop
* Navigate to project folder on desktop
* In terminal, inside project folder, type command "dotnet resotore" "dotnet build", then "dotnet run"
* Open browser and go to http://localhost:5000

## Specifications

* Behavior
  * Detect occurrence of single letter and identical 2nd input. This is the first logical smallest comparison test. Making sure to compare single letter to single letter.
* Input Word
  * "a"
* Input String
  * "a"
* Output Example
  * "1"

* Behavior
  * Detect occurrence of single word and identical 2nd input. This is the next logical smallest comparison test. Making sure to compare single word to single word.
* Input Word
  * "and"
* Input String
  * "and"
* Output Example
  * "1"  

* Behavior
  * Detect occurrence of word and with multiple word input. Next logical comparison test to compare multiple work string. Making sure will loop through all words and output correct count.
* Input Word
  * "and"
* Input String
  * "me and you"
* Output Example
  * "1"  

* Behavior
  * Detect occurrence of single word with multiple word input. Making sure will loop through all words and output correct count.
* Input Word
  * "and"
* Input String
  * "me and you, and everyone we know"
* Output Example
    * "2"  

* Behavior
  * Detect occurrence of words with different cases in string. Making sure all instances of word no matter what case is entered will be counted.
* Input Word
    * "and"
* Input String
    * "me And you, and everyone we know"
* Output Example
    * "2"  


## Known Bugs

No known bugs at this time.

## Support and contact details

If you have suggestions please email ngirzi@gmail.com

## Technologies Used

* C#
* HTML
* CSS
* Bootstrap
* MVC  
* Razor

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **Nanette Girzi**
