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
        public List<String> MainColor = new List<String>();
        public List<String> ColorDescription = new List<String>();
        public Soul Soul { get; set; }
        public List<Mutation> Mutations { get; set; }
        public List<Construction> Construction { get; set; }
        public History History { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Agility { get; set; }
        public int WeaponSkill { get; set; }
        public int BallisticSkill { get; set; }
        public int OperationalTime { get; set; }
        public String primaryColor { get; set; }
        public String secondaryColor { get; set; }
        public Body Body { get; set; }
        #endregion
        #region Constructors
        public Evangelion()
        {
            InitiateComponents();
        }
        public Evangelion(Soul soul, Mutation mutation, Construction construction, History history, String selectedMainColor, String SelectedSecondColor)
        {
            InitiateComponents();
            Strength += 30;
            Toughness += 30;
            Agility += 0;
            WeaponSkill += 15;
            BallisticSkill += 15;
            OperationalTime = 5;
            Body = new Body(Toughness, "Evangelion");
            if (soul == null)
                Soul = randomSoul(rnd.Next(1, 101));
            else
                Soul = soul;
            if (mutation == null)
                Mutations = randomMutations(rnd.Next(1, 101));
            else
                Mutations = new List<Mutation> { mutation };
            if (construction == null)
                Construction = RandomConstruction(rnd.Next(1, 101));
            else
                Construction = new List<Construction> { construction };
            if (history == null)
                History = randomHistory(rnd.Next(1, 101));
            else
                History = history;
            if (selectedMainColor.Equals(null) || SelectedSecondColor.Equals(null))
            {
                primaryColor = randomColor(rnd.Next(1, 101), rnd.Next(1, 101));
                secondaryColor = randomColor(rnd.Next(1, 101), rnd.Next(1, 101));
            }
            else
            {
                primaryColor = selectedMainColor;
                secondaryColor = SelectedSecondColor;
            }
            CalculateEffects(Mutations, Construction, History);
            if (Body.BaseToughness > Toughness)
            {
                Body.woundIncrease("Evangelion", -1);
            }
            if (Body.BaseToughness < Toughness)
            {
                Body.woundIncrease("Evangelion", 1);
            }
        }
        public Evangelion(Soul soul, List<Mutation> mutation, List<Construction> construction, History history, String priColor, String secColor)
        {
            Soul = soul;
            Mutations = mutation;
            Construction = construction;
            History = history;
            primaryColor = priColor;
            secondaryColor = secColor;
            Strength = 30;
            Toughness = 30;
            WeaponSkill = 15;
            BallisticSkill = 15;
        }
        #endregion
        #region Private Methods
        private void CalculateEffects(List<Mutation> mutations, List<Construction> constructions, History history)
        {
            switch (history.Name)
            {
                case "Prototype":
                    Body.armorIncrease("Evangelion", -1);
                    Mutations.AddRange(randomMutations(rnd.Next(1, 101)));
                    break;
                case "Patchwork":
                    Toughness -= 10;
                    break;
            }
            foreach (Mutation mutation in mutations)
            {
                switch (mutation.Name)
                {
                    case "Hulking Frame":
                        Strength += 3;
                        Toughness += 3;
                        Agility -= 3;
                        break;
                    case "Redundant Organs":
                        Body.woundIncrease("Evangelion", 1);
                        break;
                    case "Photosynthetic":
                        OperationalTime += 1;
                        break;
                    case "Predatory":
                        WeaponSkill += 3;
                        Strength += 3;
                        break;
                    case "Cyclopean":
                        Body.Head.Wounds -= 1;
                        break;
                    case "Extra Eyes":
                        BallisticSkill += 3;
                        break;
                }
            }
            foreach (Construction construction in constructions)
            {
                switch (construction.Name)
                {
                    case "Odd Limbs":
                        Agility += 3;
                        break;
                    case "Lightweight Chassis":
                        Body.armorIncrease("Evangelion", -1);
                        Agility += 5;
                        break;
                    case "Heavy Armor":
                        Body.armorIncrease("Evangelion", 1);
                        Agility -= 5;
                        break;
                    case "Advanced Battery":
                        OperationalTime += 1;
                        break;
                }
            }
        }
        private void InitiateComponents()
        {
            Construction = new List<Construction>();
            Mutations = new List<Mutation>();
            SoulList = new List<Soul>
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
            MutationList = new List<Mutation>
            {
                new Mutation("Pressurized Blood", 1, "The Evangelions blood pressure is through the roof! Whenever the Evangelion rolls for Blood Loss, it must roll twice and take the worse roll."),
                new Mutation("Bioluminescent", 2, "The unit's blood gives off light due to unidentified chemicals in its blood cells. This light tends to leak from between the armor plates, and from the mouth and eyes. The Eva takes a -20 to Concealment. The color of the light is determined by rolling an extra secondary color."),
                new Mutation("Cyclopean", 3, "The Eva’s head is dominated by a complex optical array that hasn replaced its eyes. When in the Evangelion the pilot may reroll 1 failed awareness test per round. However, the Eva’s head has 1 less wound."),
                new Mutation("Hulking Frame", 4, "The Evangelion beneath the armor is a powerful beast, noticeably stockier than a normal Eva. The Eva has its Strength and Toughness increases by 3, but suffers a -3 Agility."),
                new Mutation("Redundant Organs", 5, "The Evangelion gains an extra wound on all body parts."),
                new Mutation("Regenerative", 6, "When the Evangelion is repaired, it is found to have already healed its minor wounds, which need not be paid for. Subtract one point of collateral from the pool after every fight in which this Evangelion took damage."),
                new Mutation("Photosynthetic", 7, "The Evangelion takes in sunlight and converts it to energy, though all analysis seems to indicate a lack of chlorophyll. When fighting in appropriate levels of sunlight, the Eva’s operational time is 1 round longer."),
                new Mutation("Angelsense", 8, "The Evangelion is naturally sensitive to the presence of other AT Fields. The pilot begins play with the “AT Ping” Power."),
                new Mutation("Cranial Horn", 9, "The Evangelion has a large horn on its head that may be used for a mediocre gore attack, dealing 1d5-2 rending damage."),
                new Mutation("Unrestrained Jaw", 10, "The Evangelion begins play capable of performing a 1d5+1 R bite attack"),
                new Mutation("Predatory", 11, "As Unrestrained Jaw, but the Eva gains a +3 to Weapon Skill and a +3 to Strength as well"),
                new Mutation("Extra Eyes", 12, "The Evangelion has an extra set of eyes, usually totaling 4 or 6 eyes. It’s increases sense of sight grants it a +3 to Ballistic Skill, and once per round the pilot may reroll a failed Awareness Test.")
            };
            ConstructionList = new List<Construction>
            {
                new Construction("Clinker", 1, "The unit's armor is ill-fitting and poorly lubricated. While it can power through these discomforts without a dip in performance, doing so causes it to give off immense clanking and grinding noises, as well as the occasional stray bolt. Add one point of collateral to the pool after every fight in which this Evangelion took damage."),
                new Construction("Single Winged", 2, "The Evangelion lacks a wing on 1 arm."),
                new Construction("Marker Light Array", 3, "The Evangelion gains a free Marker Light upgrade on one of its wings. This operates as the weapon upgrade, but takes up the wing slot"),
                new Construction("Feedback Suppressor", 4, "Gain a +10 to resist Feedback, but reduce your Synch Ratio by 1d5"),
                new Construction("Odd Limbs", 5, "The joints on the Eva’s limbs were designed to grant it increased mobility, but this new range of motion is strange and unfamiliar to the pilot. The pilots SR drops by 3, but the Eva’s Agility is increased by 3."),
                new Construction("Lightweight Chassis", 6, "The Eva’s armor is especially light, imposing a -1 armor penalty on all areas. However, the resulting freedom of movement has increased the Eva’s Agility by 5."),
                new Construction("Heavy Armor", 7, "The Eva’s Armor is especially dense, and grants a +1 armor bonus to all areas. However, the weight of it slows the Eva, reducing its agility by 5."),
                new Construction("Stabilizers", 8, ""),
                new Construction("Bakelite Infusion", 9, "The Evangelion is covered with small pockets of Bakelite prepared to release and cover exposed areas. The Eva rolls for Blood Loss twice and takes the better roll."),
                new Construction("Leg Pistons", 10, "The Evangelion has high pressure support systems on its legs, driving its feet into the ground with extra force. Whenever the Eva takes the run action, treat its Ag as if it were 2 higher."),
                new Construction("Advanced Battery", 11, "The Eva’s body contains a larger than normal battery, allowing it to continue operating for 6 rounds after being severed from an umbilical rather than 5."),
                new Construction("Weapon Rack", 12, "The Evangelion has, on its back, a mount to hold a single basic weapon. While the Evangelion may not emerge from a Launch point with this weapon, it may acquire a basic weapon afterwards and carry it without using its hands with no penalty.")
            };
            HistoryList = new List<History>
            {
                new History("Badly Financed", 1, ""),
                new History("Patchwork", 2, "The Evangelion is made from a patchwork of failed prototypes, dummy bodies, and duct tape. It works, if reluctantly, but its Toughness is reduced by 10.However, it has a wealth of spare parts on hand, and no additional collateral damage is gained when this Eva loses a limb."),
                new History("Prototype", 3, "The Evangelion was built as a test unit rather than a combat model. It has an additional mutation, but its body isn't built to the same specs as a combat unit, and has a -1 penalty to armor on all body parts."),
                new History("Haunted", 4, "The rumor is that the first person to try piloting the Eva was absorbed into it. The pilot can always feel something watching them, giving them a -20 penalty to Perception Tests in the plug. However, when the Evangelion goes Berserk, it is 30% less likely to attack another Evangelion."),
                new History("Concept Model", 5, "Built using only the best, newest, most expensive tech. It's like a sports car compared to the other Evas. The Evangelion begins play with 1 free SUP and 1 free WUP, but each battle it automatically incurs an extra 2 points of collateral damage as high maintenance parts must constantly be replaced."),
                new History("Mysterious Source", 6, "The Evangelion wasn't built by a country, but rather by an unidentified organization. While it contains several unidentified small machines attached to key systems that worry the engineering team, it starts with a free SUP. It’s trustworthy enough to use, for now..."),
                new History("Symbol", 7, "The Eva has a banner, medal, or other symbol of the people's support attached to its armor. Perhaps it was made by local schoolchildren, was a gift from a foreign government, or was part of a local unity event. If the symbol remains attached and undamaged the entire battle (no critical damage was done and no area attack breached the AT Field), 1d5 surplus of additional funding is supplied to the project by proud civilians."),
                new History("Flagship", 8, "The Evangelion was created and unveiled in a very public manner. It proudly bears the mark of whatever country built it, and is a symbol of national pride. In any battle where the Evangelion is defeated, subtract 2 collateral from the pool as the Eva’s home country chips in to repair it. However, they will not feel obligated to do anything else to alleviate Nerv’s deficit."),
            };
            MainColor = new List<String>
            {
                "Red",
                "Orange",
                "Yellow",
                "Blue",
                "Green",
                "White",
                "Black",
                "Purple",
                "Grey"
            };
            ColorDescription = new List<String>
            {
                "Bright ",
                "Dull ",
                "Dark ",
                "Neon "
            };
        }
        private Soul randomSoul(int soul)
        {
            if      (soul >= 1 && soul <= 5)
                return SoulList[0];
            else if (soul >= 6 && soul <= 10)
                return SoulList[1];
            else if (soul >= 11 && soul <= 15)
                return SoulList[2];
            else if (soul >= 16 && soul <= 25)
                return SoulList[3];
            else if (soul >= 26 && soul <= 35)
                return SoulList[4];
            else if (soul >= 36 && soul <= 45)
                return SoulList[5];
            else if (soul >= 46 && soul <= 60)
                return SoulList[6];
            else if (soul >= 61 && soul <= 70)
                return SoulList[7];
            else if (soul >= 71 && soul <= 80)
                return SoulList[8];
            else if (soul >= 81 && soul <= 90)
                return SoulList[9];
            else if (soul >= 91 && soul <= 100)
                return SoulList[10];

            return SoulList[rnd.Next(1,11)];
        }
        private List<Mutation> randomMutations(int randomMutation)
        {
            List<Mutation> mutations = new List<Mutation>();

            if (randomMutation == 100)
            {
                mutations.AddRange(randomMutations(rnd.Next(1, 101)));
                mutations.AddRange(randomMutations(rnd.Next(1, 101)));
            }
            else
            {
                mutations.Add(mutationGen(randomMutation));
            }

            return mutations;
        }
        private Mutation mutationGen(int mutation)
        {
            if (mutation >= 1 && mutation <= 10 && !Mutations.Contains(MutationList[0]))
                return MutationList[0];
            else if (mutation >= 11 && mutation <= 20 && !Mutations.Contains(MutationList[1]))
                return MutationList[1];
            else if (mutation >= 21 && mutation <= 25 && !Mutations.Contains(MutationList[2]))
                return MutationList[2];
            else if (mutation >= 26 && mutation <= 35 && !Mutations.Contains(MutationList[3]))
                return MutationList[3];
            else if (mutation >= 36 && mutation <= 45 && !Mutations.Contains(MutationList[4]))
                return MutationList[4];
            else if (mutation >= 46 && mutation <= 50 && !Mutations.Contains(MutationList[5]))
                return MutationList[5];
            else if (mutation >= 51 && mutation <= 60 && !Mutations.Contains(MutationList[6]))
                return MutationList[6];
            else if (mutation >= 61 && mutation <= 70 && !Mutations.Contains(MutationList[7]))
                return MutationList[7];
            else if (mutation >= 71 && mutation <= 75 && !Mutations.Contains(MutationList[8]))
                return MutationList[8];
            else if (mutation >= 76 && mutation <= 85 && !Mutations.Contains(MutationList[9]))
                return MutationList[9];
            else if (mutation >= 86 && mutation <= 90 && !Mutations.Contains(MutationList[10]))
                return MutationList[10];
            else if (mutation >= 91 && mutation <= 99 && !Mutations.Contains(MutationList[11]))
                return MutationList[11];

            return mutationGen(rnd.Next(1, 100));
        }
        private List<Construction> RandomConstruction(int randomConstruction)
        {
            List<Construction> constructions = new List<Construction>();

            if (randomConstruction == 100)
            {
                constructions.AddRange(RandomConstruction(rnd.Next(1, 101)));
                constructions.AddRange(RandomConstruction(rnd.Next(1, 101)));
            }
            else
            {
                constructions.Add(constructionGen(randomConstruction));
            }
            return constructions;
        }
        private Construction constructionGen(int construction)
        {
            if (construction >= 1 && construction <= 15)
                return ConstructionList[0];
            else if (construction >= 16 && construction <= 20)
                return ConstructionList[1];
            else if (construction >= 21 && construction <= 30)
                return ConstructionList[2];
            else if (construction >= 31 && construction <= 40)
                return ConstructionList[3];
            else if (construction >= 41 && construction <= 50)
                return ConstructionList[4];
            else if (construction >= 51 && construction <= 60)
                return ConstructionList[5];
            else if (construction >= 61 && construction <= 70)
                return ConstructionList[6];
            else if (construction >= 71 && construction <= 75)
                return ConstructionList[7];
            else if (construction >= 76 && construction <= 80)
                return ConstructionList[8];
            else if (construction >= 81 && construction <= 85)
                return ConstructionList[9];
            else if (construction >= 86 && construction <= 90)
                return ConstructionList[10];
            else if (construction >= 91 && construction <= 99)
                return ConstructionList[11];

            return constructionGen(rnd.Next(1,100));
        }
        private History randomHistory(int history)
        {

            if (history >= 1 && history <= 9)
                return HistoryList[0];
            else if (history >= 10 && history <= 25)
                return HistoryList[1];
            else if (history >= 26 && history <= 36)
                return HistoryList[2];
            else if (history >= 37 && history <= 45)
                return HistoryList[3];
            else if (history >= 46 && history <= 54)
                return HistoryList[4];
            else if (history >= 55 && history <= 63)
                return HistoryList[5];
            else if (history >= 64 && history <= 72)
                return HistoryList[6];
            else if (history >= 73 && history <= 100)
                return HistoryList[7];

            return HistoryList[rnd.Next(1,8)];
        }
        private String randomColor(int part1, int part2)
        {
            String Color = "";

            if (part1 >= 1 && part1 <= 25)
                Color += ColorDescription[0];
            else if (part1 >= 26 && part1 <= 50)
                Color += ColorDescription[1];
            else if (part1 >= 51 && part1 <= 75)
                Color += ColorDescription[2];
            else if (part1 >= 76 && part1 <= 100)
                Color += ColorDescription[3];

            if (part2 >= 1 && part2 <= 11)
                Color += MainColor[0];
            else if (part2 >= 12 && part2 <= 22)
                Color += MainColor[1];
            else if (part2 >= 23 && part2 <= 33)
                Color += MainColor[2];
            else if (part2 >= 34 && part2 <= 44)
                Color += MainColor[3];
            else if (part2 >= 45 && part2 <= 55)
                Color += MainColor[4];
            else if (part2 >= 56 && part2 <= 66)
            {
                if (!Color.Equals(ColorDescription[0]) || !Color.Equals(ColorDescription[2]))
                    Color += MainColor[5];
                else 
                    Color += MainColor[8];
            }
            else if (part2 >= 67 && part2 <= 77)
            {
                if (!Color.Equals(ColorDescription[0]) || !Color.Equals(ColorDescription[2]))
                    Color += MainColor[6];
                else
                    Color += MainColor[8];
            }
            else if (part2 >= 78 && part2 <= 88)
                Color += MainColor[7];
            else if (part2 >= 89 && part2 <= 100)
                Color += MainColor[8];


            return Color;

        }
        #endregion
    }
}
