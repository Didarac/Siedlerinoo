using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBuilding : Building
{
     
    public override isEmpty(){
        return true;
    }

    public override isSiedlung(){
        return false;
    }

    public override isStadt(){
        return false;
    }
}
