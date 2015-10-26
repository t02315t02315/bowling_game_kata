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
                if (i == 10) g.SetPins(10,i);
                else g.SetPins(0,i);
            }
             Assert.That(g.GetFinalScore(), Is.EqualTo(10));
        } 
    }
}
