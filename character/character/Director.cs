using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace character
{
    class Director
    {
        private IBuilder builder;
       
        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void buildMinimalViableCharacter(
            PictureBox pictureBoxHead, Bitmap bitMapHead, 
            PictureBox pictureBoxBody, Bitmap bitMapBody, 
            PictureBox pictureBoxLeftHand, Bitmap bitMapLeftHand,
            PictureBox pictureBoxRightHand, Bitmap bitMapRightHand,
            PictureBox pictureBoxLeftLeg, Bitmap bitMapLeftLeg,
            PictureBox pictureBoxRightLeg, Bitmap bitMapRightLeg
            )
        {
            this.builder.BuildHead(pictureBoxHead, bitMapHead);
            this.builder.BuildBody(pictureBoxBody, bitMapBody);
            this.builder.BuildLeftHand(pictureBoxLeftHand, bitMapLeftHand);
            this.builder.BuildRightHand(pictureBoxRightHand, bitMapRightHand);
            this.builder.BuildLeftLeg(pictureBoxLeftLeg, bitMapLeftLeg);
            this.builder.BuildRightLeg(pictureBoxRightLeg, bitMapRightLeg);
            //ko co face
        }

        public void buildFullFeaturedCharacter(
            PictureBox pictureBoxHead, Bitmap bitMapHead,
            PictureBox pictureBoxBody, Bitmap bitMapBody,
            PictureBox pictureBoxLeftHand, Bitmap bitMapLeftHand,
            PictureBox pictureBoxRightHand, Bitmap bitMapRightHand,
            PictureBox pictureBoxLeftLeg, Bitmap bitMapLeftLeg,
            PictureBox pictureBoxRightLeg, Bitmap bitMapRightLeg,
            PictureBox pictureBoxFace, Bitmap bitMapFace

            )
        {
            this.builder.BuildHead(pictureBoxHead, bitMapHead);
            this.builder.BuildBody(pictureBoxBody, bitMapBody);
            this.builder.BuildLeftHand(pictureBoxLeftHand, bitMapLeftHand);
            this.builder.BuildRightHand(pictureBoxRightHand, bitMapRightHand);
            this.builder.BuildLeftLeg(pictureBoxLeftLeg, bitMapLeftLeg);
            this.builder.BuildRightLeg(pictureBoxRightLeg, bitMapRightLeg);
            this.builder.BuildFace(pictureBoxFace, bitMapFace);

        }

    }
}
