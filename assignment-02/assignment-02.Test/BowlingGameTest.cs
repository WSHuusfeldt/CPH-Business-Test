using System;
using System.Collections.Generic;
using assignment_02.Program;
using Xunit;

namespace assignment_02.Test
{
    public class BowlingGameTest
    {
        private BowlingGame g;

        public BowlingGameTest() {
            g = new BowlingGame();
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.roll(pins);
        }

        private void rollSpare() {
            g.roll(5);
            g.roll(5);
        }

        private void rollStrike()
        {
            g.roll(10);
        }

        [Fact]
        public void testGutterGame()
        {
            rollMany(20, 0);
            Assert.Equal(0, g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.Equal(20, g.score());
        }

        [Fact]
        public void testOneSpare()
        {
            rollSpare();
            g.roll(3);
            rollMany(17,0);
            Assert.Equal(16, g.score());
        }

        [Fact]
        public void testOneStrike()
        {
            rollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(16,0);
            Assert.Equal(24, g.score());
        }

        [Fact]
        public void testPrefectGame()
        {
            rollMany(12, 10);
            Assert.Equal(300, g.score());
        }
    }
}
