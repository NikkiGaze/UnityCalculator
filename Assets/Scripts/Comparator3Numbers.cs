using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Comparator3Numbers : MonoBehaviour
{
    [SerializeField] private InputField _inputField1;
    [SerializeField] private InputField _inputField2;
    [SerializeField] private InputField _inputField3;
    [SerializeField] private Text _outputField;
    
    private String _result = "";

    public void onCompareClicked()
    {
        double[] numbers_array = {0, 0, 0};
        bool status = double.TryParse(_inputField1.text, out numbers_array[0]);
        status &= double.TryParse(_inputField2.text, out numbers_array[1]);
        status &= double.TryParse(_inputField3.text, out numbers_array[2]);
        

        if (numbers_array[0] == numbers_array[1] 
         && numbers_array[1] == numbers_array[2])
        {
            _result = "Equal";
        }
        else
        {
            Array.Sort(numbers_array);
            _result = numbers_array[1] + ", " + numbers_array[2];
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
