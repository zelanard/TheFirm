using System;
using System.Text;

namespace TheFirm.Model
{
    /// <summary>
    /// <c>Generator</c> contains methods for generating books.
    /// </summary>
    public static class Generator
    {
        private static Random random = new Random();
        /// <summary>
        /// Generate a random first name.
        /// </summary>
        /// <returns></returns>
        public static string FirstName()
        {
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "William", "Olivia", "James", "Sophia", "Benjamin", "Emma", "Daniel", "Ava", "Matthew", "Isabella", "Joseph", "Mia", "David", "Charlotte", "Andrew", "Lucy", "Ethan", "Grace", "Christopher", "Lily", "Daniel", "Sophia", "Alexander", "Chloe", "Matthew", "Amelia", "Nicholas", "Abigail", "William", "Ella", "Samuel", "Madison", "Joseph", "Scarlett", "Nathan", "Avery", "Thomas", "Sofia", "Jacob", "Hannah", "Christopher", "Elizabeth", "Anthony", "Victoria", "Joshua", "Penelope", "Ryan", "Natalie", "Elijah", "Zoe", "Liam", "Audrey", "Tyler", "Layla", "William", "Aria", "Alexander", "Madeline", "Mason", "Hazel", "Luke", "Leah", "Evan", "Aubrey", "Christian", "Nora", "Isaac", "Aurora", "Dylan", "Brooklyn", "Carter", "Riley", "Gabriel", "Ellie", "Logan", "Savannah", "Jack", "Alice", "Jackson", "Stella", "Owen", "Maya", "Henry", "Julia", "Sebastian", "Evelyn", "Landon", "Claire", "Zachary", "Abigail", "Eli", "Harper", "Nathaniel", "Lillian", "Gavin", "Anna" };
            return $"{firstNames[random.Next(firstNames.Length - 1)]}";
        }
        /// <summary>
        /// Generate a random last name.
        /// </summary>
        /// <returns></returns>
        public static string LastName()
        {
            string[] lastNames = { "Smith", "Johnson", "Brown", "Davis", "Wilson", "Lee", "Anderson", "Harris", "Clark", "White", "Walker", "Hall", "Young", "Allen", "King", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Lewis", "Allen", "Young", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Allen", "Young", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Walker", "Hall", "Young", "Allen", "King", "Wright" };
            return $"{lastNames[random.Next(lastNames.Length - 1)]}";
        }
        /// <summary>
        /// Generate random phone number
        /// </summary>
        /// <returns>a string with 8 random digits</returns>
        public static string PhoneNumber()
        {
            return random.Next(00000000, 99999999).ToString();
        }
        /// <summary>
        /// Generate random email address.
        /// </summary>
        /// <returns></returns>
        public static string Email(string firstname, string lastname)
        {
            List<string> Domains = new List<string> { "CoolTechHub.com", "AwesomeGadgetWorld.com", "EpicAdventureZone.com", "CreativeMindHub.com", "InnovateNow365.com", "DigitalNinjaMaster.com", "GeekyGeniusZone.com", "ExploreUniverse.com", "GameChangerPro.com", "CodingWizardry.com", "TechTrendsetter.com", "PixelPerfectionist.com", "WebDesignWhiz.com", "RobotRevolution.com", "DataDrivenInsight.com", "FutureInnovations.net", "CyberSecurityPro.com", "SciFiDreamscape.com", "VRWorldExplorer.com", "CryptoEmpireHub.com", "MusicMavenHub.com", "StartupUnleashed.com", "TheArtisticMinds.com", "NatureAdventures.com", "TravelEnthusiast.com", "HealthyLifestyleHub.com", "FoodieDelights.com", "FitnessJunkiePro.com", "MindfulLivingWorld.com", "GamerNestOnline.com", "MovieBuffParadise.com", "FashionForwardPro.com", "BeautyGuruZone.com", "ArtisticExpression.com", "HomeDecorMaven.com", "GreenLivingPro.com", "WildlifeExplorer.com", "PhotographyPassion.com", "HistoricalJourney.com", "AdventureSeekerPro.com", "ExploreSpaceNow.com", "OutdoorAdventurist.com", "YogaEnthusiastHub.com", "ZenMeditationZone.com", "MindfulnessJourney.com", "TechInnovatorPro.com", "FutureTechWizard.com", "InventiveGenius.com", "DigitalDreamscape.com", "VirtualRealityPro.com", "CryptoInvestorHub.com", "MusicArtistSpot.com", "StartupEuphoria.com", "TheCreativeMinds.com", "NaturalWondersHub.com", "WanderlustJourney.com", "HealthyHabitPro.com", "FoodieFiestaHub.com", "FitnessGuruZone.com", "HolisticLivingHub.com", "GamingRealmOnline.com", "CinemaMagicPro.com", "FashionistaDomain.com", "BeautyIconZone.com", "ArtisticSoulHub.com", "HomeDesignMaven.com", "SustainableLifePro.com", "WildlifeObserver.com", "PhotographyProZone.com", "HistoricalOdyssey.com", "AdventurousSoul.com", "CosmicExplorerPro.com", "NatureLoverHub.com", "YogaZenMaster.com", "MeditationJourney.com", "TechSavvyProZone.com", "FutureTechGuru.com", "InnovationWizard.com", "DigitalAdventureHub.com", "VRPioneerZone.com", "CryptoKingpinPro.com", "MusicHarmonyHub.com", "StartupVisionary.com", "TheInspiredMinds.com", "NaturalBeautyHub.com", "WanderlustAdventures.com", "HealthyLivingProZone.com", "CulinaryExplorer.com", "FitnessEvolution.com", "MindfulSoulJourney.com", "GamingEnthusiastPro.com", "CinematicMagicHub.com", "FashionRevolutionist.com", "BeautyEleganceZone.com", "ArtisticExpressionPro.com", "HomeDecorInnovator.com", "EcoFriendlyProZone.com", "WildlifeAdventurist.com", "PhotographyPassionHub.com", "HistoricalWondersZone.com", "OutdoorAdventuresPro.com", "YogaBlissZone.com", "ZenMeditationJourney.com", "MindfulnessMavenHub.com", "TechInnovationWizard.com", "FutureTechMasterPro.com", "InnovativeGeniusZone.com", "DigitalDreamscapeHub.com", "VirtualRealityPioneer.com", "CryptoInvestorProZone.com", "MusicArtistSpotlight.com", "StartupTrailblazer.com", "TheCreativeGeniusHub.com" };
            return @$"{firstname}.{lastname}@{Domains[random.Next(0, 99)]}";
        }
        /// <summary>
        /// Generate random social security number.
        /// </summary>
        /// <returns></returns>
        public static string SocialSecurityNumber()
        {
            DateTime startDate = new DateTime(1900, 1, 1);
            DateTime endDate = DateTime.Today;
            TimeSpan timeSpan = endDate - startDate;
            int totalDays = (int)timeSpan.TotalDays;
            int randomDays = random.Next(0, totalDays);
            startDate.AddSeconds(randomDays);
            DateTime final = startDate.AddDays(random.Next(0, totalDays));
            return $"{final.ToString("ddMMyy")}-{random.Next(1000, 9999)}".Replace("/", "");
        }
    }
}
