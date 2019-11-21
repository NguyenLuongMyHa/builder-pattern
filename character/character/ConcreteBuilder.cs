using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace character
{
    class ConcreteBuilder : IBuilder
    {
        private Character character = new Character();
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.character = new Character();
        }
        public void BuildHead(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Head");
            pictureBox.Image = bitMap;
        }
        public void BuildFace(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Face");
            pictureBox.Image = bitMap;

        }
        public void BuildBody(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Body");
            pictureBox.Image = bitMap;

        }
        public void BuildLeftHand(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Left Hand");
            pictureBox.Image = bitMap;

        }
        public void BuildRightHand(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Right Hand");
            pictureBox.Image = bitMap;

        }
        public void BuildLeftLeg(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Left Leg");
            pictureBox.Image = bitMap;

        }
        public void BuildRightLeg(PictureBox pictureBox, Bitmap bitMap)
        {
            this.character.Add("Right Leg");
            pictureBox.Image = bitMap;

        }
        public Character GetCharacter()
        {
            Character result = this.character;

            this.Reset();

            return result;
        }

    }
}
