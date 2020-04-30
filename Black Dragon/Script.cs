using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;


public class permissionscript : MonoBehaviour
{
    GameObject dialog = null;
    void Start()
    {
#if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
#endif
    }
}


// here is my device camera script




public class simplecamera : MonoBehaviour
{
    static WebCamTexture backCam;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        if (backCam == null)
        {
            backCam = new WebCamTexture();
        }
        GetComponent<RawImage>().texture = backCam;
        backCam.Play();
    }
}