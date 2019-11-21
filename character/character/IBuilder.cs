using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character
{
    interface IBuilder
    {
        void BuildHead(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);
        void BuildFace(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);
        void BuildBody(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);
        void BuildLeftHand(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);
        void BuildRightHand(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);
        void BuildLeftLeg(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);
        void BuildRightLeg(System.Windows.Forms.PictureBox pictureBox, Bitmap bitMap);

    }
}
