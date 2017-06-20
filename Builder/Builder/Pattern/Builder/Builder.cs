using Builder.House;

namespace Builder.Pattern.Builder
{
    class Builder : AbstractBuilder
    {
        House.House house = new House.House();

        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildRoof()
        {
            house.Add(new Roof());
        }

        public override void BuildStorey()
        {
            house.Add(new Storey());
        }

        public override House.House GetResulit()
        {
            return house;
        }
    }
}
