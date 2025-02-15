using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Drawing;

public class Menu : MonoBehaviour
{
    [SerializeField] private Image _menu;
    [SerializeField] private KeyCode _machines;

    private const KeyCode _switch1 = KeyCode.Alpha1, _switch2 = KeyCode.Alpha2;
    private const int _menus = 0;
    private const int _android = 1;
    private KeyCode _keyCode;
    private bool _machine;
    private bool _shotgun;

    public void StartAndroid()
    {
        SceneManager.LoadScene(_android);
    }

    public void ExitAndroid()
    {
        SceneManager.LoadScene(_menus);
    }

    public void Machine()
    {
        _machine = true;
        _shotgun = false;

        if(_machine)
        {
            _menu.gameObject.SetActive(true);
        }
    }

    public void Shotgun()
    {
        _shotgun = true;
        _machine = false;
        
        while(_shotgun)
        {
            _menu.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))
                Chat(_switch1);
    }

    private void Chat(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case _switch1:
                
                break;

            case _switch2:

                break;
        }
    }
}
