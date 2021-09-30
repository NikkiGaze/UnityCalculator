using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EquationSolver : MonoBehaviour
{
    [SerializeField] private InputField _inputField1;
    [SerializeField] private InputField _inputField2;
    [SerializeField] private InputField _inputField3;
    [SerializeField] private Text _outputField;

    private String _result = "";

    public void onSolveClicked()
    {
        double a = 0, b = 0, c = 0;
        bool status = double.TryParse(_inputField1.text, out a);
        status &= double.TryParse(_inputField2.text, out b);
        status &= double.TryParse(_inputField3.text, out c);
        
        double D = b * b - 4 * a * c;
        if (D < 0)
        {
            _result = "No roots";
        }
        else
        {
            double sqrtD = Math.Sqrt(D);
            double _root1 = (-b + sqrtD) / 2 * a;
            double _root2 = (-b - sqrtD) / 2 * a;
            if (_root1 == _root2)
            {
                _result = _root1.ToString();
            }
            else
            {
                _result = _root1.ToString() + ", " + _root2.ToString();
            }
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
