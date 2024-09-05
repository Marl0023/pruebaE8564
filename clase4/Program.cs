int N, a = 0, b = 1, c;
Console.Write("Ingrese el limite de resultados que desea: ");
N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++) {
    Console.WriteLine($"F{i + 1}: {a}");
    c = a + b;
    a = b;
    b = c;
}
Console.ReadKey();