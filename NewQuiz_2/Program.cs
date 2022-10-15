//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს
//და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
//კენტი რიცხვების ჯამი
//ლუწი რიცხვების ნამრავლი
//დაითვლის მასივში თითოეული ელემენტის რაოდენობას


//Console.WriteLine("Write massive Length: ");
//int lengtharr = int.Parse(Console.ReadLine());
//int[] arr = new int[lengtharr];
//int multipl = 1;
//int oddsul = 0;
//int allsum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine("Write Elements of massive: ");
//    int element = int.Parse(Console.ReadLine());
//    arr[i] = element;
//}

//foreach (int v in arr)
//{
//    if (arr[v - 1] % 2 == 0)
//    {
//        multipl = multipl * arr[v - 1];

//    }
//    else
//    {
//        oddsul = oddsul + arr[v - 1];
//    }
//    allsum = allsum + arr[v - 1];
//}
//Console.WriteLine($"the sum of massive is : {allsum}");
//Console.WriteLine($"\n the sum each odd  : {oddsul}");
//Console.WriteLine($"\n multiply of even number : {multipl}");



///////////////////////////////////////////////////////////////////////////


//დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს არის
//თუ არა მოცემული სტრინგი პალინდრომი (პალინდრომის მეთოდი
//გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის)


//Console.WriteLine("Checking if the string is revarsable");
//Console.WriteLine("Enter the string: ");
//string result = Console.ReadLine();
//result = CheckIfStringIsRevarsable(result);
//Console.WriteLine(result);
//static string CheckIfStringIsRevarsable(string result)
//{  
//    int length = result.Length;
//    int c = length / 2;
//    int b = result.Length % 2;
//    int i = 0;
//    int j = 1;
//    if (b == 0)
//    {
//        while (c != i)
//        {
//            if (result[i] != result[length - j])
//            {
//                result = "no reversable";
//                break;
//            }
//            j++;
//            i++;
//            if (i == c)
//            {
//                result = "revarsable";
//            }
//        }
//    }
//    else
//    {
//        result = "no reversable";
//    }
//    return result;
//}










//(ბონუსი) დაწერეთ პროგრამა რომელიც მასივში იპოვნის
//ყველაზე ხშირად გამეორებული ელემენტის რაოენობას და
//დაბეჭდავს ამ ელემენტს. (2)

//Console.WriteLine("Enret the arr length");
//int[] arr;

//int size = int.Parse(Console.ReadLine()!);

//arr = new int[size];

//Console.WriteLine($"Enter {size} number:");

//for (int i = 0; i < size; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine()!);
//}
//int mx = arr.Max();

//int[] newArr = new int[mx + 1];

//for (int i = 0; i < arr.Length; i++)
//{
//    newArr[arr[i]]++;

//}


//int biggest = 0;
//for (int i = 0; i < newArr.Length; i++)
//{
//    int a = 0;
    
//    while (a < newArr.Length)
//    {
//        if (a != i || i == newArr.Length - 1)
//        {
//            if (newArr[i] > newArr[a] && i != newArr.Length - 1)
//            {
//                biggest = newArr[i];
//            }

//        }
//        a++;
//    }
//}
//Console.WriteLine("the most frequensable is : " + biggest);

//int counter = 0;
//for (int i = 0; i < arr.Length; i++)
//{ 
//    int a = 0;
//    while (a < arr.Length)
//    {
//        if (a != i || i == arr.Length - 1)
//        {
//            if (arr[i] == arr[a] && i != arr.Length - 1)
//            {
//                counter++;
//            }
           
//        }
//        a++;
        
//    }
//    if ((counter+1) == biggest)
//    {
//        Console.WriteLine("yvelaze xshiri elementiaa" + arr[i]);
//    }
//    counter = 0;
//}