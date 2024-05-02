namespace TRPO_Comunalka.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComTest()
        {
            const int L = 4;
            const double H = 0.06;
            const double C = 0.111;
            const double F = 20;
            const double T = 2;
            const double En = 263;
            const double Kap = 142;
            const double Space = 142;

            const double expected = 5252.85375;

            var result = Lib.Comunalka.Com(L, H, C, F, T, En, Kap, Space);

            Assert.AreEqual(expected, result, 0.1);
        }
        [Test]
        public void ExceptionTest()
        {
            const int L = -1;
            const double H = 0.06;
            const double C = 0.111;
            const double F = 20;
            const double T = 2;
            const double En = 263;
            const double Kap = 142;
            const double Space = 142;

            Assert.Throws<Exception>(() => Lib.Comunalka.Com(L, H, C, F, T, En, Kap, Space));
        }
    }
}