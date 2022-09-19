string Prompt(string message)
{
    Console.Write(message);
    string res = Convert.ToString(Console.ReadLine());
    return res;
}

void PrintStringArray(string[] stringArray)
{
    for (int k = 0; k < stringArray.GetLength(0); k++)
    {

        Console.Write($"{stringArray[k]}\t");
        
    }
}

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



string[] incomingStringArray = new string[9];

incomingStringArray[0] = Prompt("Введите первый элемент массива строк:");
incomingStringArray[1] = Prompt("Введите второй элемент массива строк:");
incomingStringArray[2] = Prompt("Введите третий элемент массива строк:");

incomingStringArray[3] = Convert.ToString("f45");
incomingStringArray[4] = Convert.ToString("Wiedzmin");
incomingStringArray[5] = Convert.ToString("O");

incomingStringArray[6] = GenerateRandomString();
incomingStringArray[7] = GenerateRandomString();
incomingStringArray[8] = GenerateRandomString();


PrintStringArray(incomingStringArray);
Console.WriteLine();

string [] outgoingStringArray= new string[9];
for (int i = 0; i < outgoingStringArray.Length; i++)
{
    outgoingStringArray[i]= String.Empty;
}

int count=0;
for (int l = 0; l < incomingStringArray.Length; l++)
{
    
    if (incomingStringArray[l].Length<=3)
    {

    outgoingStringArray[count] = incomingStringArray[l];
    count++;
    }

}

PrintStringArray(outgoingStringArray);