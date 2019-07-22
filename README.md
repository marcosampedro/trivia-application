# trivia-application
This is a trivia application made using C# that allows you to play a game of trivia by using the pre-loaded questions, or by customizing the game with your own questions

## Usage


The first form you'll be presented with after starting the TriviaNow.sln is the form consisting of a Question Pool. 
Upon opening, the listbox containing the questions will be empty. You must first add a question or load the 
pre-existing "data.dat" file before you can edit, search, delete questions, or play the trivia game.

To add a question, locate the Questions > Add menu item. When adding a question, you must enter all the fields, 
and most importantly, you must add a number between 1-4 for the "Correct Choice:" textbox, corresponding to 
the Choice # your answer is in.

Once you have at least three questions in the listbox, you will now be able to edit, search, delete questions, 
or play the trivia game. 

To update (edit) a question, you have the option to either locate the Questions > Edit menu item,
or you can simply just double click the question in the listbox.

If you want to edit or delete a question, you must ensure that you select the item you want to modify before
you choose the menu tool item.

Once you're ready to play the trivia game, locate the Play! > Start New Game menu item, and 
enjoy the game! Once the game is finished, click on the "Close Trivia Form" button to close the trivia game form,
and to be redirected back to the Question Pool form.

Once you're satisfied with the application, feel free to save your listbox questions (which will overwrite the 
previous "data.dat" file), using the File > Save menu item.

To cleanly exit out all forms, locate the File > Close menu item.

## License 
The MIT License (MIT)

Copyright (c) 2019 Marco Sampedro

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
