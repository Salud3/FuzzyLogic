//Modified by Saul Bello for FuzzyLogic - PRV0722 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static MenuPausa instance;
    public GameObject botonPausa;
    public GameObject menuPausa;

    private void Awake()
    {
        instance = this;
    }
    public void Pausa() //Pausa el juego
   {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
   }

   public void Play() //Reanuda el juego
   {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
   }
   public void Ply() //Inicia el juego
   {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
   }
   public void MainMenu() //Retorna al MainMenu
   {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
   }

   public void Quit()//Cierra el juego
   {
        Application.Quit();
        Debug.Log("Ya se cerro pa");
   }
}
