
namespace UnEmployer
{
    class Employee : Human
    {
        int pensiya = 0;
        int pensionAge;
        public int Getpensiyu()
        {
            switch (gender)
            {
                case Gender.Male:
                    pensionAge = 65;
                    break;
                case Gender.Female:
                    pensionAge = 60;
                    break;
            }

            for (int i = Age; i < pensionAge; i++)
            {
                pensiya += 100000;
            }
            return pensiya;
        }
    }
}
