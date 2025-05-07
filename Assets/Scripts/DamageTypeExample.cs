using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    //Definisco un ENUM esposto
    public enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE,
    }

    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;
    public int baseDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log("Il nemico è resistente a " + resistance);
            Debug.Log("Infliggerai la metà dei danni");
        }

        else if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole a " + weakness);
            Debug.Log("Infliggerai il doppio dei danni");
        }

        Debug.Log(baseDamage + " danni inferti!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
