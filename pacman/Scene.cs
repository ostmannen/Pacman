using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace pacman
{
    class Scene
    { 
        private List<Entity> entities; 
        public readonly SceneLoader loader;
        public readonly AssetmManager assets; 

        public void spawn(Entity entity){

        }  
        public void UpdateAll(float deltaTime){
            loader.HandleSceneLoad(this);
        }
        public void RenderAll(RenderTarget target){

        }
        //public bool FindByType<T>(out T found){

        //}
        public void clear(){
            for (int i = entities.Count -1; i >= 0; i--)
            {
                Entity entity= entities[i];
                entities.RemoveAt(i);
                entity.Destroy(this);
            }
        }
        public IEnumerable<Entity> FindIntersects(FloatRect bounds){
            int lastEntity = entities.Count -1;
            for (int i = lastEntity; i >= 0; i--){
                Entity entity = entities[i];
                if (entity.dead) continue;
                if (entity.Bounds.Intersects(bounds)){
                    yield return entity;
                }
            }
        }
    
















    }
}