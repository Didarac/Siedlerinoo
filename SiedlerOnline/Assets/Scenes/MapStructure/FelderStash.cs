using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FelderStash
{
   /*
   typen der Felder:    Wald    Weide   Acker   Lehm    Gebirge     Wüste
   IntegerTyp:          1       2       3       4       5           0
   Anzahl:              4       4       4       3       3           1
   positionen im Stash: 0-3     4-7     8-11    12-14   15-17       18
   */
   private bool[] felder;
   private System.Random rnd;
   private int t;

public FelderStash(){
    bool[] felder = new bool[19];
    
    for(int i = 0; i<19; i++){
        felder[i] = true;
    }
    rnd = new System.Random();
}

public int getRndFeldFromStash(){
    
    if(!this.isEmpty()){
        t = rnd.Next(0,18);
        if(felder[t]){
            felder[t]=false;
            return getTypePos(t);
        }
        else return getRndFeldFromStash();
    }
    else return 0;
}

private bool isEmpty(){
    foreach (bool b in felder){
        if(b)return false;
    }
    return true;
}

private int getTypePos(int _pos){
   if(_pos<=3)return 1;
   if(_pos>=4 && _pos<=7)return 2;
   if(_pos>=8 && _pos<=11)return 3;
   if(_pos>=12 && _pos<=14)return 4;
   if(_pos>=15 && _pos<=17)return 5;
   else return 0;
}
}
