// See https://aka.ms/new-console-template for more information
using System.Text;
using System;
using System.Runtime.CompilerServices;

//Console.WriteLine(Environment.CurrentDirectory);
string input_filepath = "../../../input.txt";
string input_content = File.ReadAllText(input_filepath);

int current_dialstate = 50;
const int MAX_DIAL = 99;
const int MIN_DIAL = 0;
int amount_of_zeros = 0;


// Proccessing information into a usable array
List<int> processed_input = new List<int>();
StringBuilder sb = new StringBuilder();
bool first = true;
foreach (var line in input_content)
{
    if (first)
    {
        first = false;
        continue;
    }

    if (line == 'L' || line == 'R')
    {
        //Console.WriteLine(sb);
        processed_input.Add(Int32.Parse(sb.ToString()));
        sb.Clear();
    }

    if (line == 'L') 
    {
        sb.Append("-");
    }
    else if ((char.IsWhiteSpace(line) != true) && (line != 'R'))
    {
        sb.Append(line);
    }
}

//Console.WriteLine("TEST");
//current_dialstate = 99;
//if (current_dialstate > 99)
//{
//    int amount_of_divisions = current_dialstate / 100;

//    for (int i = 0; i < amount_of_divisions; i++)
//    {
//        current_dialstate -= 100;
//    }

//}

//if (current_dialstate < 0)
//{
//    int amount_of_divisions = Math.Abs(current_dialstate / 100) + 1;
//    Console.WriteLine(amount_of_divisions);
//    for (int i = 0; i < amount_of_divisions; i++)
//    {
//        current_dialstate += 100;
//    }

//}
//Console.WriteLine(current_dialstate);


Console.WriteLine("Starting Dialstate is " + current_dialstate.ToString());
foreach (var move in processed_input)
{
    
    Console.WriteLine("The dial rotated " + move.ToString());


    current_dialstate += move;
    // Normalize: force into correct range
    if (current_dialstate > MAX_DIAL)
    {
        int amount_of_divisions = current_dialstate / 100;

        for (int i = 0; i < amount_of_divisions; i++)
        {
            current_dialstate -= 100;
        }
    }

    if (current_dialstate < MIN_DIAL)
    {
        int amount_of_divisions = Math.Abs(current_dialstate / 100) + 1;
        for (int i = 0; i < amount_of_divisions; i++)
        {
            current_dialstate += 100;
        }

    }

    if (current_dialstate == 0)
    {
        amount_of_zeros++;
        Console.WriteLine(amount_of_zeros);
     }

    Console.WriteLine("Current Dialstate is " + current_dialstate.ToString());

}


Console.WriteLine("AMOUNT OF ZEROS AND FINAL ANSWER IS: " + amount_of_zeros.ToString());


//if (current_dialstate + move >= 99) //WORKS
//{
//    current_dialstate = (current_dialstate + move) / 100;
//    //current_dialstate = Math.Abs(max_dial - current_dialstate - move + 1);
//    //if (current_dialstate >= 99)
//    //    current_dialstate = current_dialstate % 100;

//} else if (current_dialstate + move <= 0)
//{
//    //current_dialstate = max_dial + move + current_dialstate + 1;
//    //if (current_dialstate <= 0)
//    current_dialstate = (current_dialstate + move) / 100;


// THIS ONE WOULD WORK BUT C# HAS SOME MODULU QUIRKS WHICH BREAK IT
//if (current_dialstate + move > 99)
//{
//    current_dialstate = (current_dialstate + move) % 100;
//}
//else if (current_dialstate + move < 0)
//{
//    int abs_move = Math.Abs(current_dialstate + move);
//    current_dialstate = abs_move % -100;
//}
//else
//{
//    //Console.WriteLine($"*    In bounds: {current_dialstate + move}");
//    current_dialstate += move;

//}