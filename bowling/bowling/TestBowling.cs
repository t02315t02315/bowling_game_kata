using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0,i);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void oneStrike()
        {
            Game g = new Game();
            for (int i = 0; i < 20;i++ )
            {
                if (i == 10){ g.SetPins(10,i);
                    i+=1;}
                else g.SetPins(1,i);
            }
             Assert.That(g.GetFinalScore(), Is.EqualTo(30));
        }
        [Test]
        public void oneSpare()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                {
                    g.SetPins(9, i);
                    i += 1;
                    g.SetPins(1, i);
                }
                else g.SetPins(1, i);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(29));
        }
        [Test]
        public void twoSpare()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                {
                    g.SetPins(9, i);
                    i += 1;
                    g.SetPins(1, i);
                }
                if (i == 12)
                {
                    g.SetPins(5, i);
                    i += 1;
                    g.SetPins(5, i);
                }
                else g.SetPins(1, i);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(42));
        }
        [Test]
        public void StrikeCombo()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                {
                    g.SetPins(10, i);
                    i += 1;
                    g.SetPins(0, i);
                }
                else if (i == 12)
                {
                    g.SetPins(10, i);
                    i += 1;
                    g.SetPins(0, i);
                }
                else g.SetPins(1, i);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(49));
        }
    }
}
