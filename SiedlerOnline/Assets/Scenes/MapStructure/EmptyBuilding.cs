using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBuilding : Building
{
     
    public override bool isEmpty(){
        return true;
    }

    public override bool isSiedlung(){
        return false;
    }

    public override bool isStadt(){
        return false;
    }
}
