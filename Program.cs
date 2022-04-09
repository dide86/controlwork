using static System.Console;
string[] massiv = { "Hello", "442", "World", "45", "G", "}{e}{", "RFRF", "r2d2", "rok", "ku" };
string[] newMassiv = new String[massiv.Length];
int newIndex = 0;
for (int index = 0; index < massiv.Length; index++)
{
    Write($"{massiv[index]} ");
    if (massiv[index].Length <= 3)
    {
        newMassiv[newIndex] = massiv[index];
        newIndex++;
    }
}
WriteLine();
for (int index = 0; index < newMassiv.Length; index++)
{
    if (newMassiv[index] != null)
        Write($"{newMassiv[index]} ");
}
