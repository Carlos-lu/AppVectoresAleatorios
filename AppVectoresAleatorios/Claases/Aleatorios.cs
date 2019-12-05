using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectoresAleatorios.Claases
{
    class Aleatorios
    {
        
        int[] regsistro = new int[20];
        Random aleatorio = new Random();
        private void NumAleatorio()
        {
            for(int n = 0 ; n < 20 ; n++)
            {
               regsistro[n] = aleatorio.Next(1, 100) + 1;
                               
            }            
        }
    }
}
