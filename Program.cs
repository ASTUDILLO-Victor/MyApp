// Cartas del jugador y la máquina (valores numéricos)
// Caso 1 — jugador gana
// int[] cartasJugador = { 10, 11 };   // 21
// int[] cartasMaquina = { 9, 8 };     // 17

// Caso 2 — jugador se pasa
int[] cartasJugador = { 10, 8, 6 }; // 24 → pierde
int[] cartasMaquina = { 9, 8 };     // 17

// // Caso 3 — empate
// int[] cartasJugador = { 9, 8 };     // 17
// int[] cartasMaquina = { 10, 7 };    // 17

// // Caso 4 — ambos se pasan
// int[] cartasJugador = { 10, 8, 5 }; // 23
// int[] cartasMaquina = { 9, 8, 7 };  // 24

// 1. Calcular sumas con un ciclo for
// 2. Mostrar las cartas y sumas
// 3. Determinar ganador con if/else

int sumaJugador = 0;
int sumaMaquina = 0;

for (int i = 0; i < cartasJugador.Length; i++)
{
    sumaJugador += cartasJugador[i];
}
for (int i = 0; i < cartasMaquina.Length; i++)
{
    sumaMaquina += cartasMaquina[i];
}

string result1 = string.Join(", ", cartasJugador);
string result2 = string.Join(", ", cartasMaquina);

Console.WriteLine($"Cartas del jugador: {result1} (total: {sumaJugador})");
Console.WriteLine($"Cartas de la máquina: {result2} (total: {sumaMaquina})");


int distancia1 = Math.Abs(21 - sumaJugador);
int distancia2 = Math.Abs(21 - sumaMaquina);
if (sumaJugador <= 21 && sumaMaquina <= 21)
{
    if (distancia1 < distancia2)
    {
        Console.WriteLine($"El jugador gana.");
    }
    else if (distancia2 < distancia1)
    {
        Console.WriteLine($"La máquina gana.");
    }
    else
    {
        Console.WriteLine("empate.");
    }

} else if (sumaJugador > 21 && sumaMaquina > 21)
{
    Console.WriteLine("Ambos se pasan. Empate.");
}
else if (sumaJugador > 21)
{
    Console.WriteLine("El jugador se pasa. La máquina gana.");
}
else
{
    Console.WriteLine("La máquina se pasa. El jugador gana.");
}