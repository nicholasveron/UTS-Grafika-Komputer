﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Mathematics;

namespace UTS
{
    class Nicholas
    {

        public static Animator DaunPohonAnimator = new Animator();
        public static Animator AwanAnimator1 = new Animator();
        public static Animator AwanAnimator2 = new Animator();
        public static Animator AwanAnimator3 = new Animator();
		public static Animator TitleAnimator = new Animator();
        public static Animator CerobongAnimator = new Animator();
        public static Animator CerobongAnimator1 = new Animator();
        public static Animator CerobongAnimator2 = new Animator();


		public static void Objects(ref Object scene)
        {
			scene.addChild(new Object("Ground-Grass"));
            scene.lastChild().createTerrain(0.3f, 30, 3);
			scene.lastChild().scale(10.5f);
			scene.lastChild().translate(0, 0, 0f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(38 / 255f, 139 / 255f, 7 / 255f);

            scene.addChild(new Object("Ground-Block"));
            scene.lastChild().createCube();
            scene.lastChild().scale(10f, 10f, 0.1f);
            scene.lastChild().translate(-0.5f, 0.5f, -0.3f);
            scene.lastChild().centerOrigin();
            scene.lastChild().setColor(38 / 255f, 139 / 255f, 7 / 255f);

			scene.addChild(new Object("Awan.001"));
			scene.lastChild().createBall();
			scene.lastChild().scale(3.15784f, 2.13896f, 1.62565f);
			scene.lastChild().rotateQ(0.56880f, 0.00480f, 0.02659f, -0.82203f);
			scene.lastChild().translate(-2.25481f, 10.43956f, 14.40840f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.002"));
			scene.lastChild().createBall();
			scene.lastChild().scale(2.55371f, 1.72975f, 1.31464f);
			scene.lastChild().rotateQ(0.56880f, 0.00480f, 0.02659f, -0.82203f);
			scene.lastChild().translate(-1.46634f, 12.63813f, 15.27380f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.003"));
			scene.lastChild().createBall();
			scene.lastChild().scale(2.55371f, 1.72975f, 1.31464f);
			scene.lastChild().rotateQ(0.56880f, 0.00480f, 0.02659f, -0.82203f);
			scene.lastChild().translate(-1.03806f, 13.32085f, 13.84521f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.006"));
			scene.lastChild().createBall();
			scene.lastChild().scale(3.61521f, 1.55598f, 1.18257f);
			scene.lastChild().rotateQ(0.54804f, -0.09988f, 0.14508f, -0.81769f);
			scene.lastChild().translate(-6.64837f, -9.44066f, 10.48932f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.005"));
			scene.lastChild().createBall();
			scene.lastChild().scale(2.48456f, 1.25830f, 0.95633f);
			scene.lastChild().rotateQ(0.55681f, -0.10935f, 0.16040f, -0.80764f);
			scene.lastChild().translate(-5.89587f, -8.60867f, 11.53904f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.004"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.85769f, 1.25830f, 0.95633f);
			scene.lastChild().rotateQ(0.54804f, -0.09988f, 0.14508f, -0.81769f);
			scene.lastChild().translate(-5.49703f, -7.52211f, 10.41051f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.007"));
			scene.lastChild().createBall();
			scene.lastChild().scale(3.75195f, 0.89723f, 0.83137f);
			scene.lastChild().rotateQ(0.44517f, -0.30810f, 0.47398f, -0.69443f);
			scene.lastChild().translate(9.81151f, 5.28227f, 15.78071f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan.008"));
			scene.lastChild().createBall();
			scene.lastChild().scale(1.65952f, 0.89723f, 0.68191f);
			scene.lastChild().rotateQ(0.44517f, -0.30810f, 0.47398f, -0.69443f);
			scene.lastChild().translate(10.64449f, 6.27054f, 16.46253f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("Awan"));
			scene.lastChild().createBall();
			scene.lastChild().scale(2.08260f, 1.21977f, 1.00844f);
			scene.lastChild().rotateQ(0.44517f, -0.30810f, 0.47398f, -0.69443f);
			scene.lastChild().translate(9.17030f, 4.15857f, 16.60576f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 1.00000f, 1.00000f);

			scene.addChild(new Object("PelangiBlue"));
			scene.lastChild().createTorus(0.5f, 0.25f);
			scene.lastChild().scale(9.99868f, 9.99868f, 9.99867f);
			scene.lastChild().rotateQ(0.49029f, -0.40157f, 0.59533f, -0.49390f);
			scene.lastChild().translate(-3.88453f, 1.42460f, 12.49434f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 0.00000f, 1.00000f);

			scene.addChild(new Object("PelangiGreen"));
			scene.lastChild().createTorus(0.5f, 0.25f);
			scene.lastChild().scale(10.41482f, 9.99867f, 9.99867f);
			scene.lastChild().rotateQ(0.49029f, -0.40157f, 0.59533f, -0.49390f);
			scene.lastChild().translate(-3.94912f, 1.22230f, 13.20215f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.00000f, 1.00000f, 0.00000f);

			scene.addChild(new Object("PelangiRed"));
			scene.lastChild().createTorus(0.5f, 0.25f);
			scene.lastChild().scale(10.74774f, 9.99868f, 9.99868f);
			scene.lastChild().rotateQ(0.49029f, -0.40156f, 0.59533f, -0.49390f);
			scene.lastChild().translate(-3.92326f, 0.99355f, 13.79966f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.00000f, 0.00000f, 0.00000f);

			scene.addChild(new Object("Pohon"));

			{ // Children of 'Pohon'

				scene.lastChild().addChild(new Object("BatangPohon"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(-0.38589f, -0.38589f, -4.63048f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.08736f, -0.08638f, 3.67304f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.08353f, 0.08353f, 1.62639f);
				scene.lastChild().lastChild().rotateQ(0.94119f, 0.16041f, 0.23142f, -0.18674f);
				scene.lastChild().lastChild().translate(0.83084f, -0.87340f, 6.45610f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon.001"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.08353f, 0.08353f, 0.74566f);
				scene.lastChild().lastChild().rotateQ(0.91689f, -0.28363f, 0.27890f, -0.03282f);
				scene.lastChild().lastChild().translate(0.50098f, 0.57703f, 6.72170f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon.002"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.08353f, 0.08353f, 0.86714f);
				scene.lastChild().lastChild().rotateQ(0.34812f, -0.25946f, -0.15753f, 0.88695f);
				scene.lastChild().lastChild().translate(-0.76372f, 0.05393f, 6.34341f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("CabangPohon.003"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.20504f, 0.20504f, 1.15081f);
				scene.lastChild().lastChild().rotateQ(0.86250f, 0.47713f, 0.13920f, -0.09520f);
				scene.lastChild().lastChild().translate(0.18700f, -1.28986f, 3.76490f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10946f, 0.07036f, 0.03071f);

				scene.lastChild().addChild(new Object("DaunPohon.001"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(4.01596f, 3.75622f, 1.51850f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, -0.00000f);
				scene.lastChild().lastChild().translate(-0.25781f, -0.13554f, 8.13629f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.57758f, 0.52712f, 0.14996f);

				scene.lastChild().addChild(new Object("DaunPohon.002"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(4.01596f, 3.87770f, 1.71590f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, -0.00000f);
				scene.lastChild().lastChild().translate(-0.13458f, -3.78924f, 5.38591f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.57758f, 0.52712f, 0.14996f);

			} // Children of 'Pohon'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(0.26934f, 0.00000f, 0.00000f, 0.96304f);
			scene.lastChild().translate(7.59545f, 1.50973f, 0.80470f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("Rumah"));

			{ // Children of 'Rumah'

				scene.lastChild().addChild(new Object("BalokRumah"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(3.36399f, 7.25913f, 3.16244f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(0.05826f, 4.11625f, 1.76482f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("BalokRumah.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(3.36399f, 7.25913f, 3.16244f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-3.87715f, 0.23899f, 1.76482f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("BalokRumah.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(1.57134f, 0.95165f, 1.39192f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(1.01391f, -0.07085f, -0.02783f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("BalokRumah.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(2.21315f, 1.30576f, 1.90094f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-5.02798f, -8.19311f, 0.48120f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.19918f, 0.81886f, 2.91899f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.68465f, 4.28251f, 8.29046f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.19918f, 0.81886f, 2.91899f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-4.02071f, 4.90219f, 8.29046f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.19918f, 0.81886f, 2.91899f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-3.40102f, 4.28251f, 8.29046f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("CerobongAsap.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.19918f, 0.81886f, 2.91899f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-4.02071f, 3.66283f, 8.29046f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("Door"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.65887f, 1.23429f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.60393f, -0.13545f, -0.12361f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("Door.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.65887f, 1.23429f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-5.60218f, -9.50259f, -0.14312f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("Matt"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.26604f, 0.65887f, 0.06820f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.72281f, -0.14135f, -1.33834f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10247f, 0.09255f, 0.10184f);

				scene.lastChild().addChild(new Object("Matt.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.26604f, 0.65887f, 0.06820f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-5.60809f, -9.62148f, -1.35785f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.10247f, 0.09255f, 0.10184f);

				scene.lastChild().addChild(new Object("Window"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02259f, 0.25996f, 0.61543f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.66929f, -0.42195f, 0.38299f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02259f, 0.25996f, 0.61543f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.66929f, 0.16178f, 0.38299f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02259f, 0.25996f, 0.61543f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-5.30495f, -9.56794f, 0.36348f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.02259f, 0.25996f, 0.61543f);
				scene.lastChild().lastChild().rotateQ(0.70712f, 0.00000f, 0.00000f, -0.70710f);
				scene.lastChild().lastChild().translate(-5.88869f, -9.56796f, 0.36348f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.004"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -5.66206f, 2.12508f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.005"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -4.93084f, 2.12508f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.006"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -4.93084f, 2.86455f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.007"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -5.66206f, 2.86455f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.008"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -5.66206f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.009"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -4.93084f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.010"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -4.93084f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.011"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -5.66206f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.012"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.98385f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.013"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.25263f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.014"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.25263f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.015"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.98385f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.016"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.98385f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.017"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.25263f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.018"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.25263f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.019"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.42538f, -2.98385f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.020"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.20825f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.021"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.93947f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.022"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.93947f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.023"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.20825f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.024"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.20825f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.025"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.93947f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.026"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.93947f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.027"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 2.20825f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.028"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 5.29311f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.029"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 6.02434f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.030"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 6.02434f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.031"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 5.29311f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.032"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 5.29311f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.033"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 6.02434f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.034"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 6.02434f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.035"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.37641f, 5.29311f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.036"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.23243f, -7.34481f, 5.40091f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.037"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-3.50121f, -7.34481f, 5.40091f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.038"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-3.50121f, -7.34481f, 6.14039f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.039"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-4.23243f, -7.34481f, 6.14039f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.040"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.42171f, 3.73086f, 6.14039f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.041"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.42171f, 4.46208f, 6.14039f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.042"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.42171f, 4.46208f, 5.40091f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.043"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.42171f, 3.73086f, 5.40091f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.044"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03874f, 0.40779f, 0.40779f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(1.04287f, -1.09259f, 0.42762f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.045"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03874f, 0.40779f, 0.40779f);
				scene.lastChild().lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
				scene.lastChild().lastChild().translate(-2.76507f, -8.27021f, 1.26222f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.046"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(4.65335f, 0.70725f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.047"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(5.38457f, 0.70725f, 0.65546f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.048"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(5.38457f, 0.70725f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.049"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(4.65335f, 0.70725f, -0.08402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.050"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(4.65335f, 0.70725f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.051"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(5.38457f, 0.70725f, 2.12698f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.052"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(5.38457f, 0.70725f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("Window.053"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.03126f, 0.32903f, 0.32903f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(4.65335f, 0.70725f, 2.86646f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.09463f, 0.09463f, 0.09463f);

				scene.lastChild().addChild(new Object("WindowFrame"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.48495f, -5.29588f, 2.48603f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.001"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.48495f, -5.29588f, 0.27694f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.002"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.48495f, -2.61767f, 0.27694f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.003"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.48495f, -2.61767f, 2.48794f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.004"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.31685f, 2.57442f, 2.48794f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.005"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.31685f, 2.57442f, 0.27694f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.006"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.31685f, 5.65929f, 0.27694f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.007"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.31685f, 5.65929f, 2.48794f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.008"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(-3.86625f, -7.28524f, 5.76186f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.009"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.36214f, 4.09704f, 5.76186f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.010"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.04332f, 0.50188f, 0.50188f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(1.04287f, -1.04113f, 0.42740f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.011"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.04332f, 0.50188f, 0.50188f);
				scene.lastChild().lastChild().rotateQ(0.00000f, 0.00000f, 0.00000f, 1.00000f);
				scene.lastChild().lastChild().translate(-2.81653f, -8.27021f, 1.26200f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.012"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(5.01953f, 0.76682f, 0.27694f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("WindowFrame.013"));
				scene.lastChild().lastChild().createCube();
				scene.lastChild().lastChild().scale(0.06685f, 0.77460f, 0.77460f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(5.01953f, 0.76682f, 2.48794f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.20155f, 0.34238f, 0.07519f);

				scene.lastChild().addChild(new Object("ConnectorAtap"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 3.14697f);
				scene.lastChild().lastChild().rotateQ(0.38302f, -0.84944f, -0.32289f, 0.16582f);
				scene.lastChild().lastChild().translate(-6.29828f, 6.49252f, 6.00881f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.001"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 7.77245f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-0.05881f, -0.07935f, 4.04674f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.002"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 7.77245f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, -0.00000f, 0.70711f, 0.70711f);
				scene.lastChild().lastChild().translate(-7.95975f, 0.30894f, 4.04674f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.003"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 7.77245f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-0.05881f, 8.16562f, 4.04674f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.004"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 7.77245f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, -0.00000f, 0.70711f, 0.70711f);
				scene.lastChild().lastChild().translate(0.15567f, 0.30894f, 4.04674f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.005"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 3.72239f);
				scene.lastChild().lastChild().rotateQ(0.49725f, -0.40926f, 0.09676f, 0.75887f);
				scene.lastChild().lastChild().translate(-1.53517f, 1.72204f, 6.26649f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.006"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 3.32402f);
				scene.lastChild().lastChild().rotateQ(0.93969f, 0.34202f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.74527f, 5.99942f, 6.60423f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.007"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 3.32402f);
				scene.lastChild().lastChild().rotateQ(0.33935f, 0.94066f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.74527f, 2.01187f, 6.57747f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.008"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 3.32402f);
				scene.lastChild().lastChild().rotateQ(0.23995f, 0.66515f, -0.66515f, -0.23995f);
				scene.lastChild().lastChild().translate(-5.87857f, -7.35922f, 6.44771f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.009"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 3.32402f);
				scene.lastChild().lastChild().rotateQ(0.66446f, 0.24184f, -0.24184f, -0.66446f);
				scene.lastChild().lastChild().translate(-1.89103f, -7.35922f, 6.47447f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.010"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 5.49291f);
				scene.lastChild().lastChild().rotateQ(0.50000f, 0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(2.23837f, 4.06423f, 8.99883f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.011"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.33627f, 0.33627f, 5.49291f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, -0.00000f, 0.70711f, 0.70711f);
				scene.lastChild().lastChild().translate(-3.89840f, -1.98412f, 8.91748f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.012"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.12850f, 0.12850f, 2.64240f);
				scene.lastChild().lastChild().rotateQ(0.33492f, 0.62276f, 0.33492f, 0.62276f);
				scene.lastChild().lastChild().translate(-5.03213f, -9.75461f, 2.18828f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.013"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.12850f, 0.12850f, 1.69075f);
				scene.lastChild().lastChild().rotateQ(0.47365f, 0.88071f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-7.68769f, -8.36022f, 3.11572f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.014"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.12850f, 0.12850f, 1.69075f);
				scene.lastChild().lastChild().rotateQ(0.47365f, 0.88071f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.40679f, -8.36022f, 3.11572f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.016"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.12850f, 0.12850f, 1.18172f);
				scene.lastChild().lastChild().rotateQ(0.50032f, 0.86584f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.75697f, -0.19103f, 1.81752f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.017"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.12850f, 0.12850f, 1.64648f);
				scene.lastChild().lastChild().rotateQ(0.33492f, 0.62276f, 0.33492f, 0.62276f);
				scene.lastChild().lastChild().translate(1.14231f, -1.19571f, 1.24842f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("ConnectorAtap.018"));
				scene.lastChild().lastChild().createCylinder();
				scene.lastChild().lastChild().scale(0.12850f, 0.12850f, 1.18172f);
				scene.lastChild().lastChild().rotateQ(0.50032f, 0.86584f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-0.49490f, -0.19103f, 1.81752f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.68596f, 0.68087f, 0.27177f);

				scene.lastChild().addChild(new Object("AtapBesar.001"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(5.86485f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, 0.29884f, 0.64086f);
				scene.lastChild().lastChild().translate(-1.78929f, -1.79416f, 6.46371f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar.002"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(5.86485f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
				scene.lastChild().lastChild().translate(-5.97215f, -1.79415f, 6.46370f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar.003"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(5.86485f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.90631f, 0.42262f, -0.00046f, -0.00099f);
				scene.lastChild().lastChild().translate(2.15739f, 1.99041f, 6.53913f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(5.86485f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.00099f, 0.00046f, 0.42262f, 0.90631f);
				scene.lastChild().lastChild().translate(2.16656f, 6.17327f, 6.53913f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapBesar.004"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(5.86485f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
				scene.lastChild().lastChild().translate(-5.97215f, -1.79415f, 6.46370f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapKecil"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(1.65986f, 1.12871f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.25207f, -0.96771f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(1.14654f, -0.21326f, 1.81647f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapKecil.001"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(2.63365f, 1.61560f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.96126f, 0.27564f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-5.07005f, -8.39447f, 3.07858f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("CerobongTutup"));
				scene.lastChild().lastChild().createPlane();
				scene.lastChild().lastChild().scale(0.49917f, 0.49917f, 0.49917f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.04204f, 4.24327f, 9.33096f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("AtapConnect"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(1.99183f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.64086f, 0.29884f, -0.29884f, -0.64086f);
				scene.lastChild().lastChild().translate(-5.97215f, 5.92615f, 6.46370f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("AtapConnect.001"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(2.30168f, 3.25333f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.41978f, 0.90762f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-5.96460f, 6.17327f, 6.53913f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.99110f, 0.88792f, 0.47932f);

				scene.lastChild().addChild(new Object("DindingSegitiga"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(0.48721f, 0.88893f, 0.42001f);
				scene.lastChild().lastChild().rotateQ(-0.00000f, 0.70711f, -0.00000f, -0.70711f);
				scene.lastChild().lastChild().translate(2.58281f, -0.13457f, 1.82870f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("DindingSegitiga.001"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(0.82755f, 1.30801f, 0.61801f);
				scene.lastChild().lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-7.23317f, -8.29730f, 3.12435f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("DindingSegitiga.002"));
				scene.lastChild().lastChild().createTriangle(true);
				scene.lastChild().lastChild().scale(0.82755f, 1.30801f, 0.61801f);
				scene.lastChild().lastChild().rotateQ(0.00000f, -0.70711f, 0.00000f, 0.70711f);
				scene.lastChild().lastChild().translate(-2.80688f, -8.29730f, 3.12435f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("ConnectBallAtap"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-7.92200f, 8.13951f, 4.03910f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.001"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-7.92200f, -7.41893f, 4.03910f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.002"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.41805f, 0.41598f, 0.41598f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(0.33305f, -0.26038f, 4.19402f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.003"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(7.76923f, 8.13951f, 4.08336f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.004"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(0.19342f, -7.41893f, 4.03910f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.005"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(7.72496f, -0.10546f, 4.08336f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.006"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(7.74902f, 3.99566f, 9.03342f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.007"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.39319f, 0.39124f, 0.39124f);
				scene.lastChild().lastChild().rotateQ(0.69962f, -0.00064f, -0.01859f, -0.71427f);
				scene.lastChild().lastChild().translate(-3.89478f, -7.36297f, 8.90366f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.008"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.21396f, 0.21290f, 0.21290f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-2.44310f, -9.74018f, 2.22541f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.009"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.21396f, 0.21290f, 0.21290f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-7.67199f, -9.73909f, 2.18825f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.010"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.21396f, 0.21290f, 0.21290f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(-0.43795f, -1.16645f, 1.27226f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("ConnectBallAtap.011"));
				scene.lastChild().lastChild().createBall();
				scene.lastChild().lastChild().scale(0.21396f, 0.21290f, 0.21290f);
				scene.lastChild().lastChild().rotateQ(0.99977f, 0.01269f, -0.01360f, -0.01036f);
				scene.lastChild().lastChild().translate(2.70745f, -1.15782f, 1.27219f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.59258f, 0.53168f, 0.28980f);

				scene.lastChild().addChild(new Object("DindingSegitiga"));
				scene.lastChild().lastChild().createTriangle();
				scene.lastChild().lastChild().scale(2.05823f, 3.34186f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.50000f, -0.50000f, 0.50000f, 0.50000f);
				scene.lastChild().lastChild().translate(-3.87035f, -7.05327f, 6.84535f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

				scene.lastChild().addChild(new Object("DindingSegitiga.001"));
				scene.lastChild().lastChild().createTriangle();
				scene.lastChild().lastChild().scale(2.05823f, 3.43038f, 2.21315f);
				scene.lastChild().lastChild().rotateQ(0.70711f, 0.00000f, 0.70711f, 0.00000f);
				scene.lastChild().lastChild().translate(7.29051f, 4.10736f, 6.94041f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.88248f, 0.91310f, 0.61404f);

			} // Children of 'Rumah'

			scene.lastChild().scale(1.00000f, 1.00000f, 1.00000f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(-2.76970f, 2.49096f, 1.29371f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("BigTitleBezier"));

			{ // Children of 'BigTitleBezier'

				scene.lastChild().addChild(new Object("A11"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.65446f, 1.24755f),
												new Vector2(2.32387f, 1.35971f),
												new Vector2(1.89131f, 1.63322f),
												new Vector2(1.42736f, 1.97357f),
												new Vector2(1.00260f, 2.28627f),
												new Vector2(0.68760f, 2.47684f),
												new Vector2(-0.06637f, 2.65671f),
												new Vector2(-0.79835f, 2.59108f),
												new Vector2(-1.44838f, 2.29784f),
												new Vector2(-1.95649f, 1.79486f),
												new Vector2(-2.26269f, 1.10004f),
												new Vector2(-2.28334f, -0.62248f),
												new Vector2(-1.58633f, -1.84843f),
												new Vector2(-0.40203f, -2.46388f),
												new Vector2(1.03919f, -2.35494f),
												new Vector2(2.50694f, -1.40771f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70144f, 0.70144f, 0.70144f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.69234f, 6.37132f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("A12"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.40860f, 2.87021f),
												new Vector2(2.42394f, 2.11769f),
												new Vector2(2.46053f, 0.88604f),
												new Vector2(2.50419f, -0.50531f),
												new Vector2(2.54078f, -1.73696f),
												new Vector2(2.55612f, -2.48948f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70144f, 0.70144f, 0.70144f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.69234f, 6.37132f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("E"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.95637f, -0.12242f),
												new Vector2(-0.38079f, -0.11648f),
												new Vector2(0.14825f, -0.06773f),
												new Vector2(0.56706f, 0.07025f),
												new Vector2(0.81196f, 0.34387f),
												new Vector2(0.81927f, 0.79954f),
												new Vector2(0.56794f, 1.30603f),
												new Vector2(0.18288f, 1.49751f),
												new Vector2(-0.26091f, 1.40842f),
												new Vector2(-0.68842f, 1.07323f),
												new Vector2(-1.02466f, 0.52637f),
												new Vector2(-1.05915f, -0.16946f),
												new Vector2(-0.70672f, -0.82251f),
												new Vector2(-0.12192f, -1.30520f),
												new Vector2(0.54070f, -1.48998f),
												new Vector2(1.12659f, -1.24927f),
									}, 1f, 0.5f);
				scene.lastChild().lastChild().scale(0.59508f, 0.59508f, 0.59508f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.99913f, -0.29960f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("E2"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.32169f, -0.59933f),
												new Vector2(-1.52505f, -0.35699f),
												new Vector2(-0.51509f, -0.18530f),
												new Vector2(0.49810f, 0.01273f),
												new Vector2(1.30448f, 0.33411f),
												new Vector2(1.69398f, 0.87581f),
												new Vector2(1.57246f, 2.23944f),
												new Vector2(0.85439f, 3.00021f),
												new Vector2(-0.18399f, 3.13243f),
												new Vector2(-1.26646f, 2.61042f),
												new Vector2(-2.11681f, 1.40850f),
												new Vector2(-2.29663f, -0.34315f),
												new Vector2(-1.61959f, -1.97490f),
												new Vector2(-0.35682f, -3.11190f),
												new Vector2(1.22053f, -3.37931f),
												new Vector2(2.84131f, -2.40228f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.69194f, 0.69194f, 0.69194f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(1.75116f, -6.75662f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("E3"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.52019f, -0.21101f),
												new Vector2(-1.69892f, -0.07354f),
												new Vector2(-0.67526f, -0.03367f),
												new Vector2(0.35503f, 0.03190f),
												new Vector2(1.19615f, 0.24648f),
												new Vector2(1.65232f, 0.73336f),
												new Vector2(1.70786f, 2.10127f),
												new Vector2(1.09402f, 2.94838f),
												new Vector2(0.08140f, 3.21355f),
												new Vector2(-1.05941f, 2.83565f),
												new Vector2(-2.05781f, 1.75358f),
												new Vector2(-2.46227f, 0.03980f),
												new Vector2(-2.00155f, -1.66570f),
												new Vector2(-0.89613f, -2.95622f),
												new Vector2(0.63349f, -3.42503f),
												new Vector2(2.36685f, -2.66542f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.69399f, 0.69399f, 0.69399f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(8.06150f, -5.73220f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("H11"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.43223f, 4.90198f),
												new Vector2(-2.37037f, 3.38730f),
												new Vector2(-2.22287f, 1.87598f),
												new Vector2(-2.04681f, 0.36579f),
												new Vector2(-1.89931f, -1.14553f),
												new Vector2(-1.83745f, -2.66021f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70472f, 0.70472f, 0.70472f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-6.03432f, 6.30052f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("H12"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.06403f, 1.07840f),
												new Vector2(-1.50596f, 1.64366f),
												new Vector2(-0.62336f, 2.01251f),
												new Vector2(0.37671f, 2.15538f),
												new Vector2(1.28723f, 2.04269f),
												new Vector2(1.90115f, 1.64486f),
												new Vector2(2.09039f, 0.97808f),
												new Vector2(2.06413f, 0.01586f),
												new Vector2(1.92200f, -1.05906f),
												new Vector2(1.76366f, -2.06392f),
												new Vector2(1.68873f, -2.81598f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70472f, 0.70472f, 0.70472f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-6.03432f, 6.30052f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("H21"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.10838f, 1.88655f),
												new Vector2(-0.08708f, 1.28053f),
												new Vector2(-0.03627f, 0.23816f),
												new Vector2(0.02438f, -0.94967f),
												new Vector2(0.07519f, -1.99205f),
												new Vector2(0.09650f, -2.59807f),
									}, 1f, 0.5f);
				scene.lastChild().lastChild().scale(0.59171f, 0.59171f, 0.59171f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-1.06240f, 0.56702f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("H22"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.10269f, -0.42974f),
												new Vector2(0.24960f, -0.26970f),
												new Vector2(0.65865f, -0.12470f),
												new Vector2(1.08278f, -0.03240f),
												new Vector2(1.48031f, -0.03047f),
												new Vector2(1.80953f, -0.15657f),
												new Vector2(1.92318f, -0.45098f),
												new Vector2(1.96085f, -0.99952f),
												new Vector2(1.94852f, -1.64670f),
												new Vector2(1.91219f, -2.23706f),
												new Vector2(1.87782f, -2.61514f),
									}, 1f, 0.5f);
				scene.lastChild().lastChild().scale(0.59171f, 0.59171f, 0.59171f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-1.06240f, 0.56702f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("H31"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.30930f, 5.51662f),
												new Vector2(-2.28154f, 3.87836f),
												new Vector2(-2.21533f, 2.07234f),
												new Vector2(-2.13631f, 0.21041f),
												new Vector2(-2.07010f, -1.59561f),
												new Vector2(-2.04233f, -3.23387f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.68928f, 0.68928f, 0.68928f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.77042f, -6.88950f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("H32"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.06403f, 1.07840f),
												new Vector2(-1.50596f, 1.64366f),
												new Vector2(-0.62336f, 2.01251f),
												new Vector2(0.37671f, 2.15538f),
												new Vector2(1.28723f, 2.04269f),
												new Vector2(1.90115f, 1.64486f),
												new Vector2(2.10744f, 0.96530f),
												new Vector2(2.12183f, -0.02741f),
												new Vector2(2.02821f, -1.13872f),
												new Vector2(1.91052f, -2.17407f),
												new Vector2(1.85264f, -2.93891f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.68928f, 0.68928f, 0.68928f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.79867f, -7.11544f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("N11"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.40860f, 2.87021f),
												new Vector2(2.42394f, 2.11769f),
												new Vector2(2.46053f, 0.88604f),
												new Vector2(2.50419f, -0.50531f),
												new Vector2(2.54078f, -1.73696f),
												new Vector2(2.55612f, -2.48948f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.71048f, 0.71048f, 0.71048f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(9.88740f, 5.28955f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("N12"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.21192f, 0.65749f),
												new Vector2(3.00832f, 1.34333f),
												new Vector2(3.90608f, 1.90388f),
												new Vector2(4.77442f, 2.20018f),
												new Vector2(5.48257f, 2.09328f),
												new Vector2(5.89977f, 1.44424f),
												new Vector2(5.95670f, 0.83255f),
												new Vector2(5.97152f, -0.13617f),
												new Vector2(5.96116f, -1.22520f),
												new Vector2(5.94253f, -2.19782f),
												new Vector2(5.93256f, -2.81729f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.71048f, 0.71048f, 0.71048f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(9.88740f, 5.28955f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("P"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-1.42021f, -5.68038f),
												new Vector2(-1.59656f, -3.14004f),
												new Vector2(-1.90337f, -0.45851f),
												new Vector2(-2.00727f, 1.78876f),
												new Vector2(-1.57489f, 3.02633f),
												new Vector2(-0.27288f, 2.67877f),
												new Vector2(0.98855f, 1.38297f),
												new Vector2(1.47874f, 0.01732f),
												new Vector2(1.21938f, -1.21264f),
												new Vector2(0.23217f, -2.10135f),
												new Vector2(-1.46119f, -2.44326f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70011f, 0.70011f, 0.70011f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(14.49477f, -5.24049f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("S"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.44204f, 4.85477f),
												new Vector2(1.22876f, 5.38391f),
												new Vector2(-0.17330f, 5.10692f),
												new Vector2(-1.43092f, 4.25067f),
												new Vector2(-2.21092f, 3.04201f),
												new Vector2(-2.18008f, 1.70780f),
												new Vector2(-1.80636f, 1.29572f),
												new Vector2(-1.14063f, 0.89521f),
												new Vector2(-0.35199f, 0.51880f),
												new Vector2(0.39049f, 0.17903f),
												new Vector2(0.91773f, -0.11155f),
												new Vector2(1.41496f, -0.62992f),
												new Vector2(1.78168f, -1.32612f),
												new Vector2(1.96862f, -2.09260f),
												new Vector2(1.92652f, -2.82176f),
												new Vector2(1.60612f, -3.40604f),
												new Vector2(1.14889f, -3.75684f),
												new Vector2(0.62478f, -4.01106f),
												new Vector2(0.06376f, -4.21281f),
												new Vector2(-0.50421f, -4.40619f),
												new Vector2(-1.04913f, -4.63532f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70122f, 0.70122f, 0.70122f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-13.25663f, 5.02599f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("S2"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.22011f, 3.63237f),
												new Vector2(2.20598f, 3.71550f),
												new Vector2(2.16788f, 3.80368f),
												new Vector2(2.11227f, 3.88716f),
												new Vector2(2.04557f, 3.95623f),
												new Vector2(1.97425f, 4.00115f),
												new Vector2(0.68401f, 4.18222f),
												new Vector2(-0.43877f, 3.75689f),
												new Vector2(-1.22375f, 2.90911f),
												new Vector2(-1.50060f, 1.82285f),
												new Vector2(-1.09896f, 0.68208f),
												new Vector2(-0.52874f, 0.12574f),
												new Vector2(0.27112f, -0.47585f),
												new Vector2(1.07679f, -1.10660f),
												new Vector2(1.66447f, -1.75039f),
												new Vector2(1.81035f, -2.39114f),
												new Vector2(1.45963f, -2.99216f),
												new Vector2(0.81561f, -3.45894f),
												new Vector2(0.03143f, -3.73175f),
												new Vector2(-0.73976f, -3.75086f),
												new Vector2(-1.34482f, -3.45652f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.69905f, 0.69905f, 0.69905f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-11.47760f, -5.82531f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("T11"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.00594f, 1.10117f),
												new Vector2(0.00471f, 0.57683f),
												new Vector2(0.03011f, -0.27077f),
												new Vector2(0.06044f, -1.22612f),
												new Vector2(0.08584f, -2.07372f),
												new Vector2(0.09650f, -2.59807f),
									}, 1f, 0.5f);
				scene.lastChild().lastChild().scale(0.59591f, 0.59591f, 0.59591f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.91117f, 0.33592f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("T12"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.81978f, -0.01998f),
												new Vector2(-0.54737f, -0.01311f),
												new Vector2(-0.22259f, 0.00335f),
												new Vector2(0.11965f, 0.02320f),
												new Vector2(0.44443f, 0.04026f),
												new Vector2(0.71683f, 0.04831f),
									}, 1f, 0.5f);
				scene.lastChild().lastChild().scale(0.59591f, 0.59591f, 0.59591f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.91117f, 0.33592f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("U11"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-1.37760f, 3.11607f),
												new Vector2(-1.38717f, 2.37385f),
												new Vector2(-1.39253f, 1.35561f),
												new Vector2(-1.35870f, 0.25610f),
												new Vector2(-1.25065f, -0.72993f),
												new Vector2(-1.03340f, -1.40771f),
												new Vector2(-0.45704f, -1.93877f),
												new Vector2(0.24928f, -2.01799f),
												new Vector2(1.02145f, -1.75302f),
												new Vector2(1.79538f, -1.25147f),
												new Vector2(2.50694f, -0.62096f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70665f, 0.70665f, 0.70665f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.21575f, 5.43706f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

				scene.lastChild().addChild(new Object("U12"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.40860f, 2.87021f),
												new Vector2(2.42394f, 2.11769f),
												new Vector2(2.46053f, 0.88604f),
												new Vector2(2.50419f, -0.50531f),
												new Vector2(2.54078f, -1.73696f),
												new Vector2(2.55612f, -2.48948f),
									}, 1f, 1f);
				scene.lastChild().lastChild().scale(0.70665f, 0.70665f, 0.70665f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.21575f, 5.43706f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.91310f, 0.86316f, 0.63760f);

			} // Children of 'BigTitleBezier'

			scene.lastChild().scale(0.33513f, 0.33513f, 0.33513f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, 0.27060f);
			scene.lastChild().translate(-1.45131f, 1.36933f, 14.68988f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("BigTitleBezier.001"));

			{ // Children of 'BigTitleBezier.001'

				scene.lastChild().addChild(new Object("A11B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.65446f, 1.24755f),
												new Vector2(2.32387f, 1.35971f),
												new Vector2(1.89131f, 1.63322f),
												new Vector2(1.42736f, 1.97357f),
												new Vector2(1.00260f, 2.28627f),
												new Vector2(0.68760f, 2.47684f),
												new Vector2(-0.06637f, 2.65671f),
												new Vector2(-0.79835f, 2.59108f),
												new Vector2(-1.44838f, 2.29784f),
												new Vector2(-1.95649f, 1.79486f),
												new Vector2(-2.26269f, 1.10004f),
												new Vector2(-2.28334f, -0.62248f),
												new Vector2(-1.58633f, -1.84843f),
												new Vector2(-0.40203f, -2.46388f),
												new Vector2(1.03919f, -2.35494f),
												new Vector2(2.50694f, -1.40771f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70144f, 0.70144f, 0.70144f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.69234f, 6.37132f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("A12B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.40860f, 2.87021f),
												new Vector2(2.42394f, 2.11769f),
												new Vector2(2.46053f, 0.88604f),
												new Vector2(2.50419f, -0.50531f),
												new Vector2(2.54078f, -1.73696f),
												new Vector2(2.55612f, -2.48948f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70144f, 0.70144f, 0.70144f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(0.69234f, 6.37132f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("E2B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.32169f, -0.59933f),
												new Vector2(-1.52505f, -0.35699f),
												new Vector2(-0.51509f, -0.18530f),
												new Vector2(0.49810f, 0.01273f),
												new Vector2(1.30448f, 0.33411f),
												new Vector2(1.69398f, 0.87581f),
												new Vector2(1.57246f, 2.23944f),
												new Vector2(0.85439f, 3.00021f),
												new Vector2(-0.18399f, 3.13243f),
												new Vector2(-1.26646f, 2.61042f),
												new Vector2(-2.11681f, 1.40850f),
												new Vector2(-2.29663f, -0.34315f),
												new Vector2(-1.61959f, -1.97490f),
												new Vector2(-0.35682f, -3.11190f),
												new Vector2(1.22053f, -3.37931f),
												new Vector2(2.84131f, -2.40228f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.69194f, 0.69194f, 0.69194f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(1.75116f, -6.75662f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("E3B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.52019f, -0.21101f),
												new Vector2(-1.69892f, -0.07354f),
												new Vector2(-0.67526f, -0.03367f),
												new Vector2(0.35503f, 0.03190f),
												new Vector2(1.19615f, 0.24648f),
												new Vector2(1.65232f, 0.73336f),
												new Vector2(1.70786f, 2.10127f),
												new Vector2(1.09402f, 2.94838f),
												new Vector2(0.08140f, 3.21355f),
												new Vector2(-1.05941f, 2.83565f),
												new Vector2(-2.05781f, 1.75358f),
												new Vector2(-2.46227f, 0.03980f),
												new Vector2(-2.00155f, -1.66570f),
												new Vector2(-0.89613f, -2.95622f),
												new Vector2(0.63349f, -3.42503f),
												new Vector2(2.36685f, -2.66542f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.69399f, 0.69399f, 0.69399f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(8.06150f, -5.73220f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("EB"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.95637f, -0.12242f),
												new Vector2(-0.38079f, -0.11648f),
												new Vector2(0.14825f, -0.06773f),
												new Vector2(0.56706f, 0.07025f),
												new Vector2(0.81196f, 0.34387f),
												new Vector2(0.81927f, 0.79954f),
												new Vector2(0.56794f, 1.30603f),
												new Vector2(0.18288f, 1.49751f),
												new Vector2(-0.26091f, 1.40842f),
												new Vector2(-0.68842f, 1.07323f),
												new Vector2(-1.02466f, 0.52637f),
												new Vector2(-1.05915f, -0.16946f),
												new Vector2(-0.70672f, -0.82251f),
												new Vector2(-0.12192f, -1.30520f),
												new Vector2(0.54070f, -1.48998f),
												new Vector2(1.12659f, -1.24927f),
									}, 1f, 0.6f);
				scene.lastChild().lastChild().scale(0.59508f, 0.59508f, 0.59508f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(2.99913f, -0.29960f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("H11B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.43223f, 4.90198f),
												new Vector2(-2.37037f, 3.38730f),
												new Vector2(-2.22287f, 1.87598f),
												new Vector2(-2.04681f, 0.36579f),
												new Vector2(-1.89931f, -1.14553f),
												new Vector2(-1.83745f, -2.66021f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70472f, 0.70472f, 0.70472f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-6.03432f, 6.30052f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("H12B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.06403f, 1.07840f),
												new Vector2(-1.50596f, 1.64366f),
												new Vector2(-0.62336f, 2.01251f),
												new Vector2(0.37671f, 2.15538f),
												new Vector2(1.28723f, 2.04269f),
												new Vector2(1.90115f, 1.64486f),
												new Vector2(2.09039f, 0.97808f),
												new Vector2(2.06413f, 0.01586f),
												new Vector2(1.92200f, -1.05906f),
												new Vector2(1.76366f, -2.06392f),
												new Vector2(1.68873f, -2.81598f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70472f, 0.70472f, 0.70472f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-6.03432f, 6.30052f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("H21B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.10838f, 1.88655f),
												new Vector2(-0.08708f, 1.28053f),
												new Vector2(-0.03627f, 0.23816f),
												new Vector2(0.02438f, -0.94967f),
												new Vector2(0.07519f, -1.99205f),
												new Vector2(0.09650f, -2.59807f),
									}, 1f, 0.6f);
				scene.lastChild().lastChild().scale(0.59171f, 0.59171f, 0.59171f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-1.06240f, 0.56702f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("H22B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.10269f, -0.42974f),
												new Vector2(0.24960f, -0.26970f),
												new Vector2(0.65865f, -0.12470f),
												new Vector2(1.08278f, -0.03240f),
												new Vector2(1.48031f, -0.03047f),
												new Vector2(1.80953f, -0.15657f),
												new Vector2(1.92318f, -0.45098f),
												new Vector2(1.96085f, -0.99952f),
												new Vector2(1.94852f, -1.64670f),
												new Vector2(1.91219f, -2.23706f),
												new Vector2(1.87782f, -2.61514f),
									}, 1f, 0.6f);
				scene.lastChild().lastChild().scale(0.59171f, 0.59171f, 0.59171f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-1.06240f, 0.56702f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("H31B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.30930f, 5.51662f),
												new Vector2(-2.28154f, 3.87836f),
												new Vector2(-2.21533f, 2.07234f),
												new Vector2(-2.13631f, 0.21041f),
												new Vector2(-2.07010f, -1.59561f),
												new Vector2(-2.04233f, -3.23387f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.68928f, 0.68928f, 0.68928f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.77042f, -6.88950f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("H32B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-2.06403f, 1.07840f),
												new Vector2(-1.50596f, 1.64366f),
												new Vector2(-0.62336f, 2.01251f),
												new Vector2(0.37671f, 2.15538f),
												new Vector2(1.28723f, 2.04269f),
												new Vector2(1.90115f, 1.64486f),
												new Vector2(2.10744f, 0.96530f),
												new Vector2(2.12183f, -0.02741f),
												new Vector2(2.02821f, -1.13872f),
												new Vector2(1.91052f, -2.17407f),
												new Vector2(1.85264f, -2.93891f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.68928f, 0.68928f, 0.68928f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-4.79867f, -7.11544f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("N11B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.40860f, 2.87021f),
												new Vector2(2.42394f, 2.11769f),
												new Vector2(2.46053f, 0.88604f),
												new Vector2(2.50419f, -0.50531f),
												new Vector2(2.54078f, -1.73696f),
												new Vector2(2.55612f, -2.48948f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.71048f, 0.71048f, 0.71048f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(9.88740f, 5.28955f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("N12B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.21192f, 0.65749f),
												new Vector2(3.00832f, 1.34333f),
												new Vector2(3.90608f, 1.90388f),
												new Vector2(4.77442f, 2.20018f),
												new Vector2(5.48257f, 2.09328f),
												new Vector2(5.89977f, 1.44424f),
												new Vector2(5.95670f, 0.83255f),
												new Vector2(5.97152f, -0.13617f),
												new Vector2(5.96116f, -1.22520f),
												new Vector2(5.94253f, -2.19782f),
												new Vector2(5.93256f, -2.81729f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.71048f, 0.71048f, 0.71048f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(9.88740f, 5.28955f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("PB"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-1.42021f, -5.68038f),
												new Vector2(-1.59656f, -3.14004f),
												new Vector2(-1.90337f, -0.45851f),
												new Vector2(-2.00727f, 1.78876f),
												new Vector2(-1.57489f, 3.02633f),
												new Vector2(-0.27288f, 2.67877f),
												new Vector2(0.98855f, 1.38297f),
												new Vector2(1.47874f, 0.01732f),
												new Vector2(1.21938f, -1.21264f),
												new Vector2(0.23217f, -2.10135f),
												new Vector2(-1.46119f, -2.44326f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70011f, 0.70011f, 0.70011f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(14.49477f, -5.24049f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("S2B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.22011f, 3.63237f),
												new Vector2(2.20598f, 3.71550f),
												new Vector2(2.16788f, 3.80368f),
												new Vector2(2.11227f, 3.88716f),
												new Vector2(2.04557f, 3.95623f),
												new Vector2(1.97425f, 4.00115f),
												new Vector2(0.68401f, 4.18222f),
												new Vector2(-0.43877f, 3.75689f),
												new Vector2(-1.22375f, 2.90911f),
												new Vector2(-1.50060f, 1.82285f),
												new Vector2(-1.09896f, 0.68208f),
												new Vector2(-0.52874f, 0.12574f),
												new Vector2(0.27112f, -0.47585f),
												new Vector2(1.07679f, -1.10660f),
												new Vector2(1.66447f, -1.75039f),
												new Vector2(1.81035f, -2.39114f),
												new Vector2(1.45963f, -2.99216f),
												new Vector2(0.81561f, -3.45894f),
												new Vector2(0.03143f, -3.73175f),
												new Vector2(-0.73976f, -3.75086f),
												new Vector2(-1.34482f, -3.45652f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.69905f, 0.69905f, 0.69905f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-11.47760f, -5.82531f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("SB"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.44204f, 4.85477f),
												new Vector2(1.22876f, 5.38391f),
												new Vector2(-0.17330f, 5.10692f),
												new Vector2(-1.43092f, 4.25067f),
												new Vector2(-2.21092f, 3.04201f),
												new Vector2(-2.18008f, 1.70780f),
												new Vector2(-1.80636f, 1.29572f),
												new Vector2(-1.14063f, 0.89521f),
												new Vector2(-0.35199f, 0.51880f),
												new Vector2(0.39049f, 0.17903f),
												new Vector2(0.91773f, -0.11155f),
												new Vector2(1.41496f, -0.62992f),
												new Vector2(1.78168f, -1.32612f),
												new Vector2(1.96862f, -2.09260f),
												new Vector2(1.92652f, -2.82176f),
												new Vector2(1.60612f, -3.40604f),
												new Vector2(1.14889f, -3.75684f),
												new Vector2(0.62478f, -4.01106f),
												new Vector2(0.06376f, -4.21281f),
												new Vector2(-0.50421f, -4.40619f),
												new Vector2(-1.04913f, -4.63532f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70122f, 0.70122f, 0.70122f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-13.25663f, 5.02599f, 0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("T11B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.00594f, 1.10117f),
												new Vector2(0.00471f, 0.57683f),
												new Vector2(0.03011f, -0.27077f),
												new Vector2(0.06044f, -1.22612f),
												new Vector2(0.08584f, -2.07372f),
												new Vector2(0.09650f, -2.59807f),
									}, 1f, 0.6f);
				scene.lastChild().lastChild().scale(0.59591f, 0.59591f, 0.59591f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.91117f, 0.33592f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("T12B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-0.81978f, -0.01998f),
												new Vector2(-0.54737f, -0.01311f),
												new Vector2(-0.22259f, 0.00335f),
												new Vector2(0.11965f, 0.02320f),
												new Vector2(0.44443f, 0.04026f),
												new Vector2(0.71683f, 0.04831f),
									}, 1f, 0.6f);
				scene.lastChild().lastChild().scale(0.59591f, 0.59591f, 0.59591f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(-2.91117f, 0.33592f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("U11B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(-1.37760f, 3.11607f),
												new Vector2(-1.38717f, 2.37385f),
												new Vector2(-1.39253f, 1.35561f),
												new Vector2(-1.35870f, 0.25610f),
												new Vector2(-1.25065f, -0.72993f),
												new Vector2(-1.03340f, -1.40771f),
												new Vector2(-0.45704f, -1.93877f),
												new Vector2(0.24928f, -2.01799f),
												new Vector2(1.02145f, -1.75302f),
												new Vector2(1.79538f, -1.25147f),
												new Vector2(2.50694f, -0.62096f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70665f, 0.70665f, 0.70665f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.21575f, 5.43706f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

				scene.lastChild().addChild(new Object("U12B"));
				scene.lastChild().lastChild().createFreeformTube(new List<Vector2> {
												new Vector2(2.40860f, 2.87021f),
												new Vector2(2.42394f, 2.11769f),
												new Vector2(2.46053f, 0.88604f),
												new Vector2(2.50419f, -0.50531f),
												new Vector2(2.54078f, -1.73696f),
												new Vector2(2.55612f, -2.48948f),
									}, 1f, 1.1f);
				scene.lastChild().lastChild().scale(0.70665f, 0.70665f, 0.70665f);
				scene.lastChild().lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
				scene.lastChild().lastChild().translate(7.21575f, 5.43706f, -0.00000f);
				scene.lastChild().lastChild().centerOrigin();
				scene.lastChild().lastChild().setColor(0.00353f, 0.00342f, 0.00353f);

			} // Children of 'BigTitleBezier.001'

			scene.lastChild().scale(0.33513f, 0.33513f, 0.33513f);
			scene.lastChild().rotateQ(0.65328f, 0.65328f, 0.27060f, 0.27060f);
			scene.lastChild().translate(-1.57979f, 1.49782f, 14.68988f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(1.0f, 1.0f, 0.0f);

			scene.addChild(new Object("AsapCerobong"));
			scene.lastChild().createTorus();
			scene.lastChild().scale(0.31778f, 0.31778f, 0.31778f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(-6.80996f, 6.80335f, 11.96830f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.15743f, 0.15743f, 0.15743f);

			scene.addChild(new Object("AsapCerobong.001"));
			scene.lastChild().createTorus();
			scene.lastChild().scale(0.31778f, 0.31778f, 0.31778f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(-6.80996f, 6.80335f, 11.96830f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.15743f, 0.15743f, 0.15743f);

			scene.addChild(new Object("AsapCerobong.002"));
			scene.lastChild().createTorus();
			scene.lastChild().scale(0.31778f, 0.31778f, 0.31778f);
			scene.lastChild().rotateQ(1.00000f, 0.00000f, 0.00000f, 0.00000f);
			scene.lastChild().translate(-6.80996f, 6.80335f, 11.96830f);
			scene.lastChild().centerOrigin();
			scene.lastChild().setColor(0.15743f, 0.15743f, 0.15743f);


			DaunPohonAnimator.s = 0.002f;
            TitleAnimator.s = 0.001f;

			AwanAnimator1.s = 0.002f;
			AwanAnimator2.s = 0.004f;
			AwanAnimator3.s = 0.006f;

			CerobongAnimator.s = 0.0015f;
			CerobongAnimator1.s = 0.0015f;
			CerobongAnimator2.s = 0.0015f;

			CerobongAnimator.o = 0f;
			CerobongAnimator1.o = 0.1f;
			CerobongAnimator2.o = 0.2f;
		}

        public static void Animations(ref Object scene)
        {
            scene.findChild("BigTitleBezier").scale(TitleAnimator.MinMaxBounce(0.9995f, 1.0005f));
            scene.findChild("BigTitleBezier.001").scale(TitleAnimator.MinMaxBounce(0.9995f, 1.0005f));

			scene.findChild("Pohon").findChild("DaunPohon.001").scaleZ(DaunPohonAnimator.MinMaxBounce(0.9985f, 1.0015f));
			scene.findChild("Pohon").findChild("DaunPohon.002").scaleZ(DaunPohonAnimator.MinMaxBounce(0.9985f, 1.0015f));
            scene.findChild("Pohon").findChild("DaunPohon.001").translateZ(DaunPohonAnimator.MinMaxBounce(-0.0015f, 0.0015f));
            scene.findChild("Pohon").findChild("DaunPohon.002").translateZ(DaunPohonAnimator.MinMaxBounce(-0.0015f, 0.0015f));

			scene.findChild("Awan").scaleX(AwanAnimator1.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.001").scaleX(AwanAnimator1.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.002").scaleX(AwanAnimator1.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.003").scaleX(AwanAnimator2.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.004").scaleX(AwanAnimator2.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.005").scaleX(AwanAnimator2.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.006").scaleX(AwanAnimator3.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.007").scaleX(AwanAnimator3.MinMaxBounce(0.998f, 1.002f));
			scene.findChild("Awan.008").scaleX(AwanAnimator3.MinMaxBounce(0.998f, 1.002f));


			if (CerobongAnimator.Linear() > 0 && CerobongAnimator.Linear() < 1)
			{
				scene.findChild("AsapCerobong").translateZ(0.005f);
				scene.findChild("AsapCerobong").scale(1.004f);
				scene.findChild("AsapCerobong").material.alpha += 0 - scene.findChild("AsapCerobong").material.alpha * 0.004f;
			}
			else { 
				scene.findChild("AsapCerobong").restoreTransform();
				scene.findChild("AsapCerobong").material.alpha = 1;
			}

			if (CerobongAnimator1.Linear() > 0.1 && CerobongAnimator.Linear() < 1)
			{
				scene.findChild("AsapCerobong.001").translateZ(0.005f);
				scene.findChild("AsapCerobong.001").scale(1.004f);
				scene.findChild("AsapCerobong.001").material.alpha += 0 - scene.findChild("AsapCerobong.001").material.alpha * 0.004f;
			}
			else
			{
				scene.findChild("AsapCerobong.001").restoreTransform();
				scene.findChild("AsapCerobong.001").material.alpha = 1;
			}
			if (CerobongAnimator2.Linear() > 0.2 && CerobongAnimator.Linear() < 1)
			{
				scene.findChild("AsapCerobong.002").translateZ(0.005f);
				scene.findChild("AsapCerobong.002").scale(1.004f);
				scene.findChild("AsapCerobong.002").material.alpha += 0 - scene.findChild("AsapCerobong.002").material.alpha * 0.004f;
			}									
			else								
			{									
				scene.findChild("AsapCerobong.002").restoreTransform();
				scene.findChild("AsapCerobong.002").material.alpha = 1;
			}

		}
    }
}
