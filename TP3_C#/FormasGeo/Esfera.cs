using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.FormasGeo;
// --- Exercício 10 Definindo Classes de Formas Geométricas ---
internal class Esfera
{
    public double raio;
    public double CalcularVolume()
    {
        // Fórmula: (4/3) * π * r³
        return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
    }
}
