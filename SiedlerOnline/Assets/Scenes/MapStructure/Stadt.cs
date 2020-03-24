using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stadt : Building
{
     public Stadt (Player _player){
        this.player = _player;
    }
    public override isEmpty(){
        return false;
    }

    public override isSiedlung(){
        return false;
    }

    public override isStadt(){
        return true;
    }
}
