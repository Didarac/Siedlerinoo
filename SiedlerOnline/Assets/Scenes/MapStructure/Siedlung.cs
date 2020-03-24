using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siedlung : Building
{
    public Siedlung (Player _player){
        this.player = _player;
    }
    public override isEmpty(){
        return false;
    }

    public override isSiedlung(){
        return true;
    }

    public override isStadt(){
        return false;
    }
}
