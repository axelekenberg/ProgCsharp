using System;

namespace PictureShapes
{
    internal class Dice
    {
        /*private Circle dots[0] = new Circle();
        private Circle dots[2] = new Circle();
        private Circle dots[3] = new Circle();
        private Circle dots[4] = new Circle();
        private Circle dots[5] = new Circle();
        private Circle dots[6] = new Circle();
        private Circle dots[1] = new Circle();*/

        Circle[] dots;
        
      



        private static Random numberGenerator;
        private int number = 5;

        public Dice()
        {
            numberGenerator = new Random();
            dots = new Circle[7];
            dots[0] = new Circle();
            dots[1] = new Circle();
            dots[2] = new Circle();
            dots[3] = new Circle();
            dots[4] = new Circle();
            dots[5] = new Circle();
            dots[6] = new Circle();
            DrawImage();
        }

        public void Roll()
        {
            numberGenerator.Next(1, 7);
            number = numberGenerator.Next(1, 7);

            dots[0].MakeInVisible();
            dots[1].MakeInVisible();
            dots[2].MakeInVisible();
            dots[3].MakeInVisible();
            dots[4].MakeInVisible();
            dots[5].MakeInVisible();
            dots[6].MakeInVisible();

            /* Om number är udda
            Visa dots[0], d.v.s.pricken i mitten
       Om number är större eller lika med 2
      Visa dots[1] och 2.
  Om number är större eller lika med 4
      Visa även dot 3 och 4
  Om number är 6
      Visa även dot 5 och 6.*/

            if (number % 2 == 1)
            {
                dots[0].MakeVisible();
            }

            if (number >= 2)
            {
                dots[1].MakeVisible();
                dots[2].MakeVisible();
            }

            if (number >= 4)
            {
                dots[3].MakeVisible();
                dots[4].MakeVisible();
            }

            if (number == 6)
            {
                dots[5].MakeVisible();
                dots[6].MakeVisible();
            }
        }

        public void DrawImage()
        {
            dots[0].MakeVisible();
            dots[0].ChangeColor("red");
            dots[0].ChangeSize(75);
            dots[0].MoveHorizontal(295);
            dots[0].MoveVertical(225);

            // Write your code here

            dots[2].MakeVisible();
            dots[2].ChangeColor("red");
            dots[2].ChangeSize(75);
            dots[2].MoveHorizontal(420);
            dots[2].MoveVertical(400);

            dots[6].MakeVisible();
            dots[6].ChangeColor("red");
            dots[6].ChangeSize(75);
            dots[6].MoveHorizontal(420);
            dots[6].MoveVertical(225);

            dots[4].MakeVisible();
            dots[4].ChangeColor("red");
            dots[4].ChangeSize(75);
            dots[4].MoveHorizontal(420);
            dots[4].MoveVertical(70);

            dots[5].MakeVisible();
            dots[5].ChangeColor("red");
            dots[5].ChangeSize(75);
            dots[5].MoveHorizontal(175);
            dots[5].MoveVertical(225);

            dots[1].MakeVisible();
            dots[1].ChangeColor("red");
            dots[1].ChangeSize(75);
            dots[1].MoveHorizontal(175);
            dots[1].MoveVertical(70);

            dots[3].MakeVisible();
            dots[3].ChangeColor("red");
            dots[3].ChangeSize(75);
            dots[3].MoveHorizontal(175);
            dots[3].MoveVertical(400);
        }
    }
}