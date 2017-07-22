﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WOWSharp.Community;
using WOWSharp.Community.Diablo;

namespace WOWSharp.UnitTests
{
	[TestClass]
    public class DiabloTests
    {
        /// <summary>
        /// Set test mode
        /// </summary>
        [TestInitialize]
        public void SetTestMode()
        {
            ApiClient.TestMode = true;
        }

        /// <summary>
        ///   test region leaders
        /// </summary>
        [TestMethod]
        [TestCategory("Diablo")]
        public void TestProfile()
        {
            var client = new DiabloClient(TestConstants.TestRegion, "en-gb", TestConstants.apiKey);
            var profile = client.GetProfileAsync(TestConstants.TestBattleTag).Result;
            Assert.IsNotNull(profile);
            Assert.AreEqual(TestConstants.TestBattleTag, profile.BattleTag);

            Assert.IsNotNull(profile.Progression);
            Assert.IsTrue(profile.Progression.Act1);
            Assert.IsTrue(profile.Progression.Act2);
            Assert.IsTrue(profile.Progression.Act3);
            Assert.IsTrue(profile.Progression.Act4);
            Assert.IsTrue(profile.Progression.Act5);
            
            Assert.IsNotNull(profile.TimePlayed);
            Assert.IsTrue(profile.TimePlayed.Barbarian > 0);
            Assert.IsTrue(profile.TimePlayed.DemonHunter > 0);
            Assert.IsTrue(profile.TimePlayed.Monk > 0);
            Assert.IsTrue(profile.TimePlayed.Witchdoctor > 0);
            Assert.IsTrue(profile.TimePlayed.Wizard > 0);

            Assert.IsNotNull(profile.Heroes);
            Assert.IsTrue(profile.Heroes.Count > 5);
            Assert.IsTrue(profile.Heroes[0].HeroClass != HeroClass.None);
            Assert.IsTrue(profile.Heroes[0].Level > 0);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(profile.Heroes[0].Name));
            Assert.IsTrue(profile.Heroes[0].Id > 0);
        }


        /// <summary>
        /// Test hero
        /// </summary>
        [TestMethod]
        [TestCategory("Diablo")]
        public void TestHero()
        {
            var client = new DiabloClient(TestConstants.TestRegion, "en-gb", TestConstants.apiKey, null);
            var profile = client.GetProfileAsync(TestConstants.TestBattleTag).Result;
            var hero = profile.Heroes.First(h => h.HeroClass == HeroClass.Barbarian
                && h.Level >= 60 && !h.IsHardcore);

            hero = client.GetHeroAsync(TestConstants.TestBattleTag, hero.Id).Result;

            Assert.IsNotNull(hero);
            //Assert.IsNotNull(hero.Client);
            Assert.IsNotNull(hero.Followers);
            Assert.IsNotNull(hero.Followers.Enchantress);
            Assert.IsNotNull(hero.Followers.Scoundrel);
            Assert.IsNotNull(hero.Followers.Templar);

            Assert.IsNotNull(hero.Followers.Templar.Items);
            //Assert.IsTrue(hero.Followers.Templar.Level >= 60);
            Assert.IsNotNull(hero.Followers.Templar.Skills);

            Assert.AreEqual(FollowerType.Templar, hero.Followers.Templar.FollowerType);
            Assert.AreEqual(FollowerType.Scoundrel, hero.Followers.Scoundrel.FollowerType);
            Assert.AreEqual(FollowerType.Enchantress, hero.Followers.Enchantress.FollowerType);

            Assert.IsTrue(hero.ParagonLevel >= 100);
            Assert.IsTrue(hero.Level >= 60);
            Assert.IsNotNull(hero.Kills);
            Assert.IsTrue(hero.Kills.EliteKills >= 100);
            Assert.IsTrue(hero.Id > 0);
            Assert.AreEqual(HeroGender.Male, hero.Gender);
            Assert.IsNotNull(hero.Stats);
            Assert.IsTrue(hero.Stats.ArcaneResistance > 0);
            Assert.IsTrue(hero.Stats.PhysicalResistance > 0);
            Assert.IsTrue(hero.Stats.ColdResistance > 0);
            Assert.IsTrue(hero.Stats.FireResistance > 0);
            Assert.IsTrue(hero.Stats.Intelligence > 0);
            Assert.IsTrue(hero.Stats.Dexterity > 0);
            //Assert.IsTrue(hero.Stats.MagicFind > 0);
            Assert.IsTrue(hero.Stats.Strength > 0);
            Assert.IsTrue(hero.Stats.Vitality > 0);
            Assert.IsTrue(hero.Stats.GoldFind > 0);
            Assert.IsTrue(hero.Stats.PoisonResistance > 0);
            Assert.IsTrue(hero.Stats.PrimaryResourceMaximum > 0);
            Assert.IsTrue(hero.Stats.MaximumHealthPoints > 0);
            Assert.IsTrue(hero.Stats.Damage > 0);
            //Assert.IsTrue(hero.Stats.DamageIncrease > 0);
            //Assert.IsTrue(hero.Stats.DamageReductionFromArmor > 0);
            Assert.IsTrue(hero.Stats.Armor > 0);
            Assert.IsTrue(hero.Stats.AttackSpeed > 0);
            Assert.IsTrue(hero.Stats.CriticalHitDamageBonus > 0);
            //Assert.IsTrue(hero.Stats.CriticalHitChance > 0);

            Assert.IsNotNull(hero.Items);
            var item = hero.Items.AllItems.FirstOrDefault();
            Assert.IsNotNull(item);
            Assert.IsNotNull(item.Name);
            Assert.IsNotNull(item.Path);
            Assert.IsNotNull(item.TooltipParameters);
            Assert.IsNotNull(item.Id);
            Assert.IsNotNull(item.Icon);
            //Assert.IsNotNull(item.Client);

        }

        /// <summary>
        /// Test follower information
        /// </summary>
        [TestMethod]
        public void TestFollower()
        {
            var client = new DiabloClient(TestConstants.TestRegion, "en-gb", TestConstants.apiKey, null);
            var follower = client.GetFollowerInfoAsync(FollowerType.Templar).Result;
            Assert.AreEqual(FollowerType.Templar, follower.FollowerType);
            Assert.AreEqual("Templar", follower.Name);
            Assert.IsNotNull(follower.Portrait);
            Assert.IsNotNull(follower.Skills);
            Assert.IsNotNull(follower.Skills.Active);
            Assert.IsNotNull(follower.Skills.Active[0]);
        }


        /// <summary>
        /// Test artisan information
        /// </summary>
        [TestMethod]
        public void TestArtisan()
        {
            var client = new DiabloClient(TestConstants.TestRegion, "en-gb", TestConstants.apiKey, null);
            var blackSmith = client.GetArtisanInfoAsync(ArtisanType.Blacksmith).Result;
            Assert.IsNotNull(blackSmith);
            Assert.AreEqual(ArtisanType.Blacksmith, blackSmith.ArtisanType);
            Assert.AreEqual("Blacksmith", blackSmith.Name);
            Assert.IsNotNull(blackSmith.Portrait);
            Assert.IsNotNull(blackSmith.Training);
            Assert.IsNotNull(blackSmith.Training.Tiers);
            Assert.IsTrue(blackSmith.Training.Tiers.Count > 0);
            Assert.IsNotNull(blackSmith.Training.Tiers[0]);
            Assert.IsNotNull(blackSmith.Training.Tiers[0].Levels);
            Assert.IsTrue(blackSmith.Training.Tiers[0].Levels.Count > 0);
            Assert.IsNotNull(blackSmith.Training.Tiers[0].Levels[0]);
            Assert.IsTrue(blackSmith.Training.Tiers[0].Levels[0].Tier > 0);
            Assert.IsTrue(blackSmith.Training.Tiers[0].Levels[0].TierLevel > 0);
            Assert.IsTrue(blackSmith.Training.Tiers[0].Levels[1].ProgressPercent > 0);
            Assert.IsNotNull(blackSmith.Training.Tiers[0].Levels[0].TrainedRecipes);
            Assert.IsNotNull(blackSmith.Training.Tiers.Last().Levels.Last().TaughtRecipes);
        }
    }
}


