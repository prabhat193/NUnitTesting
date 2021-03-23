using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTesting
{
    [TestFixture]
    class PlayerHandling
    {
        [Test]
        public void TestPlayer()
        {
            foreach (var player in Program.playerList())
            {
                Assert.NotNull(player.PlayerId);
                Assert.NotNull(player.PlayerName);
                Assert.NotNull(player.PlayerTeam);

            }
        }
    }
}
