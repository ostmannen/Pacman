using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Collections.Generic;

namespace pacman
{
    public sealed class Wall : Entity
    {
        public Wall() : base("pacman"){}
        public override bool Solid => true;
        public override void Create(Scene scene){
            base.Create(scene);
            sprite.TextureRect = new IntRect(0,0,18,18);
            //fel cordinater
        }
        public override void Update(Scene scene, float deltaTime){

        }
        

    }
}