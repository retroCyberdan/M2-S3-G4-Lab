using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax = 10;

    List<int> numero = new List<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        int posizioneLista = 0;
        for (int i = 0; i <= numeroMax; i++)
        {
            if (posizioneLista == 0)//primo numero
            {
                numero.Insert(0, i);//inserisce nell'indice '0' della List<T> il contenuto di 'i'
            }
            else if (posizioneLista == 1)//secondo numero
            {
                numero.Add(i);//inserisce il contenuto di 'i' a fine List<T>
            }
            else if (posizioneLista == 2)//terzo numero
            {
                int indiceMetà = numero.Count / 2;//trovo la metà della List<T>
                numero.Insert(indiceMetà, i);//inserisco nell'indice a metà il contenuto di 'i'
            }
            Debug.Log("Contenuto lista: " + string.Join(", ", numero));//la funzione 'Join' permette di mostrare i valori della List<numero> separati dal caratter ','
            posizioneLista = (posizioneLista + 1) % 3;//utilizzo il modulo di 3 in modo tale che ogni tre numeri 'posizioneLista' viene riportata a zero
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
