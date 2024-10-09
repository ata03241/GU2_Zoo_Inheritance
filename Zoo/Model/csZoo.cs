using System;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
    public class csZoo
    {
        public List<csAnimal> ListOfAnimal { get; set; } = new List<csAnimal>();
        public string Name { get; set; }

        public virtual int meatconsumption { get; }
        public virtual int Nrofwolves { get; }
        public virtual int NrofParrot { get; }

        public override string ToString()
        {
            string sRet = $"\n{Name}: \n----------------------------------";
            foreach (var item in ListOfAnimal)
            {
                sRet += $"\n{item}";
            }
            return sRet;
        }

        public csZoo(int nrAnimals, string name)
        {
            Name = name;
            var rnd = new csSeedGenerator();
            for (int i = 0; i < nrAnimals; i++)
            {
                ListOfAnimal.Add(new csAnimal(rnd));
            }
        }
        public csZoo()
        {
            Name = nameof(csZoo);
            var rnd = new csSeedGenerator();

            /*
            #region every kind and mood using foreach
            var kinds = typeof(enAnimalKind).GetEnumValues();
            foreach (enAnimalKind kind in kinds)
            {
                var moods = typeof(enAnimalMood).GetEnumValues();
                foreach (enAnimalMood mood in moods)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
                }
            }
            #endregion
            */
            // #region every kind of African Animals
            // for (enAnimalKind kind = enAnimalKind.Aligator; kind <= enAnimalKind.Monkey; kind++)
            // {
            //     var moods = typeof(enAnimalMood).GetEnumValues();
            //     foreach (enAnimalMood mood in moods)
            //     {
            //         ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
            //     }
            // }
            // #endregion
            // #region every kind of Nordic Animals
            // for (enAnimalKind kind = enAnimalKind.Moose; kind <= enAnimalKind.Fox; kind++)
            // {
            //     var moods = typeof(enAnimalMood).GetEnumValues();
            //     foreach (enAnimalMood mood in moods)
            //     {
            //         ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
            //     }
            // }
            // #endregion
            // #region every kind of Birds
            // for (enAnimalKind kind = enAnimalKind.Eagle; kind <= enAnimalKind.Parrot; kind++)
            // {
            //     var moods = typeof(enAnimalMood).GetEnumValues();
            //     foreach (enAnimalMood mood in moods)
            //     {
            //         ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind, Mood = mood });
            //     }
            // }
            // #endregion

        }
    }
    public class csAfricanZoo : csZoo
    {
        public override int Nrofwolves
        {
            get
            {
                return 0;
            }
        }

        public override int NrofParrot
        {
            get
            {
                return 0;
             }
        }
        public csAfricanZoo()
        {
            Name = nameof(csAfricanZoo);
            var rnd = new csSeedGenerator();
            for (enAnimalKind kind = enAnimalKind.Aligator; kind <= enAnimalKind.Monkey; kind++)
            {
                var random = rnd.Next(1, 5);
                for (int i = 0; i < random; i++)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind });
                }

            }
        }

        public override int meatconsumption
        {
            get
            {
                int totalmeat = 0;
                for (enAnimalKind kind = enAnimalKind.Aligator; kind <= enAnimalKind.Monkey; kind++)
                {
                    int meat = 0;
                    if (kind == enAnimalKind.Aligator)
                    {
                        meat += 10;
                    }
                    if (kind == enAnimalKind.Elephant)
                    {
                        meat += 0;
                    }
                    if (kind == enAnimalKind.Lion)
                    {
                        meat += 15;
                    }
                    if (kind == enAnimalKind.Monkey)
                    {
                        meat += 2;
                    }
                    totalmeat += meat;
                }
                return totalmeat;
            }
        }
    }

    public class csNordicZoo : csZoo
    {
        public override int meatconsumption
        {
            get
            {
                return 0;
            }
        }
        public override int NrofParrot
        {
            get
            {
                return 0;
             }
        }

        public override int Nrofwolves
        {
            get
            {
                int totalwolves = 0;
                var rnd = new csSeedGenerator();
                foreach (var item in ListOfAnimal)
                {
                    if (item.Kind == enAnimalKind.Wolf)
                    {
                        totalwolves += 1;
                    }
                }
                return totalwolves;
            }
        }



        public csNordicZoo()
        {
            Name = nameof(csNordicZoo);
            var rnd = new csSeedGenerator();
            for (enAnimalKind kind = enAnimalKind.Moose; kind <= enAnimalKind.Fox; kind++)
            {
                var random = rnd.Next(1, 10);
                for (int i = 0; i < random; i++)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind });
                }
            }

        }

    }

    public class csBirdZoo : csZoo
    {
        public override int meatconsumption
        {
            get
            {
                return 0;
            }
        }
        public override int Nrofwolves
        {
            get
            {
                return 0;
            }
        }

        public override int NrofParrot
        {
            get
            {
                int totalparrot = 0;
                foreach (var item in ListOfAnimal)
                {
                    if (item.Kind == enAnimalKind.Parrot)
                    {
                        totalparrot += 1;
                    }
                }
                return totalparrot;
            }
        }


        public csBirdZoo()
        {
            Name = nameof(csBirdZoo);
            var rnd = new csSeedGenerator();
            for (enAnimalKind kind = enAnimalKind.Eagle; kind <= enAnimalKind.Parrot; kind++)
            {
                var random = rnd.Next(5, 10);
                for (int i = 0; i < random; i++)
                {
                    ListOfAnimal.Add(new csAnimal(rnd) { Kind = kind });
                }
            }
        }

    }

}

