using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    public class BubbleSort
    {

        public int[] OrdenacaoBubbleSort(int[] array)
        {
            var tamanho = array.Length;
            var comparacoes = 0;
            var trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                        trocas++;
                    }
                }
            }
            return array;
        }
    }
    
}
