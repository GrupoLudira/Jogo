using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Comeco : MonoBehaviour
{
    public GameObject initialButton; // O bot�o que deve ser selecionado inicialmente
    private GameObject currentButton; // O bot�o atualmente selecionado

    void Start()
    {

        if (initialButton != null)
        {
            EventSystem.current.SetSelectedGameObject(initialButton);
            currentButton = initialButton;
        }

    }

    void Update()
    {
        // Verifique se o objeto atualmente selecionado � um bot�o
        if (EventSystem.current.currentSelectedGameObject != null &&
            EventSystem.current.currentSelectedGameObject != currentButton &&
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != null)
        {
            // O foco est� em um bot�o diferente
            currentButton = EventSystem.current.currentSelectedGameObject;
        }
        else if (currentButton != null)
        {
            // O foco n�o est� em um bot�o; retorne o foco para o bot�o atual
            EventSystem.current.SetSelectedGameObject(currentButton);


        }

    }
}
