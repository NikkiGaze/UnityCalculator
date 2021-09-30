using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject _calculatorPanel;
    [SerializeField] private GameObject _comparator2Panel;
    [SerializeField] private GameObject _comparator3Panel;
    [SerializeField] private GameObject _equationPanel;

    private GameObject _currentState = null;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = _calculatorPanel;
        _currentState.SetActive(true);
    }

    public void onChangeState(GameObject state)
    {
        _currentState.SetActive(false);
        _currentState = state;
        _currentState.SetActive(true);
    }
}
