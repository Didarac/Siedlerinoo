using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siedlung : Building
{
    private Player player;
    public Siedlung (Player _player){
        this.player = _player;
    }
    public override bool isEmpty(){
        return false;
    }

    public override bool isSiedlung(){
        return true;
    }

    public override bool isStadt(){
        return false;
    }


}
