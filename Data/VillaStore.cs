using API_Project.Models.DTO;

namespace API_Project.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO { Id = 1, Name = "Poor View" },
                new VillaDTO { Id = 2, Name ="Beach View" }

            };
    }
}
