using static System.Console;
string[] massiv = {"Hello", "442", "World", "45", "G"};
for ( int index = 0;  index< massiv.Length; index++) {
if (massiv[index].Length <= 3)
WriteLine(massiv[index]);
}