using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feld
{
 private int nummer;
 private int type;

 private bool hasGoetz;

 public Feld (int _nummer, int _type){
     this.nummer = _nummer;
     this.type = _type;
     this.hasGoetz = false;
 }

 public int getNummer(){
     return this.nummer;
 }

 public int getType(){
     return this.type;
 }

 public bool getHasGoetz(){
     return this.hasGoetz;
 }

 public void setHasGoetz(bool _goetzHere){
     this.hasGoetz = _goetzHere;
 }


}
