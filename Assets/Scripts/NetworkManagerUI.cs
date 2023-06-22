using SickDev.CommandSystem;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button hostButton, clientButton;
    
    void Start()
    {
        hostButton.onClick.AddListener(StartHost);
        clientButton.onClick.AddListener(StartClient);
    }

    [Command]
    public static void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        Debug.Log("Starting client...");
    }

    [Command]
    public static void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        Debug.Log("Starting host...");
    }
}
