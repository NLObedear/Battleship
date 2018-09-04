using System;
using SwinGameSDK;
using static SwinGameSDK.SwinGame; // requires mcs version 4+, 
// using SwinGameSDK.SwinGame; // requires mcs version 4+, 

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {

            // Opens a new Graphics Window
            SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

            // Load Resources
            GameResources.LoadResources();

            SwinGame.PlayMusic(GameResources.GameMusic("Background"));

            // Game Loop
            do
            {
                GameController.HandleUserInput();
                GameController.DrawScreen();
            }
            while (!SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting);

            SwinGame.StopMusic();

            // Free Resources and Close Audio, to end the program.
            GameResources.FreeResources();
        }
    }
}
