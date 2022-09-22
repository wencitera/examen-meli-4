using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenMeLi
{
    static public class Functions
    {
        public static bool IsMutant(string[] dna) {
            /*
             * A T G C G A
               C A G T G C
               T T A T G T
               A G A A G G
               C C C C T A
               T C A C T G
            */

            bool ismutant = false;
            int rango = dna.Length;
            char[,] arregloChar = new char[rango, rango];
            int contSecuencia = 0;
            
            for (int i = 0; i < rango; i++){
                char[] row = dna[i].ToCharArray();
                for (int j = 0; j < rango; j++) {
                    arregloChar[i, j] = row[j];
                }
            }
            
            for(int i = 0; i<rango; i++)
            {
                for (int j = 0; j<rango; j++)
                {
                    char letra = arregloChar[i, j];
                    int cont =0;
                    int auxi = i;
                    int auxj = j;
                    while (auxj+1 < rango && cont < 4)
                    {
                        char segundaLetra = arregloChar[auxi, auxj++];
                        if (letra == segundaLetra)
                        {
                            cont++;
                        }
                    }
                    if (cont >= 4) contSecuencia++;

                    auxi = i;
                    auxj = j;
                    cont = 0;
                    while (auxi+1 < rango && cont < 4) {
                        char segundaLetra = arregloChar[auxi++, auxj];
                        if (letra == segundaLetra)
                        {
                            cont++;
                        }
                    }
                    if (cont >= 4) contSecuencia++;

                    
                    auxi = i;
                    auxj = j;
                    cont = 0;
                    while (auxi+1 < rango && auxj+1 < rango && cont < 4)
                    {
                        char segundaLetra = arregloChar[auxi++, auxj++];
                        if (letra == segundaLetra)
                        {
                            cont++;
                        }

                    }
                    if (cont >= 4) contSecuencia++;
                }
            }

            Console.WriteLine(contSecuencia);
            if (contSecuencia > 1) ismutant = true;
            
            return ismutant;
        }
    }
}
