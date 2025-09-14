//1 Task
//int[] arr = { 5, 4, 6 };

//for (int i = 0; i < arr.Length; i++)
//{
//    int fact = 1;
//    for (int j = 2; j <= arr[i]; j++)
//    {
//        fact *= j;
//    }
//    arr[i] = fact;
//}

//Console.WriteLine(string.Join(", ", arr));

// 2 Task

//int[] arr = { 7, 12, 5, 8 };


//int min = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] < min) min = arr[i];
//}



// 3 Task

//string text = "kərtənkələ";
//char result = '\0';

//for (int i = 0; i < text.Length; i++)
//{
//    char c = text[i];
//    int count = 0;
//    for (int j = 0; j < text.Length; j++)
//    {
//        if (text[j] == c) count++;
//    }
//    if (count == 1)
//    {
//        result = c;
//        break;
//    }
//}
//Console.WriteLine(result);

//4 Task
//Console.Write("Ədədi daxil edin: ");
//int n = int.Parse(Console.ReadLine());

//if (n <= 1)
//{
//    Console.WriteLine("Nə sadədir, nə mürəkkəb");
//    return;
//}

//bool sade = true;
//for (int i = 2; i <= n / 2; i++)
//{
//    if (n % i == 0)
//    {
//        sade = false;
//        break;
//    }
//}

//if (sade)
//    Console.WriteLine("Sadə ədəddir");
//else
//    Console.WriteLine("Mürəkkəb ədəddir");

//5 Task




//int N = 70;
//int M = 130;

//Console.WriteLine($"Palindrom ədədlər {N}-{M} aralığında:");

//for (int i = N; i <= M; i++)
//{
//    int n = i;
//    int reversed = 0;

//    while (n > 0)
//    {
//        reversed = reversed * 10 + n % 10;
//        n /= 10;
//    }

//    if (i == reversed)
//        Console.Write(i + " ");
//}






//6 Task

//string text = "kərtənkələ";

//char maxChar = text[0];
//int maxCount = 0;

//for (int i = 0; i < text.Length; i++)
//{
//    char c = text[i];
//    int count = 0;

//    for (int j = 0; j < text.Length; j++)
//    {
//        if (text[j] == c) count++;
//    }

//    if (count > maxCount)
//    {
//        maxCount = count;
//        maxChar = c;
//    }
//}

//Console.WriteLine($"Ən çox təkrarlanan simvol: '{maxChar}', {maxCount} dəfə");
//ev tapsirigi
