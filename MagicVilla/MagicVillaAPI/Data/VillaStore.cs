using MagicVillaAPI.Modells.Dto;

namespace MagicVillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
              new VillaDTO{Id = 1,Name = "Pool View", Sqft=100,Occupancy = 1}
            , new VillaDTO{Id = 2,Name = "Beach View", Sqft=200,Occupancy = 2}
            , new VillaDTO{Id = 3,Name = "House View", Sqft=300,Occupancy = 3}
            };
        
    }
}
