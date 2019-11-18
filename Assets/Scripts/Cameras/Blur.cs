using UnityEngine;

//behaviour which should lie on the same gameobject as the main camera
public class Blur : MonoBehaviour
{
    //material that's applied when doing postprocessing
    [SerializeField]
    private Material blurMaterial = null;

    //method which is automatically called by unity after the camera is done rendering
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        //draws the pixels from the source texture to the destination texture
        var temporaryTexture = RenderTexture.GetTemporary(source.width, source.height);
        Graphics.Blit(source, temporaryTexture, blurMaterial, 0);
        Graphics.Blit(temporaryTexture, destination, blurMaterial, 1);
        RenderTexture.ReleaseTemporary(temporaryTexture);
    }
}