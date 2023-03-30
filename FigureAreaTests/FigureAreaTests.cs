namespace FigureAreaTests
{
    public class FigureAreaTests
    {
        [Test]
        public void IsRightTriangle_1and1and1_falseReturned()
        {
            double a =1;
            double b =1;
            double c =1;

            var result = FigureArea.FigureArea.IsRightTriangle(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsRightTriangle_3_031and4_04and5_05_trueReturned()
        {
            double a = 3.031;
            double b = 4.04;
            double c = 5.05;

            var result = FigureArea.FigureArea.IsRightTriangle(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsRightTriangle_3and4and5_trueReturned()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            var result = FigureArea.FigureArea.IsRightTriangle(a, b, c);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsRightTriangle_3_03and4_04and5_05_trueReturned()
        {
            double a = 3.03;
            double b = 4.04;
            double c = 5.05;

            var result = FigureArea.FigureArea.IsRightTriangle(a, b, c);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsRightTriangle_5and12and13_trueReturned()
        {
            double a = 5;
            double b = 12;
            double c = 13;

            var result = FigureArea.FigureArea.IsRightTriangle(a, b, c);

            Assert.IsTrue(result);
        }

        [Test]
        public void CalculateArea_2_returned_12_56()
        {
            double a = 2;
            double expåcted = 12.56;

            var result = FigureArea.FigureArea.CalculateArea(a);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_17_returned_907_46()
        {
            double a = 17;
            double expåcted = 907.46;

            var result = FigureArea.FigureArea.CalculateArea(a);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_8_74_returned_60_00()
        {
            double a = 2.5;
            double expåcted = 19.625;

            var result = FigureArea.FigureArea.CalculateArea(a);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_4and5and3_returned_6()
        {
            double a = 4;
            double b = 5;
            double c = 3;
            double expåcted = 6;

            var result = FigureArea.FigureArea.CalculateArea(a, b, c);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_13and14and15_returned_84()
        {
            double a = 13;
            double b = 14;
            double c = 15;
            double expåcted = 84;

            var result = FigureArea.FigureArea.CalculateArea(a, b, c);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_17and65and80_returned_288()
        {
            double a = 17;
            double b = 65;
            double c = 80;
            double expåcted = 288;

            var result = FigureArea.FigureArea.CalculateArea(a, b, c);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_5and13and6_returned_30()
        {
            double a = 5;
            double b = 13;
            double c = 12;
            double expåcted = 30;

            var result = FigureArea.FigureArea.CalculateArea(a, b, c);

            Assert.AreEqual(expåcted, result);
        }

        [Test]
        public void CalculateArea_12and16and20_returned_96()
        {
            double a = 12;
            double b = 16;
            double c = 20;
            double expåcted = 96;

            var result = FigureArea.FigureArea.CalculateArea(a, b, c);

            Assert.AreEqual(expåcted, result);
        }

    }
}