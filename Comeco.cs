using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Comeco : MonoBehaviour
{
    public GameObject initialButton; // O botão que deve ser selecionado inicialmente
    private GameObject currentButton; // O botão atualmente selecionado

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
        // Verifique se o objeto atualmente selecionado é um botão
        if (EventSystem.current.currentSelectedGameObject != null &&
            EventSystem.current.currentSelectedGameObject != currentButton &&
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != null)
        {
            // O foco está em um botão diferente
            currentButton = EventSystem.current.currentSelectedGameObject;
        }
        else if (currentButton != null)
        {
            // O foco não está em um botão; retorne o foco para o botão atual
            EventSystem.current.SetSelectedGameObject(currentButton);


        }

    }
}
