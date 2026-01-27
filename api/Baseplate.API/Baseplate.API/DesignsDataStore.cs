using Baseplate.API.Models;

namespace Baseplate.API
{
    public class DesignsDataStore
    {
        public List<DesignDto> Designs { get; set; }

        public static DesignsDataStore Current { get; } = new DesignsDataStore();

        public DesignsDataStore() {
            // init dummy data
            Designs = new List<DesignDto>()
            {
                new DesignDto() {Id = 1, LegoDesignId = "3001", Name = "brick 2 x 4"},
                new DesignDto() {Id = 2, LegoDesignId = "3007", Name = "brick 2 x 8"},
                new DesignDto() {Id = 3, LegoDesignId = "54200", Name = "slope 30 1 x 1 x 2/3 (cheese)"}
            };
        }
    }
}
