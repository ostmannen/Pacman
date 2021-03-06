using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace pacman
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var window = new RenderWindow(
                new VideoMode(828, 900), "Pacman"))
            {
                window.Closed += (o, e) => window.Close();
                Clock clock = new Clock();
                Scene scene = new Scene();
                scene.loader.Load("maze");
                while (window.IsOpen)
                {
                    window.DispatchEvents();
                    float deltaTime = clock.Restart().AsSeconds();
                    deltaTime = MathF.Min(deltaTime, 0.01f);
                    window.Clear(new Color(223, 246, 245));
                    if (deltaTime > 0.1){
                        deltaTime = 0.1f;
                    }
                    scene.UpdateAll(deltaTime);
                    scene.RenderAll(window);
                    
                    window.Display();

                }
            }
        }
    }
}
