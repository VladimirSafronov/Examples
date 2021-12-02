//====Метод, который ничего не принимает, и ничего не возвращает

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//====Метод, который что-то принимает, но ничего не возвращает

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Some text");

// void Method21(int count, string msg)  // выводит текст нужное кол-во раз
// {
//     for(int i = 0; i < count; i++)
//     {
//         Console.WriteLine(msg);
//     }
// }
// Method21(5, "Hello, world!");   // также можно указать имя переменной (count: 5)

//=====Ничего не принимает, но возвращает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//=====Что-то принимает, и что-то возвращает

// string Method4(int count, string text)
// {
//     string result = String.Empty;  //пустая строка
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string mes = Method4(5, "Hi!");
// Console.WriteLine(mes);

//=========Использование цикла в цикле (Таблица умножения)

// for(int x = 2; x < 10; x++)
// {
//     for(int y = 1; y <= 10; y++)
//     {
//         Console.WriteLine($"{x} x {y} = {x * y}");
//     }
//     Console.WriteLine();
// }

//====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”,
// a большие “С” заменить маленькими “с” (их правда нет в тексте)
// Ясна ли задача?

//Обращение к определенному символу текста:
// string t = qwerty;
//            012345
// t[1] // w;

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string ChangeSymbol(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     for(int i = 0; i < text.Length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}"; 
//     }
//     return result;
// }
// string newText = ChangeSymbol(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = ChangeSymbol(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = ChangeSymbol(text, 'C', 'c');
// Console.WriteLine(newText);

//=====Сортировка выбором=====

// int[] arr = { 12, 21, 32, 4, 61, 7, 1 };

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int [] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for(int y = i + 1; y < array.Length; y++)
//         {
//             if(array[y] < array[minPosition]) minPosition = y;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
    
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
