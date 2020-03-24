using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyEdge : Edge
{


    public override bool isStrasse() {
        return false;
    }

    public override bool isEdge(){
        return true;
    }
}
