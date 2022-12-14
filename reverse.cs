
string word = "Hello World";
string word1 = string.Empty;

for (int i = word.Length - 1; i >= 0; i--)
{
    word1 += word[i];
}

string word2 = word1.Split(' ')[1];
string word3 = word1.Split(' ')[0];


Console.WriteLine($"{word2} {word3}");


