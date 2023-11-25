string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
    string caseIntensitiveWord = word.ToLower();
    if (wordsCount.ContainsKey(caseIntensitiveWord))
    {
        wordsCount[caseIntensitiveWord] += 1;
    }
    else 
    { 
      wordsCount.Add(caseIntensitiveWord, 1);
    }
}
foreach (KeyValuePair<string, int> pair in wordsCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}