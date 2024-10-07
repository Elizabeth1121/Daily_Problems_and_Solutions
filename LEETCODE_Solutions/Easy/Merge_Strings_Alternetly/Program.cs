string word1 = "sakj";
string word2 = "hijk";

string result = mergedString(word1, word2);
Console.WriteLine(result);

string mergedString (string word1, string word2)
{
    string mergedString = "";
    int shorterString = 0;

    if(word2.Length < word1.Length)
    {
        shorterString = word2.Length;
    }
    else
    {
        shorterString = word1.Length;
    }

    for (int i = 0; i < shorterString; i++)
    {
        mergedString += word1[i];
        mergedString += word2[i];
    }

    if(shorterString == word1.Length)
    {
        mergedString += word2.Substring(shorterString);
    }
    else
    {
        mergedString += word1.Substring(shorterString);
    }

    return mergedString;
}