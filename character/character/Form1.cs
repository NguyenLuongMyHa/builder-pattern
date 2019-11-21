using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace character
{
    public partial class Form1 : Form
    {
        Director director;
        ConcreteBuilder builder;
       

        public Form1()
        {
            InitializeComponent();
            director = new Director();
            builder = new ConcreteBuilder();
            director.Builder = builder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ConstraintPictureBox();
            this.GetBuildInfo();
        }
        private void ConstraintPictureBox()
        {
            face.Parent = head;
            face.Location = new Point(
                face.Location.X
                - head.Location.X,
                face.Location.Y
                - head.Location.Y);
            body.Parent = head;
            body.Location = new Point(
                body.Location.X
                - head.Location.X,
                body.Location.Y
                - head.Location.Y);
            left_leg.Parent = head;
            left_leg.Location = new Point(
                left_leg.Location.X
                - head.Location.X,
                left_leg.Location.Y
                - head.Location.Y);
            left_leg.Parent = body;
            left_leg.Location = new Point(
                left_leg.Location.X
                - body.Location.X,
                left_leg.Location.Y
                - body.Location.Y);
            right_leg.Parent = head;
            right_leg.Location = new Point(
                right_leg.Location.X
                - head.Location.X,
                right_leg.Location.Y
                - head.Location.Y);
            right_leg.Parent = body;
            right_leg.Location = new Point(
                right_leg.Location.X
                - body.Location.X,
                right_leg.Location.Y
                - body.Location.Y);
            left_hand.Parent = head;
            left_hand.Location = new Point(
                left_hand.Location.X
                - head.Location.X,
                left_hand.Location.Y
                - head.Location.Y);
            left_hand.Parent = body;
            left_hand.Location = new Point(
                left_hand.Location.X
                - body.Location.X,
                left_hand.Location.Y
                - body.Location.Y);
            right_hand.Parent = head;
            right_hand.Location = new Point(
                right_hand.Location.X
                - head.Location.X,
                right_hand.Location.Y
                - head.Location.Y);
            right_hand.Parent = body;
            right_hand.Location = new Point(
                right_hand.Location.X
                - body.Location.X,
                right_hand.Location.Y
                - body.Location.Y);
        }

        private void GetBuildInfo()
        {
            director.buildMinimalViableCharacter(this.head, character.Properties.Resources.Head,
                this.body, character.Properties.Resources.Body,
                this.left_hand, character.Properties.Resources.Left_Hand,
                this.right_hand, character.Properties.Resources.Right_Hand,
                this.left_leg, character.Properties.Resources.Left_Leg,
                this.right_leg, character.Properties.Resources.Right_Leg);
            this.lbl_basic_char.Text = "Standard basic character: " + builder.GetCharacter().ListParts();

            director.buildFullFeaturedCharacter(this.head, character.Properties.Resources.Head,
                this.body, character.Properties.Resources.Body,
                this.left_hand, character.Properties.Resources.Left_Hand,
                this.right_hand, character.Properties.Resources.Right_Hand,
                this.left_leg, character.Properties.Resources.Left_Leg,
                this.right_leg, character.Properties.Resources.Right_Leg,
                this.face, character.Properties.Resources.Face_01);
            this.lbl_full_char.Text = "Standard full character: " + builder.GetCharacter().ListParts();

            builder.BuildFace(this.face, character.Properties.Resources.Face_01);
            this.lbl_custom_char.Text = "Custom character: " + builder.GetCharacter().ListParts();
        }

        private void buildHead_Click(object sender, EventArgs e)
        {
            builder.BuildHead(this.head, character.Properties.Resources.Head);
        }

        private void buildBody_Click(object sender, EventArgs e)
        {
            builder.BuildBody(this.body, character.Properties.Resources.Body);
        }

        private void buildLeftHand_Click(object sender, EventArgs e)
        {
            builder.BuildLeftHand(this.left_hand, character.Properties.Resources.Left_Hand);
                }

        private void buildRightHand_Click(object sender, EventArgs e)
        {
            builder.BuildRightHand(this.right_hand, character.Properties.Resources.Right_Hand);
            
        }

        private void buildLeftLeg_Click(object sender, EventArgs e)
        {
            builder.BuildLeftLeg(this.left_leg, character.Properties.Resources.Left_Leg);
        }

        private void buildRightLeg_Click(object sender, EventArgs e)
        {
            builder.BuildRightLeg(this.right_leg, character.Properties.Resources.Right_Leg);
        }

        private void buildFace1_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_01);
        }

        private void buildFace3_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_03);
        }

        private void buildFace5_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_05);
        }

        private void buildFace7_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_07);
        }

        private void buildFace2_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_02);
        }

        private void buildFace4_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_04);
        }

        private void buildFace6_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_06);
        }

        private void buildFace8_Click(object sender, EventArgs e)
        {
            builder.BuildFace(this.face, character.Properties.Resources.Face_08);
        }

        private void buildminimal_Click(object sender, EventArgs e)
        {
            director.buildMinimalViableCharacter(
                this.head, character.Properties.Resources.Head, 
                this.body, character.Properties.Resources.Body, 
                this.left_hand, character.Properties.Resources.Left_Hand,
                this.right_hand, character.Properties.Resources.Right_Hand,
                this.left_leg, character.Properties.Resources.Left_Leg,
                this.right_leg, character.Properties.Resources.Right_Leg);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.head.Image = null;
            this.body.Image = null;
            this.face.Image = null;
            this.left_hand.Image = null;
            this.left_leg.Image = null;
            this.right_hand.Image = null;
            this.right_leg.Image = null;

        }

        private void buildfull_Click(object sender, EventArgs e)
        {
            director.buildFullFeaturedCharacter(
                this.head, character.Properties.Resources.Head,
                this.body, character.Properties.Resources.Body,
                this.left_hand, character.Properties.Resources.Left_Hand,
                this.right_hand, character.Properties.Resources.Right_Hand,
                this.left_leg, character.Properties.Resources.Left_Leg,
                this.right_leg, character.Properties.Resources.Right_Leg,
                this.face, character.Properties.Resources.Face_01
                );
        }
    }
}
