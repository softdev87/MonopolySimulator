using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MonopolySimulator.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum Name
    {
        [EnumMember(Value = "Go")] Go,
        [EnumMember(Value = "Mediterranean Avenue")] MediterraneanAvenue,
        [EnumMember(Value = "Community Chest 1")] CommunityChest1,
        [EnumMember(Value = "Baltic Avenue")] BalticAvenue,
        [EnumMember(Value = "Income Tax")] IncomeTax,
        [EnumMember(Value = "Reading Railroad")] ReadingRailroad,
        [EnumMember(Value = "Oriental Avenue")] OrientalAvenue,
        [EnumMember(Value = "Chance 1")] Chance1,
        [EnumMember(Value = "Vermont Avenue")] VermontAvenue,
        [EnumMember(Value = "Connecticut Avenue")] ConnecticutAvenue,
        [EnumMember(Value = "Jail")] Jail,
        [EnumMember(Value = "St. Charles Place")] StCharlesPlace,
        [EnumMember(Value = "Electric Company")] ElectricCompany,
        [EnumMember(Value = "States Avenue")] StatesAvenue,
        [EnumMember(Value = "Virginia Avenue")] VirginiaAvenue,
        [EnumMember(Value = "Pennsylvania Railroad")] PennsylvaniaRailroad,
        [EnumMember(Value = "St. James Place")] StJamesPlace,
        [EnumMember(Value = "Community Chest 2")] CommunityChest2,
        [EnumMember(Value = "Tennessee Avenue")] TennesseeAvenue,
        [EnumMember(Value = "New York Avenue")] NewYorkAvenue,
        [EnumMember(Value = "Free Parking")] FreeParking,
        [EnumMember(Value = "Kentucky Avenue")] KentuckyAvenue,
        [EnumMember(Value = "Chance 2")] Chance2,
        [EnumMember(Value = "Indiana Avenue")] IndianaAvenue,
        [EnumMember(Value = "Illnois Avenue")] IllnoisAvenue,
        [EnumMember(Value = "B. & O. Railroad")] BAndORailroad,
        [EnumMember(Value = "Atlatic Avenue")] AtlaticAvenue,
        [EnumMember(Value = "Ventura Avenue")] VenturaAvenue,
        [EnumMember(Value = "Water Works")] WaterWorks,
        [EnumMember(Value = "Marvin Gardens")] MarvinGardens,
        [EnumMember(Value = "Go To Jail")] GoToJail,
        [EnumMember(Value = "Pacific Avenue")] PacificAvenue,
        [EnumMember(Value = "North Carolina Avenue")] NorthCarolinaAvenue,
        [EnumMember(Value = "Community Chest 3")] CommunityChest3,
        [EnumMember(Value = "Pennsylvania Avenue")] PennsylvaniaAvenue,
        [EnumMember(Value = "Shortline")] Shortline,
        [EnumMember(Value = "Chance 3")] Chance3,
        [EnumMember(Value = "Park Place")] ParkPlace,
        [EnumMember(Value = "Luxury Tax")] LuxuryTax,
        [EnumMember(Value = "Boardwalk")] Boardwalk
    }
}