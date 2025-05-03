using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemySwitchBehaviour : MonoBehaviour
{
    //Definisco un ENUMERATORE esposto
    public enum STATE
    { 
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED,
    }

    //definisco una variabile di tipo STATE
    public STATE state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Creo uno SWITCH che ad ogni frame mi mostra in console il valore di 'state' scelto nell'inspector
        switch (state)
        {
            case STATE.IDLE:
            {
                Debug.Log("Il nemico è fermo.");
                break;
            }

            case STATE.AGGROED:
            {
                Debug.Log("Il nemico insegue il giocatore.");
                break;
            }

            case STATE.ATTACKING:
            {
                Debug.Log("Il nemico sta attaccando il giocatore.");
                break;
            }

            case STATE.DEFEATED:
            {
                Debug.Log("Il nemico è sconfitto.");
                break;
            }
        }
    }
}
