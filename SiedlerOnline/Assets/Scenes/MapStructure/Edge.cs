﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstrakte Klasse
public class Edge
{
    private Straße strasse;

    public bool isStrasse() {
        return strasse.isStrasse();
    }
}
