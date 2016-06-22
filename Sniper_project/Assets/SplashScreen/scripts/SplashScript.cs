using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {

	Image uiImage;
	Image uiImaget;
	Canvas parentCanvas;

	[SerializeField]
	Sprite[] images; // Fotos para recorrer... Sprite objetos graficos en 2D.

	[SerializeField]
	Sprite[] imagesTitle;

	[SerializeField]
	bool clickToProceed;

    [SerializeField]
    float fadeTimeFirst; //variable que se le asignara una cantidad de tiempo que tarda en desaparecer una imagen

    [SerializeField]
    float displayTimeFirst; //variable que se le asignara una cantidad de tiempo no transparentes aparezca la imagen antes de desvanecimiento

    [SerializeField]
    float transparentTimeFirst; //variable que se le asignara una cantidad de tiempo que se mantiene una imagen transparente antes de desaparecer 

    [SerializeField]
	float fadeTime; //variable que se le asignara una cantidad de tiempo que tarda en desaparecer una imagen

	[SerializeField]
	float displayTime; //variable que se le asignara una cantidad de tiempo no transparentes aparezca la imagen antes de desvanecimiento

	[SerializeField]
	float transparentTime; //variable que se le asignara una cantidad de tiempo que se mantiene una imagen transparente antes de desaparecer 

	// Use this for initialization
	void Start () {
		parentCanvas = GetComponent<Canvas>();

		if(parentCanvas.worldCamera != Camera.main)  //world camera es la camara que me muestra todo el canvas
			parentCanvas.worldCamera = Camera.main;

		uiImage = GetComponentInChildren<Image>();
		uiImage.sprite = images[0];
		uiImaget = GetComponentInChildren<Image>();
		uiImaget.sprite = imagesTitle [0];

		StartCoroutine(CycleImages()); //Es una funcion que me retorna 
	}
	
	// Update is called once per frame
	void Update () {}

	IEnumerator CycleImages() {		
		for(int i = 0; i < images.Length; i++)
		{
			uiImage.sprite = images[i];
			uiImage.color = new Color(uiImage.color.r, uiImage.color.g, uiImage.color.b, 0);

			yield return new WaitForSeconds(transparentTimeFirst);

			//Bucle para que aparezca
			for(float alpha = 0; alpha < 1; alpha += Time.deltaTime / fadeTimeFirst)
			{
				uiImage.color = new Color(uiImage.color.r, uiImage.color.g, uiImage.color.b, alpha);

				yield return null; // Espere a que el marco y luego regresar a la ejecución
			}
			yield return new WaitForSeconds(displayTimeFirst);
                
			//Bucle para que desaparezca
			for(float alpha = 1; alpha > 0; alpha -= Time.deltaTime / fadeTimeFirst)
			{
				uiImage.color = new Color(uiImage.color.r, uiImage.color.g, uiImage.color.b, alpha);

				yield return null; // Espere a que el marco y luego regresar a la ejecución
			}
		}
		for (int i = 0; i < imagesTitle.Length; i++) 
		{
			uiImaget.sprite = imagesTitle[i];
			uiImaget.color = new Color (uiImaget.color.r, uiImaget.color.g, uiImaget.color.b, 0);

			yield return new WaitForSeconds(transparentTime);

			//Bucle para que aparezca
			for(float alpha = 0; alpha < 1; alpha += Time.deltaTime / fadeTime)
			{
				uiImaget.color = new Color(uiImaget.color.r, uiImaget.color.g, uiImaget.color.b, alpha);

				yield return null; // Espere a que el marco y luego regresar a la ejecución
			}
			yield return new WaitForSeconds(displayTime);

			//Bucle para que desaparezca
			for(float alpha = 1; alpha > 0; alpha -= Time.deltaTime / fadeTime)
			{
				uiImaget.color = new Color(uiImaget.color.r, uiImaget.color.g, uiImaget.color.b, alpha);

				yield return null; // Espere a que el marco y luego regresar a la ejecución
			}
		}

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}
}
