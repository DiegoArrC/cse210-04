using System.Collections.Generic;
using Raylib_cs;
using Program.Casting;

namespace Program.casting{
    public class VideoService{
        private int cellSize = 15;
        private string caption = "";
        private int width = 1280;
        private int height = 720;
        private int frameRate = 0;
        private bool debug = false;

        public VideoService(int cellSize, string caption, int width, int height, int frameRate, bool debug){
            this.cellSize = cellSize;
            this.caption = caption;
            this.width = width;
            this.height = height;
            this.frameRate = frameRate;
            this.debug = debug;
        }

        public void closeWindow(){
            Raylib.closeWindow();
        }

        public void clearBuffer(){
            Raylib.beginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if(debug){
                DrawGrid();
            }
        }

        public void drawActor(Actor actor){
            int x = actor.getPosition().GetX();
            int y = actor.getPosition().GetY();
            // *Requires adjustment to get the object color from the appropriate class*
            // Casting.Color c = actor.GetColor();

        }

        public void drawActors(List<Actor> actors){
            foreach(Actor actor in actors){
                drawActor(actor);
            }
        }
        public void FlushBuffer(){
            Raylib.EndDrawing();
        }

        public int GetCellSize(){
            return cellSize;
        }

        public int GetHeight(){
            return height;
        }

        public int GetWidth(){
            return width;
        }

        public bool isWindowOpen(){
            return !Raylib.WindowShouldClose();
        }

        public void openWindow(){
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(frameRate);
        }

        private void DrawGrid(){
            for (int x = 0; x < width; x += cellSize)
            {
                Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < height; y += cellSize)
            {
                Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY);
            }
        }

        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }
    }
}