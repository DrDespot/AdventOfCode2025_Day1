// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


//Console.WriteLine(Environment.CurrentDirectory);
string input_filepath = "../../../input.txt";
string input_content = File.ReadAllText(input_filepath);

int current_dialstate = 50;
int max_dial = 99;
int min_dial = 0;
int amount_of_zeros;


// Proccessing information into 
int[] processed_input;
StringBuilder sb = new StringBuilder();
foreach (var line in input_content)
{
    
    if (line == 'L' || line == 'R')
    {
        Console.WriteLine(sb);
        sb.Clear();
    }

    if (line == 'L')
    {
        sb.Append("-");
    }
    else if (line == 'R')
    {

    }
    else if (char.IsWhiteSpace(line) != true)
    {
        sb.Append(line);
    }

    

}