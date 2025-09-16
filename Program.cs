////1Task
//int a = 455555;

//// Подсчитываем количество каждой цифры
//int[] counts = new int[10];
//foreach (char ch in a.ToString())
//{
//    counts[ch - '0']++;
//}

//// Собираем максимальное число из цифр (от 9 к 0)
//int maxNumber = 0;
//for (int d = 9; d >= 0; d--)
//{
//    while (counts[d]-- > 0)
//    {
//        maxNumber = maxNumber * 10 + d;
//    }
//}

//Console.WriteLine($"Исходное: {a}");
//Console.WriteLine($"Максимум из цифр: {maxNumber}");
////2Task
//int a = 1459;
//string s = a.ToString();

//bool artandir = true;

//for (int i = 1; i < s.Length; i++)
//{
//    if (s[i] <= s[i - 1]) // indiki rəqəm əvvəlkindən böyük olmalıdır
//    {
//        artandir = false;
//        break;
//    }
//}

//if (artandir)
//    Console.WriteLine("Artan sıradır");
//else
//    Console.WriteLine("Artan sıra deyil");
////3Task
//Console.Write("Ədəd daxil edin: ");
//string s = Console.ReadLine();

//bool hamisiEynidir = true;
//for (int i = 1; i < s.Length; i++)
//{
//    if (s[i] != s[0]) // əgər bir rəqəm birincidən fərqlidirsə
//    {
//        hamisiEynidir = false;
//        break;
//    }
//}

//if (hamisiEynidir)
//    Console.WriteLine("Bütün rəqəmlər eynidir");
//else
//    Console.WriteLine("Fərqli rəqəmlər var");
