using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace pacman
{
    class Entity
    { 
        private string texturename; 
        protected Sprite sprite;

        public bool dead; 

        protected Entity(string texturename){

        }
        public virtual void Update(Scene scene, float deltaTime){
            foreach (Entity found in scene.FindIntersects(Bounds)){
                CollideWith(scene, found);
            }
        }
        public Vector2f Position(){

        }
        public readonly FloatRect Bounds(){
             
        }
        public readonly bool solid(){
            
        }
        public void Create(Scene scene){

        }
        public void render(RenderTarget target){

        }
        protected virtual void CollideWith(Scene scene, Entity entity){

        }
        public virtual void Destroy(Scene scene){

        }















    }
}