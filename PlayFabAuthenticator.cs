using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using Photon.Pun.UtilityScripts;

public class PlayFabAuthenticator : MonoBehaviour
{
    public InputField LoginUser;
    public InputField LoginPassword;

    public InputField RegisterUser;
    public InputField RegisterPass;
    public InputField RegisterEmail;

    private void Awake()
    {
        
    }

    public void CreateAccount()
    {
        RegisterPlayFabUserRequest request = new RegisterPlayFabUserRequest();
        request.Username = RegisterUser.text;
        request.Email = RegisterEmail.text;
        request.Password = RegisterPass.text;
        PlayFabClientAPI.RegisterPlayFabUser(request, result => { }, error => { });
    }

    public void LoginAccount()
    {
        LoginWithPlayFabRequest request = new LoginWithPlayFabRequest();
        request.Username = LoginUser.text;
        request.Password = LoginPassword.text;
        PlayFabClientAPI.LoginWithPlayFab(request, RequestPhotonToken, OnPlayFabError);
    }

    private void RequestPhotonToken(LoginResult obj)
    {
        LogMessage("PlayFab authenticated. Requesting photon token...");
        _playFabPlayerIdCache = obj.PlayFabId;

        PlayFabClientAPI.GetPhotonAuthenticationToken(new GetPhotonAuthenticationTokenRequest()
        {
            PhotonApplicationId = PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime
        }, AuthenticateWithPhoton, OnPlayFabError); ;
    }

    private void AuthenticateWithPhoton(GetPhotonAuthenticationTokenRequest obj)
    {
        LogMessage("Photon token acquired: " + obj.PhotonCustomAuthenticationToken + " Authentication comeplete.");

        var customAuth = new AuthenticationValues { AuthType = CustomAuthenticationType.Custom };

        customAuth.AddAuthParameter("username", _playFabPlayerIdCache);

        PhotonNetwork.AuthValues = customAuth;

        PhotonNetwork.ConnectUsingSettings();
    }

    private void OnPlayFabError(PlayFabError obj)
    {
        LogMessage(obj.GenerateErrorReport());
    }

    public void LogMessage(string message)
    {
        Debug.Log("PlayFab + Photon Example: " + message);
    }
}
