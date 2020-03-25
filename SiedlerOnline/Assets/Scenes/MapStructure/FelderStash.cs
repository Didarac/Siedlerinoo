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
   private int[] nummern;

public FelderStash(){
    bool[] felder = new bool[19];
    
    for(int i = 0; i<19; i++){
        felder[i] = true;
    }
    rnd = new System.Random();
    nummern = new int[19];
    nummern[0] = 5;
    nummern[1] = 2;
    nummern[2] = 6;
    nummern[3] = 3;
    nummern[4] = 5;
    nummern[5] = 8;
    nummern[6] = 10;
    nummern[7] = 9;
    nummern[8] = 12;
    nummern[9] = 11;
    nummern[10] = 4;
    nummern[11] = 8;
    nummern[12] = 10;
    nummern[13] = 9;
    nummern[14] = 4;
    nummern[15] = 5;
    nummern[16] = 6;
    nummern[17] = 3;
    nummern[18] = 11;
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
