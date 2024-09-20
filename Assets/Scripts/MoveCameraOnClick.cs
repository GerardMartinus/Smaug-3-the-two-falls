using UnityEngine;

public class MoveCameraOnClick : MonoBehaviour
{
    public Camera mainCamera; // Referência à câmera principal
    public Vector3 targetPosition; // Posição alvo para a câmera
    public Vector3 originalScale; // Tamanho original do objeto
    public Vector3 hoverScale = new Vector3(1.2f, 1.2f, 1.2f); // Tamanho do objeto ao passar o mouse

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
        originalScale = transform.localScale; // Salva o tamanho original do objeto
    }

    void OnMouseDown()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        mainCamera.transform.position = targetPosition;
    }

    void OnMouseEnter()
    {
        transform.localScale = hoverScale; // Aumenta o tamanho do objeto
    }

    void OnMouseExit()
    {
        transform.localScale = originalScale; // Retorna ao tamanho original
    }
}
