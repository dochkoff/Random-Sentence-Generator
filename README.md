# Random-Sentence-Generator

A console-based C# implementation of "Random-Sentence-Generator".

<p>
<img alt="Image" width="350"px src="https://user-images.githubusercontent.com/74410756/208237853-916e7580-a08b-4272-ac4b-f6e6e9b079db.png">
</p>

## Overview
This random sentence generator is just for fun! These sentences can provide humor and be a cool way to surprise others by sharing a standout sentence on social media platforms and gathering your network's reaction.

## Input and Output
The computer generate random sentance and after pressing `Enter` will be generated new one.

## Solution
The **Generator** is based on the following model:

- [Sentence] = `Who` + `Action` + `Details`

  - **Who** = `Name`|`Name` form `Place`

    - Nemes = { Peter, Michell, Jane, Steve, ... }
    - Places = { Sofia, Plovdiv, Varna, Burgas, ... }

  - **Action** = `Verb` + `Noun`|`Adverbs` + `Verb` + `Noun`

    - Verbs = { eats, holds, sees, plays with, brings, ... }
    - Nouns = { stones, cake, apple, laptop, bikes, ... }
    - Adverbs = { slowly, diligently, warmly, sadly, rapidly, ... }

  - **Details** = { near the river, at home, in the park }

## Source Code
[Source code of the project](RandomSentenceGenerator.cs)

## Screenshots
<img width="414" alt="Screen Shot 2022-12-17 at 13 11 11" src="https://user-images.githubusercontent.com/74410756/208238898-d4e3add4-81b2-420c-997c-c1d825109ca9.png"> <img width="415" alt="Screen Shot 2022-12-17 at 13 13 59" src="https://user-images.githubusercontent.com/74410756/208239014-df0cd826-7a97-42bd-9068-bfa46d6e3b38.png">


## One-Click Live Demo

[<img alt="Play" src="https://user-images.githubusercontent.com/74410756/193477520-ba86bbff-a312-4dbf-942a-c24e902073f7.png">](https://replit.com/@Dochkoff/Random-Sentence-Generator#Main.cs)
