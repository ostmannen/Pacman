using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace pacman
{
    class SceneLoader
    { 
        private readonly Dictionary<char, Func<Entity>> loaders; 
        private string currentScene = "", nextScene = ""; 

        public SceneLoader()
        { 
            loaders = new Dictionary<char, Func<Entity>>(){
                {'#',() => new Wall()}
            };
        }
        private bool Create(char symbol, out Entity created){
            if (loaders.TryGetValue(symbol, out Func<Entity> loader)){
                created = loader();
                return true; 
            }
            created = null; 
            return false; 
        }
        public void HandleSceneLoad(Scene scene){
            if (nextScene == "")return;
            scene.clear();
            //load scene file
            currentScene = nextScene;
            nextScene = "";
        }
        public void Load(string scene) => nextScene = scene;
        public void Reload() => nextScene = currentScene;
















    }
}