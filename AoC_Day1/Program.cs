// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Console.WriteLine(Environment.CurrentDirectory);
string input_filepath = "../../../input.txt";
string content = File.ReadAllText(input_filepath);

int dial_start = 50;
int max_dial = 99;
int min_dial = 0;
int amount_of_zeros;

Console.WriteLine(content);
