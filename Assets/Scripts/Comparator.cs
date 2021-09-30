using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Comparator : MonoBehaviour
{
    [SerializeField] private InputField _inputField1;
    [SerializeField] private InputField _inputField2;
    [SerializeField] private Text _outputField;
    
    private String _result = "";

    public void onCompareClicked()
    {
        double x = 0, y = 0;
        bool status = double.TryParse(_inputField1.text, out x);
        status &= double.TryParse(_inputField2.text, out y);

        if (x == y)
        {
            _result = "Equal";
        }
        else
        {
            _result =  Math.Max(x, y).ToString();
        }
        UpdateResult(status);
    }

    private void UpdateResult(bool success)
    {
        if (success)
        {
            _outputField.text = _result;
        }
        else
        {
            _outputField.text = "Bad input";
        }
    }
}
