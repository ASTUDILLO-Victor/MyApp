double temperatura = 41.0;
string diagnostico;

if (temperatura < 36.0)
{
    diagnostico = "Hipotermia";
}
else if (temperatura <= 37.5)
{
    diagnostico = "Normal";
}
else if (temperatura <= 38.5)
{
    diagnostico = "Fiebre leve";
}
else if (temperatura <= 39.9)
{
    diagnostico = "Fiebre alta";
}
else
{
    diagnostico = "Peligroso, busca médico";
}

Console.WriteLine($"Temperatura: {temperatura}°C");
Console.WriteLine($"Diagnóstico: {diagnostico}");