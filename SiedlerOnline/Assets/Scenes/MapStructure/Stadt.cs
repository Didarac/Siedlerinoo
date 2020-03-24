using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stadt : Building
{
    private Player player;
     public Stadt (Player _player){
        this.player = _player;
    }
    public override bool isEmpty(){
        return false;
    }

    public override bool isSiedlung(){
        return false;
    }

    public override bool isStadt(){
        return true;
    }


}
