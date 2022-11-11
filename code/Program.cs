string[] ArrayInput = {"Sun", "Monday", "T",
      "Wednesday", "Thirsday", "F", "Saturday"};
Console.Write("[");
int number = 0;
int count = 0;
for (int index = 0; index < ArrayInput.Length; index++)
{
    if (ArrayInput[index].Length < 4) { count++; }
}
string[] ArrayOutput = new string[count];
for (int index = 0; index < ArrayInput.Length; index++)
{
    if (ArrayInput[index].Length < 4)
    {
        ArrayOutput[number] = ArrayInput[index];
        number++;
    }
}
Console.Write(string.Join(", ", ArrayOutput));
Console.Write("]");