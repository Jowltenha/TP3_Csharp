using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_C_.FormasGeo;

internal class Circulo
{
    public double raio;
    public double CalcularArea()
    {
        // Fórmula: π * r²
        return Math.PI * (raio * raio);
    }
}
