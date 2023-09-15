using System;
using System.Diagnostics;

namespace PictureShapes
{
    class Dice
    {
        private static Random numberGenerator = new Random();                  
        int number;
             
        private Square grayBackground;
        private Square whiteBackground;
        private Circle dot0;
        private Circle dot1;
        private Circle dot2;
        private Circle dot3;
        private Circle dot4;
        private Circle dot5;
        private Circle dot6;
        public Dice()
        {
            DrawDice();
        }
        public void Roll()
        {
            grayBackground.MakeVisible();
            whiteBackground.MakeVisible();

            number = numberGenerator.Next(1,7);

            if (!(number % 2 == 0))
            {
                dot0.MakeVisible();
            }
            if (number >= 2)
            {
                dot1.MakeVisible();
                dot2.MakeVisible();
            }
            if (number >= 4)
            {
                dot3.MakeVisible();
                dot4.MakeVisible();
            }
            if (number == 6)
            {
                dot5.MakeVisible();
                dot6.MakeVisible();
            }        
        }
        public void DrawDice()
        {
            grayBackground = new Square();
            grayBackground.ChangeColor("gray");
            grayBackground.ChangeSize(300);
            grayBackground.MoveHorizontal(30);
            grayBackground.MoveVertical(-20);

            whiteBackground = new Square();
            whiteBackground.ChangeColor("white");
            whiteBackground.ChangeSize(250);
            whiteBackground.MoveHorizontal(55);
            whiteBackground.MoveVertical(5);

            dot0 = new Circle();
            dot0.ChangeColor("red");
            dot0.ChangeSize(50);
            dot0.MoveHorizontal(105);
            dot0.MoveVertical(275);

            dot1 = new Circle();
            dot1.ChangeColor("red");
            dot1.ChangeSize(50);
            dot1.MoveHorizontal(25);
            dot1.MoveVertical(195);

            dot2 = new Circle();
            dot2.ChangeColor("red");
            dot2.ChangeSize(50);
            dot2.MoveHorizontal(185);
            dot2.MoveVertical(355);

            dot3 = new Circle();
            dot3.ChangeColor("red");
            dot3.ChangeSize(50);
            dot3.MoveHorizontal(25);
            dot3.MoveVertical(355);

            dot4 = new Circle();
            dot4.ChangeColor("red");
            dot4.ChangeSize(50);
            dot4.MoveHorizontal(185);
            dot4.MoveVertical(195);

            dot5 = new Circle();
            dot5.ChangeColor("red");
            dot5.ChangeSize(50);
            dot5.MoveHorizontal(25);
            dot5.MoveVertical(275);

            dot6 = new Circle();
            dot6.ChangeColor("red");
            dot6.ChangeSize(50);
            dot6.MoveHorizontal(185);
            dot6.MoveVertical(275);
        }
    }
}
