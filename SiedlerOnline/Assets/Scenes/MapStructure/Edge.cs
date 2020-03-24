using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstrakte Klasse
public abstract class Edge
{
 

    public virtual bool isStrasse() {
        return false;
    }

    public virtual bool isEdge(){
       return true;
    }
}
