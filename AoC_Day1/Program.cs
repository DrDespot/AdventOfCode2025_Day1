// See https://aka.ms/new-console-template for more information
using System.Text;

//Console.WriteLine(Environment.CurrentDirectory);
string input_filepath = "../../../input.txt";
string input_content = File.ReadAllText(input_filepath);

int current_dialstate = 50;
int max_dial = 99;
int min_dial = 0;
int amount_of_zeros;


// Proccessing information
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

// Insert processed infromation into array
Console.WriteLine("Array");
foreach (var move in processed_input)
{
    Console.WriteLine(move.ToString());
}


Console.WriteLine("Array");
foreach (var move in processed_input)
{
    Console.WriteLine("The dial rotated " + ToString(move));


    if currentdialstate + move => max
        currentdialstate = abs(current_dialstate - move) + min_dial
    if currentddialstate - move =< min
        currentdialstate = maxdial - (abs(move) - current_dialstate)
    else 
        current_dialstate += move

    if currentdialstate == 0
        amountofzeros += 1

}
