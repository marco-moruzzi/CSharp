// See https://aka.ms/new-console-template for more information
int x = 10;
double y = x;
float x1 = 12000f;
int y1 = (int) x1;
Console.WriteLine(x1);
Console.WriteLine(y1);
int y2 = (int) x1++;
Console.WriteLine(y2);
string s = "12345";
int x3 = Convert.ToInt32(s);
int x4 = x3 + 1;
Console.WriteLine(x4);
Console.Write("Come ti chiami? ");
string nome = Console.ReadLine();
Console.WriteLine(nome);
//int[,] tabella = new int[5,5];
/*int[][] tabella = new int[5][];
for (int i = 0; i < 5; i++) {
    int z = 0;
    tabella[i][i] = z;
    for (int j = 1; j < 5; j++) {
        tabella[i][j] = z + 1;
        Console.Write(tabella[i][j]);
    }
}*/
int[,] arr = new int[5,5];
int counter = 0;
for (int i = 0; i < 5; i++) {
    for (int j = 0; j < 5; j++) {
        ++counter;
        arr[i,j] = (j == 0) ? 0 : counter;
    }
}
for (int i = 0; i < 5; i++) {
    for (int j = 0; j < 5; j++) {
        Console.Write($"{arr[i,j]} ");
    }
    Console.Write("\n");
}