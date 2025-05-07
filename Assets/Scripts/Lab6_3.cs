using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab6_3 : MonoBehaviour
{
    //IL CODICE SEGUENTE E' QUELLO UFFICIALE AI FINI DELL'ESAME.
    //QUELLO CHE SI TROVA SOTTO E' UN ESEMPIO CON UN MIO DIALOGO.
    //
    //                  BUONA VISIONE XD
    //                    M.I. FOREVER
    //
    //public string dialogo = "(gandalf;right;grigio) Uno stregone non è mai in ritardo, arriva precisamente quando intende farlo";

    //// Start is called before the first frame update
    //void Start()
    //{
    //    //Effettuo un if per determinare se la stringa inizia con '(' e contenga ')'
    //    if (dialogo.StartsWith("(") && dialogo.Contains(")"))
    //    {
    //        //Procedo, dunque, con l'estrapolazione del testo tra le '()'.
    //        //Conoscendo l'indice della '(' (0), provvederò a trovare l'indice della ')' in modo tale da escluderla:
    //        int indiceFinale = dialogo.IndexOf(")");
    //        //Estrapolo quindi la parola che va da indice 1 a indiceFinale (la ')') - 1:
    //        string subStringa = dialogo.Substring(1, indiceFinale - 1);
    //        //Creo, quindi, un array di stringhe che dividerò al ';':
    //        string[] stringheSeparate = subStringa.Split(";");
    //        //Estraggo il testo dopo la ')' facendo partire un'altra Subtring dal 2° carattere dopo 'indiceFinale', ovvero:
    //        string subStringa2 = dialogo.Substring(indiceFinale + 2);
    //        //Mando in Console le parole separate tramite ciclo FOR, in modo tale che se scrivo altre parole, le estrapola comunque:
    //        for (int i = 0; i < stringheSeparate.Length; i++)
    //        {
    //            Debug.Log(stringheSeparate[i]);
    //        }
    //        Debug.Log(subStringa2);
    //    }
    //    else
    //    {
    //        Debug.Log($"Errore. La Stringa non è nel formato corretto. Devi inserire le parole tra (), separandole con un ; (senza spazio).");
    //    }
    //}

    //Dato che sono un grandissimo nerd, ripropongo lo stesso codice ma con un mio esempio di dialogo XD
    public string dialogo = "(guybrush;threepwood;temibile pirata) Tutto quello che ho è questo pollo di gomma con una carrucola in mezzo";

    // Start is called before the first frame update
    void Start()
    {
        //Effettuo un if per determinare se la stringa inizia con '(' e contenga ')'
        if (dialogo.StartsWith("(") && dialogo.Contains(")"))
        {
            //Procedo, dunque, con l'estrapolazione del testo tra le '()'.
            //Conoscendo l'indice della '(' (0), provvederò a trovare l'indice della ')' in modo tale da escluderla:
            int indiceFinale = dialogo.IndexOf(")");
            //Estrapolo quindi la parola che va da indice 1 a indiceFinale (la ')') - 1:
            string subStringa = dialogo.Substring(1, indiceFinale - 1);
            //Creo, quindi, un array di stringhe che dividerò al ';':
            string[] stringheSeparate = subStringa.Split(";");
            //Estraggo il testo dopo la ')' facendo partire un'altra Subtring dal 2° carattere dopo 'indiceFinale', ovvero:
            string subStringa2 = dialogo.Substring(indiceFinale + 2);
            //Mando in Console le parole separate tramite ciclo FOR, in modo tale che se scrivo altre parole, le estrapola comunque:
            for (int i = 0; i < stringheSeparate.Length; i++)
            {
                Debug.Log(stringheSeparate[i]);
            }
            Debug.Log(subStringa2);
        }
        else
        {
            Debug.Log($"Errore. La Stringa non è nel formato corretto. Devi inserire le parole tra (), separandole con un ; (senza spazio).");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
