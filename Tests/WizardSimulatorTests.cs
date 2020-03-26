using NUnit.Framework;

namespace Tests
{
    public class WizardRpgSimulatorTests
    {
        [Test]
        public void PlayerWinsInFourRounds()
        {
            var simulator = new WizardRpgSimulator();
            var winner = simulator.Run(12, 7, 2, 8, 5, 5);

            Assert.That(simulator.RoundsPlayed, Is.EqualTo(4));
            Assert.That(winner.Name, Is.EqualTo("player"));
            Assert.That(winner.Points, Is.EqualTo(2));
        }
    }
}