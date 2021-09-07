namespace PictureShapes
{
    class Dice
    {
       private Circle dot = new Circle();
       private Circle dot2 = new Circle();
       private Circle dot3 = new Circle();
       private Circle dot4 = new Circle();
       private Circle dot5 = new Circle();
       private Circle dot6 = new Circle();
       private Circle dot7 = new Circle();
        public Dice()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            
            dot.MakeVisible();
            dot.ChangeColor("red");
            dot.ChangeSize(75);
            dot.MoveHorizontal(295);
            dot.MoveVertical(225);

            // Write your code here
          
            dot2.MakeVisible();
            dot2.ChangeColor("red");
            dot2.ChangeSize(75);
            dot2.MoveHorizontal(420);
            dot2.MoveVertical(400);

            
            dot3.MakeVisible();
            dot3.ChangeColor("red");
            dot3.ChangeSize(75);
            dot3.MoveHorizontal(420);
            dot3.MoveVertical(225);

            
            dot4.MakeVisible();
            dot4.ChangeColor("red");
            dot4.ChangeSize(75);
            dot4.MoveHorizontal(420);
            dot4.MoveVertical(70);

            dot5.MakeVisible();
            dot5.ChangeColor("red");
            dot5.ChangeSize(75);
            dot5.MoveHorizontal(175);
            dot5.MoveVertical(225);

            dot6.MakeVisible();
            dot6.ChangeColor("red");
            dot6.ChangeSize(75);
            dot6.MoveHorizontal(175);
            dot6.MoveVertical(70);

            dot7.MakeVisible();
            dot7.ChangeColor("red");
            dot7.ChangeSize(75);
            dot7.MoveHorizontal(175);
            dot7.MoveVertical(400);
       

        }
    }
}
