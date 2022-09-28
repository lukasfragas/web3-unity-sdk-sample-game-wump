using MoralisUnity.Samples.Shared;
using MoralisUnity.Samples.TheGame.View;
using UnityEngine;
using UnityEngine.SceneManagement;

#pragma warning disable 1998
namespace MoralisUnity.Samples.TheGame.Controller
{
    /// <summary>
    /// Core Scene Behavior - Using <see cref="Scene03_GameUI"/>
    /// </summary>
    public class Scene03_Game : MonoBehaviour
    {
        //  Properties ------------------------------------
 
		
        //  Fields ----------------------------------------
        [SerializeField]
        private Scene03_GameUI _ui;

        
        //  Unity Methods----------------------------------
        protected async void Start()
        {
            _ui.BackButton.Button.onClick.AddListener(BackButton_OnClicked);
  
            RefreshUIAsync();
        }


        //  General Methods -------------------------------
        private async void RefreshUIAsync()
        {
            bool isAuthenticated = await MyMoralisWrapper.Instance.HasMoralisUserAsync();
            _ui.BackButton.IsInteractable = true;
        }
        
        
        //  Event Handlers --------------------------------

        private async void BackButton_OnClicked()
        {
            SceneManager.LoadSceneAsync("Scene01_Intro", LoadSceneMode.Single);
        }
    }
}
