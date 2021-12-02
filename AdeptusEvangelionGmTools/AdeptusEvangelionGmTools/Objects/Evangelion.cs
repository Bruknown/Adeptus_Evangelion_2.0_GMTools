using AdeptusEvangelionGmTools.Objects.EvaProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects
{
    public class Evangelion
    {
        #region Properties
        Random rnd = new Random();
        public List<Soul> SoulList = new List<Soul>();
        public List<Mutation> MutationList = new List<Mutation>();
        public List<Construction> ConstructionList = new List<Construction>();
        public List<History> HistoryList = new List<History>();
        public String Soul { get; set; }
        public List<String> Mutations { get; set; }
        public List<String> Construction { get; set; }
        public String History { get; set; }
        public String PrimaryColor { get; set; }
        public String SecondaryColor { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Agility { get; set; }
        public int WeaponSkill { get; set; }
        public int BallisticSkill { get; set; }
        public int OperationalTime { get; set; }
        public Body Body { get; set; }
        #endregion
        #region Constructors
        public Evangelion()
        {
            InitiateComponents();
        }
        public Evangelion(bool RandomSoul, bool RandomMutation, bool RandomConstruction, bool RandomHistory, bool RandomColor, Soul soul, Mutation mutation, Construction construction, History history)
        {
            InitiateComponents();
            Strength += 30;
            Toughness += 30;
            Agility += 0;
            WeaponSkill += 15;
            BallisticSkill += 15;
            OperationalTime = 5;
            Body = new Body(Toughness, "Evangelion");
            if (RandomSoul)
                Soul = randomSoul(rnd.Next(1, 101));
            else
                Soul = soul.Name;
            if (RandomMutation)
                Mutations = randomMutation(rnd.Next(1, 101));
            else
                Mutations = new List<String> { mutation.Name };
            if (RandomConstruction)
                Construction = randomConstruction(rnd.Next(1, 101));
            else
                Construction = new List<String> { construction.Name };
            if (RandomConstruction)
                History = randomHistory(rnd.Next(1, 101));
            else
                History = history.Name;
            if (RandomColor)
            {
                PrimaryColor = randomColor(rnd.Next(1, 101), rnd.Next(1, 101));
                SecondaryColor = randomColor(rnd.Next(1, 101), rnd.Next(1, 101));
            }
        }
        public Evangelion(String soul, List<String> mutation, List<String> construction, String history, String primaryColor, String secondaryColor)
        {
            Soul = soul;
            Mutations = mutation;
            Construction = construction;
            History = history;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
            Strength = 30;
            Toughness = 30;
            WeaponSkill = 15;
            BallisticSkill = 15;
        }
        #endregion
        #region Private Methods
        private void InitiateComponents()
        {
            SoulList = InitiateSouls();
            MutationList = InitiateMutations();
            ConstructionList = InitiateConstructions();
            HistoryList = InitiateHistory();
        }
        private List<Soul> InitiateSouls()
        {
            List<Soul> souls = new List<Soul>
            {
                 new Soul("Fractured Mind", 1, "Whenever the pilot rolls initiative, also roll a Synch  Ratio Test. On a failure, the Eva becomes Frenzied. It spends 1 round flailing around and attacking the environment before engaging the enemy"),
                 new Soul("Weeping", 2, "When in the Entry Plug, you swear that there is someone sobbing just on the edge of your hearing. This is understandably unnerving, and whenever you gain Insanity Points in the Entry Plug you gain 1 extra."),
                 new Soul("Insane", 3,"This Eva's mind and personality are so shattered that it can't be helped but to think of it as mad. While it is restrained and operates more or less normally, the pilot automatically gains an Insanity Point every time they roll a Synch Ratio Test in the Entry Plug."),
                 new Soul("Invasive", 4,"The Eva's personality is so strong, it can affect the pilot. After every battle, the pilot must roll Willpower. If he fails, during the night he is plagued by dreams that fragments of memory from someone else. By morning, he has gained 1d5 Insanity Points, but his Synch Ratio has increased by 1."),
                 new Soul("Dormant Soul", 5, "Your Evangelion is extremely difficult to rouse, and will never Berserk if the pilot’s Synch Ratio is below 60"),
                 new Soul("Destructive", 6,"The Evangelion is filled with nothing but rage. Deal an extra point of Critical Damage in melee whenever Berserk, but you add three points of collateral to the pool instead of two."),
                 new Soul("Protective", 7, "Something about the Eva makes it want to protect humans. Whenever the Evangelion Berserks, you add one point of collateral to the pool instead of two."),
                 new Soul("Calm", 8,"The Eva is calm and stable, even in the heat of combat. The Evangelion must succeed twice on its Berserk chance to actually Berserk, but the Pilot gains a +10 to resist Fear."),
                 new Soul("Angelic", 9,"The Eva's AT field pattern reads as Blue. Berserk Evas treat such an Eva as an Angel, and attack it whenever possible. While it’s Synch Ratio with its pilot is 1d5 less, it paradoxically has an ATS of 1 higher than normal."),
                 new Soul("Skittish", 10,"Like a wild animal, the Evangelion shies away from danger. The Evangelions Agility increases by 5. When Berserk, the Evangelion will immediately disengage from melee for 1 round after receiving critical damage."),
                 new Soul("Bonded", 11,"The Evangelion seems to have an emotional attachment with its chosen pilot, and the pilot’s SR increases by 3. However, it will not function for anyone else under any circumstances, even rejecting Dummy Plugs.")
            };

            return souls;
        }
        private List<Mutation> InitiateMutations()
        {
            List<Mutation> mutations = new List<Mutation>
            {
                new Mutation("Pressurized Blood", 1, ""),
                new Mutation("Bioluminescent", 2, ""),
                new Mutation("Cyclopean", 3, ""),
                new Mutation("Hulking Frame", 4, ""),
                new Mutation("Redundant Organs", 5, ""),
                new Mutation("Regenerative", 6, ""),
                new Mutation("Photosynthetic", 7, ""),
                new Mutation("Angelsense", 8, ""),
                new Mutation("Cranial Horn", 9, ""),
                new Mutation("Unrestrained Jaw", 10, ""),
                new Mutation("Predatory", 11, ""),
                new Mutation("Extra Eyes", 12, "")
            };
            return mutations;
        }
        private List<Construction> InitiateConstructions()
        {
            List<Construction> constructions = new List<Construction>
            {
                new Construction("Clinker", 1, ""),
                new Construction("Single Winged", 2, ""),
                new Construction("Marker Light Array", 3, ""),
                new Construction("Feedback Suppressor", 4, ""),
                new Construction("Odd Limbs", 5, ""),
                new Construction("Lightweight Chassis", 6, ""),
                new Construction("Heavy Armor", 7, ""),
                new Construction("Stabilizers", 8, ""),
                new Construction("Bakelite Infusion", 9, ""),
                new Construction("Leg Pistons", 10, ""),
                new Construction("Advanced Battery", 11, ""),
                new Construction("Weapon Rack", 12, "")
            };
            return constructions;
        }
        private List<History> InitiateHistory()
        {
            List<History> history = new List<History>
            {
                new History("Badly Financed", 1, ""),
                new History("Patchwork", 2, ""),
                new History("Prototype", 3, ""),
                new History("Haunted", 4, ""),
                new History("Concept Model", 5, ""),
                new History("Mysterious Source", 6, ""),
                new History("Symbol", 7, ""),
                new History("Flagship", 8, ""),
            };
            return history;
        }
        private String randomSoul(int soul)
        {
            if      (soul >= 1 && soul <= 5)
                return SoulList[0].Name;
            else if (soul >= 6 && soul <= 10)
                return SoulList[1].Name;
            else if (soul >= 11 && soul <= 15)
                return SoulList[2].Name;
            else if (soul >= 16 && soul <= 25)
                return SoulList[3].Name;
            else if (soul >= 26 && soul <= 35)
                return SoulList[4].Name;
            else if (soul >= 36 && soul <= 45)
                return SoulList[5].Name;
            else if (soul >= 46 && soul <= 60)
                return SoulList[6].Name;
            else if (soul >= 61 && soul <= 70)
                return SoulList[7].Name;
            else if (soul >= 71 && soul <= 80)
                return SoulList[8].Name;
            else if (soul >= 81 && soul <= 90)
                return SoulList[9].Name;
            else if (soul >= 91 && soul <= 100)
                return SoulList[10].Name;

            return SoulList[rnd.Next(1,11)].Name;
        }
        private List<String> randomMutation(int randomMutation)
        {
            List<String> mutations = new List<String>();

            if (randomMutation == 100)
            {
                mutations.Add(mutation(rnd.Next(1, 100)));
                mutations.Add(mutation(rnd.Next(1, 100)));
            }
            else
            {
                mutations.Add(mutation(randomMutation));
            }

            return mutations;
        }
        private string mutation(int mutation)
        {
            if (mutation >= 1 && mutation <= 10)
                return MutationList[0].Name;
            else if (mutation >= 11 && mutation <= 20)
                return MutationList[1].Name;
            else if (mutation >= 21 && mutation <= 25)
                return MutationList[2].Name;
            else if (mutation >= 26 && mutation <= 35)
            {
                Strength = +3;
                Toughness = +3;
                Agility = -3;
                return MutationList[3].Name;
            }
            else if (mutation >= 36 && mutation <= 45)
            {
                Body.Head.Wounds += 1;
                Body.Torso.Wounds += 1;
                Body.LeftArm.Wounds += 1;
                Body.LeftLeg.Wounds += 1;
                Body.RightArm.Wounds += 1;
                Body.RightLeg.Wounds += 1;
                return MutationList[4].Name;
            }
            else if (mutation >= 46 && mutation <= 50)
                return MutationList[5].Name;
            else if (mutation >= 51 && mutation <= 60)
            {
                OperationalTime += 1;
                return MutationList[6].Name;
            }
            else if (mutation >= 61 && mutation <= 70)
                return MutationList[7].Name;
            else if (mutation >= 71 && mutation <= 75)
                return MutationList[8].Name;
            else if (mutation >= 76 && mutation <= 85)
                return MutationList[9].Name;
            else if (mutation >= 86 && mutation <= 90)
            {
                WeaponSkill += 3;
                Strength += 3;
                return MutationList[10].Name;
            }
            else if (mutation >= 91 && mutation <= 99)
            {
                BallisticSkill += 3;
                return MutationList[11].Name;
            }

            return MutationList[rnd.Next(1,12)].Name;
        }
        private List<String> randomConstruction(int randomConstruction)
        {
            List<String> constructions = new List<String>();

            if (randomConstruction == 100)
            {
                constructions.Add(construction(rnd.Next(1, 100)));
                constructions.Add(construction(rnd.Next(1, 100)));
            }
            else
            {
                constructions.Add(construction(randomConstruction));
            }

            return constructions;
        }
        private string construction(int construction)
        {
            if (construction >= 1 && construction <= 15)
                return ConstructionList[0].Name;
            else if (construction >= 16 && construction <= 20)
                return ConstructionList[1].Name;
            else if (construction >= 21 && construction <= 30)
                return ConstructionList[2].Name;
            else if (construction >= 31 && construction <= 40)
                return ConstructionList[3].Name;
            else if (construction >= 41 && construction <= 50)
            {
                Agility += 3;
                return ConstructionList[4].Name;
            }
            else if (construction >= 51 && construction <= 60)
            {
                Body.Head.Armor -= 1;
                Body.Torso.Armor -= 1;
                Body.LeftArm.Armor -= 1;
                Body.LeftLeg.Armor -= 1;
                Body.RightArm.Armor -= 1;
                Body.RightLeg.Armor -= 1;
                Agility += 5;
                return ConstructionList[5].Name;
            }
            else if (construction >= 61 && construction <= 70)
            {
                Body.Head.Armor += 1;
                Body.Torso.Armor += 1;
                Body.LeftArm.Armor += 1;
                Body.LeftLeg.Armor += 1;
                Body.RightArm.Armor += 1;
                Body.RightLeg.Armor += 1;
                Agility -= 5;
                return ConstructionList[6].Name;
            }
            else if (construction >= 71 && construction <= 75)
                return ConstructionList[7].Name;
            else if (construction >= 76 && construction <= 80)
                return ConstructionList[8].Name;
            else if (construction >= 81 && construction <= 85)
                return ConstructionList[9].Name;
            else if (construction >= 86 && construction <= 90)
            {
                OperationalTime += 1;
                return ConstructionList[10].Name;
            }
            else if (construction >= 91 && construction <= 99)
                return ConstructionList[11].Name;

            return ConstructionList[rnd.Next(1,12)].Name;
        }
        private String randomHistory(int history)
        {

            if (history >= 1 && history <= 9)
                return HistoryList[0].Name;
            else if (history >= 10 && history <= 25)
                return HistoryList[1].Name;
            else if (history >= 26 && history <= 36)
                return HistoryList[2].Name;
            else if (history >= 37 && history <= 45)
                return HistoryList[3].Name;
            else if (history >= 46 && history <= 54)
                return HistoryList[4].Name;
            else if (history >= 55 && history <= 63)
                return HistoryList[5].Name;
            else if (history >= 64 && history <= 72)
                return HistoryList[6].Name;
            else if (history >= 73 && history <= 100)
                return HistoryList[7].Name;

            return HistoryList[rnd.Next(1,8)].Name;
        }
        private String randomColor(int part1, int part2)
        {

            String Color = "";

            if (part1 >= 1 && part1 <= 25)
                Color += "Bright ";
            else if (part1 >= 26 && part1 <= 50)
                Color += "Dull ";
            else if (part1 >= 51 && part1 <= 75)
                Color += "Dark ";
            else if (part1 >= 76 && part1 <= 100)
                Color += "Neon ";

            if (part2 >= 1 && part2 <= 11)
                Color += "Red";
            else if (part2 >= 12 && part2 <= 22)
                Color += "Orange";
            else if (part2 >= 23 && part2 <= 33)
                Color += "Yellow";
            else if (part2 >= 34 && part2 <= 44)
                Color += "Blue";
            else if (part2 >= 45 && part2 <= 55)
                Color += "Green";
            else if (part2 >= 56 && part2 <= 66)
            {
                if (!Color.Equals("Bright ") || !Color.Equals("Dark "))
                    Color += "White";
                else 
                    Color += "Grey";

            }
            else if (part2 >= 67 && part2 <= 77)
            {
                if (!Color.Equals("Bright ") || !Color.Equals("Dark "))
                    Color += "Black";
                else
                    Color += "Grey";
            }
            else if (part2 >= 78 && part2 <= 88)
                Color += "Purple";
            else if (part2 >= 89 && part2 <= 100)
                Color += "Grey";


            return Color;

        }
        #endregion
    }
}
