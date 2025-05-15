
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Goat : MonoBehaviour
{
    public TMP_InputField Input1;
    public TextMeshProUGUI TXTResultado;
    public TMP_InputField Input2;
    int Nro1;
    int Nro2;

    void Start()
    {
        TXTResultado.text = string.Empty;
    }
    public void Suma()
    {
        Debug.Log("Sumar");
        Nro1 = int.Parse(Input1.text);
        Nro2 = int.Parse(Input2.text);

        TXTResultado.text = (Nro1 + Nro2).ToString();
    }
}