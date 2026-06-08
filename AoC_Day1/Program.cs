// See https://aka.ms/new-console-template for more information
using System.Text;
using System;
using System.Runtime.CompilerServices;

//Console.WriteLine(Environment.CurrentDirectory);
string input_filepath = "../../../input.txt";
string input_content = File.ReadAllText(input_filepath);

int current_dialstate = 50;
int max_dial = 99;
int min_dial = 0;
int amount_of_zeros;


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

// Print array
//Console.WriteLine("Array");
//foreach (var move in processed_input)
//{
//    Console.WriteLine(move.ToString());
//}


Console.WriteLine("Array");
foreach (var move in processed_input)
{
    Console.WriteLine("Current Dialstate is " + current_dialstate.ToString());
    Console.WriteLine("The dial rotated " + move.ToString());

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



    if ((current_dialstate + move > 99) || (current_dialstate + move < 0))
    {
        current_dialstate = current_dialstate % 100;
    }
    else
    {
        Console.WriteLine($"*    In bounds: {current_dialstate + move}");
        current_dialstate += move;

    }

  
}
