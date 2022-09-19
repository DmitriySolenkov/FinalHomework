# Контрольное задание по знакомству с IT

## **Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**
***

### Инициализация входящего массива

    string[] incomingStringArray = new string[9];

Данной строкой инициализируем массив, с которым будут производиться дальнейшие действия. *9* в данном случае не считается магическим числом, потому что в самой задаче не указана обязательная длина массива, поэтому я самостоятельно выбрал наиболее подходящую под мое решение длину.
***
### Заполнение входящего массива
Метод для быстрого запроса пользователю и получения от него необходимой информации:

    string Prompt(string message)
    {
        Console.Write(message);
        string res = Convert.ToString(Console.ReadLine());
        return res;
    }
Метод генерации строки со случайным заполнением цифрами и латинскими строчными символами:

    string GenerateRandomString()
    {
        string randomString = String.Empty;
        int length = new Random().Next(1, 6);
        for (int i = 0; i < length; i++)
        {
            int symbol = new Random().Next(0, 2);
            if (symbol == 0)
            {
                randomString += new Random().Next(0, 10);
            }
            else
            {
                randomString += (char)new Random().Next(0x0061, 0x007A);
            }
        }
        return randomString;
    }


Следующим действием запрашиваем пользователя ввести три произвольные строки для первых трех элементов массива с одновременным их присваиванием:

    incomingStringArray[0] = Prompt("Введите первый элемент массива строк:");
    incomingStringArray[1] = Prompt("Введите второй элемент массива строк:");
    incomingStringArray[2] = Prompt("Введите третий элемент массива строк:");

Затем заполняем три элемента массива фиксированными значениями:

    incomingStringArray[3] = Convert.ToString("f45");
    incomingStringArray[4] = Convert.ToString("Wiedzmin");
    incomingStringArray[5] = Convert.ToString("O");

Последние три элемента заполняем случайно сгенерированными строками длиной от 1 до 5 символов:

    incomingStringArray[6] = GenerateRandomString();
    incomingStringArray[7] = GenerateRandomString();
    incomingStringArray[8] = GenerateRandomString();
***
### Инициализация исходящего массива

Создаем исходящий массив с длиной, равной длине входящего массива и заполняем все строки пустым значением:

    string[] outgoingStringArray = new string[incomingStringArray.Length];
    for (int i = 0; i < outgoingStringArray.Length; i++)
    {
        outgoingStringArray[i] = String.Empty;
    }
***
### Заполнение исходящего массива

Создаем счетчик для последовательной записи в исходящий массив:

    int count = 0;

А далее последовательно переписываем значения входящего массива, длина которых меньше четырех символов в исходящий массив.

    for (int l = 0; l < incomingStringArray.Length; l++)
    {

        if (incomingStringArray[l].Length <= 3)
        {

            outgoingStringArray[count] = incomingStringArray[l];
            count++;
        }

    }
***
### Вывод обоих массивов на экран
 
С помощью метода ***PrintStringArray*** выводим оба массива на экран для визуального сравнения и подтверждения правльно выполненой задачи:

    void PrintStringArray(string[] stringArray)
    {
        for (int k = 0; k < stringArray.GetLength(0); k++)
        {

            Console.Write($"{stringArray[k]}\t");

        }

    PrintStringArray(incomingStringArray);
    Console.WriteLine();
    PrintStringArray(outgoingStringArray);
***
### Картинка
Заканчиваем задачу вставкой картинки
![Тут должна быть картинка :(](%D0%9A%D0%B0%D1%80%D1%82%D0%B8%D0%BD%D0%BA%D0%B0.jpg)