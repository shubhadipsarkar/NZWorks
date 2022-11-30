using NZWorks.Models.Data;

namespace NZWorks.Ripository
{
    public class RegionRepository : IRegionRepository
    {
        IEnumerable<Regions> IRegionRepository.GetAll()
        {
            var regions = new List<Regions>()
            {
                new Regions()
                {
                    ID=1,
                    Name="Shyam"
                },
                new Regions()
                {
                    ID=2,
                    Name="Ram"
                }


            };
            return regions;




        }
    }
}
