using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.FormasGeo;

internal class TestesFGEO
{
    static void Main()
    {
        Circulo meuCirculo = new Circulo();
        Esfera minhaEsfera = new Esfera();

        // 2. Definindo os valores de Raio
        meuCirculo.raio = 3.0;
        minhaEsfera.raio = 5.0;

        // 3. Chamando os métodos e armazenando/exibindo resultados
        double area = meuCirculo.CalcularArea();
        double volume = minhaEsfera.CalcularVolume();

        // 4. Exibição no Console
        Console.WriteLine("----- Resultados Geométricos -----");
        Console.WriteLine($"Círculo (Raio {meuCirculo.raio}): Área = {area}");
        Console.WriteLine($"Esfera (Raio {minhaEsfera.raio}): Volume = {volume}");
        Console.WriteLine("----------------------------------");
    }
}
