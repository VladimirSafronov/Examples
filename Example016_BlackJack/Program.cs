int[] deckOfCards = 
{2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6,
7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 
11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14};    //далее 12-2 превратиться в вальта, 13-3 в даму и 14-4 в короля

int[] Mixing(int[] array)
{
    int j; int temporary;
    for(int i = 0; i < array.Length; i++)
    {
        temporary = array[i];
        j = new Random().Next(i, array.Length);
        array[i] = array[j]; 
        array[j] = temporary;
    }
    return array;
}

int[] mixedCards = Mixing(deckOfCards);
Console.WriteLine(String.Join(',', mixedCards));
