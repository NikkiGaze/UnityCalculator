using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField _inputField1;
    [SerializeField] private InputField _inputField2;
    [SerializeField] private Text _outputField;
    private double _result;

    public void onSumClicked()
    {
        double x = 0, y = 0;
        bool status = double.TryParse(_inputField1.text, out x);
        status &= double.TryParse(_inputField2.text, out y);

        _result =  x + y;
        UpdateResult(status);
    }

    public void onSubClicked()
    {
        double x = 0, y = 0;
        bool status = double.TryParse(_inputField1.text, out x);
        status &= double.TryParse(_inputField2.text, out y);

        _result =  x - y;
        UpdateResult(status);
    }

    public void onMulClicked()
    {
        double x = 0, y = 0;
        bool status = double.TryParse(_inputField1.text, out x);
        status &= double.TryParse(_inputField2.text, out y);

        _result =  x * y;
        UpdateResult(status);
    }

    public void onDivideClicked()
    {
        double x = 0, y = 0;
        bool status = double.TryParse(_inputField1.text, out x);
        status &= double.TryParse(_inputField2.text, out y);

        _result =  x / y;
        UpdateResult(status);
    }

    private void UpdateResult(bool success)
    {
        if (success)
        {
            _outputField.text = "= " + _result.ToString();
        }
        else
        {
            _outputField.text = "Bad input";
        }
    }
}
