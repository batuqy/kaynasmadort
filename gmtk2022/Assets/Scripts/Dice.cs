using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Dice : MonoBehaviour
{
    private int _x;
    public int X 
    {
        get 
        {
            return _x;
        }
        set
        {
            _x = value;
            PlayerPrefs.SetInt("x",_x);
        }
    } 
    private int _y;
    public int Y 
    {
        get 
        {
            return _y;
        }
        set
        {
            _y = value;
            PlayerPrefs.SetInt("y",_y);
        }
    }
    [SerializeField] private int _currentRandomNumber;
    [SerializeField] private int _total;
    [SerializeField] private TMP_Text _diceText;
    [SerializeField] private TMP_Text _currentText;
    [SerializeField] private int _buttonCount;
    [SerializeField] private string[] _xDice = new string[3];
    [SerializeField] private string[] _yDice = new string[3];

    private void Update()
    {
        _diceText.text = $"X: {X} | Y: {Y}";
    }

    public void SetRoll()
    {
        _buttonCount += 1;
        switch(_buttonCount)
        {
            case 1:
                X = _total;
                _total = 0;
                break;
            case 2:
                Y = _total;
                _total = 0;
                break;
            case 3:
                GameObject.FindGameObjectWithTag("GameController").GetComponent<Transporting>().Move();
                _total = 0;
                _buttonCount = 0;
                break;
            default:
                _buttonCount = 0;
                _total = 0;
                break;
        }
    }

    public void OnRoll()
    {
        if(X == 0)
        {
            if(EventSystem.current.currentSelectedGameObject.name == _yDice[0] || EventSystem.current.currentSelectedGameObject.name == _yDice[1] || EventSystem.current.currentSelectedGameObject.name == _yDice[2])
            {
                return;
            }
            _currentRandomNumber = Random.Range(1,System.Convert.ToInt32(EventSystem.current.currentSelectedGameObject.name));
            _total = _total + _currentRandomNumber <= 20 ? _total += _currentRandomNumber : X = _total;
            if(X != 0)
            {
                _buttonCount += 1;
                _total = 0;
            }
        }
        else if(Y == 0)
        {
            if(EventSystem.current.currentSelectedGameObject.name == _xDice[0] || EventSystem.current.currentSelectedGameObject.name == _xDice[1] || EventSystem.current.currentSelectedGameObject.name == _xDice[2])
            {
                return;
            }
            _currentRandomNumber = Random.Range(1,System.Convert.ToInt32(EventSystem.current.currentSelectedGameObject.name));
            _total = _total + _currentRandomNumber <= 20 ? _total += _currentRandomNumber : Y = _total;
            if(Y != 0)
            {
                _buttonCount += 1;
                _total = 0;
            }
        }
        _currentText.text = $"X : {System.Convert.ToString(_buttonCount == 0 ? _total : X)} | Y : {System.Convert.ToString(_buttonCount == 1 ? _total : Y)}";
    }
}
