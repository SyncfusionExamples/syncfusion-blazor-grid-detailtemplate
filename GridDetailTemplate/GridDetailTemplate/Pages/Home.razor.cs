namespace GridDetailTemplate.Pages
{
    public partial class Home
    {

        public List<ParentRow> Parents { get; set; } = new List<ParentRow>();
        public List<OriginRow> Origins { get; set; } = new List<OriginRow>();
        public List<WellboreRow> Wellbores { get; set; } = new List<WellboreRow>();
        public List<CompletionRow> Completions { get; set; } = new List<CompletionRow>();

        protected override void OnInitialized()
        {
            string[] operators =
            {
        "Canadian Natural Resources",
        "Cenovus Energy",
        "Suncor Energy",
        "Imperial Oil",
        "MEG Energy"
    };

            string[] fields =
            {
        "Eagle Ford",
        "Kaybob",
        "Pembina",
        "Fox Creek",
        "Rainbow Lake"
    };

            string[] regions =
            {
        "Alberta",
        "British Columbia",
        "Saskatchewan"
    };

            string[] reservoirs =
            {
        "Montney",
        "Duvernay",
        "Cardium",
        "Viking",
        "Bakken"
    };

            for (int well = 1; well <= 500; well++)
            {
                Parents.Add(new ParentRow
                {
                    WellOriginId = well,
                    UWI = $"100-{well:0000}-W4",
                    WellName = $"Eagle North {well}",
                    FieldName = fields[well % fields.Length],
                    Operator = operators[well % operators.Length],
                    Region = regions[well % regions.Length]
                });

                for (int origin = 1; origin <= 20; origin++)
                {
                    int originId = (well * 100) + origin;

                    Origins.Add(new OriginRow
                    {
                        OriginId = originId,
                        WellOriginId = well,
                        SurfaceLocation = $"LSD {origin:00}-12-045-06W4",
                        WellName = $"Eagle North {well}",
                        LicenseNumber = $"LIC-{well:000000}",
                        Operator = operators[well % operators.Length]
                    });

                    for (int child = 1; child <= 20; child++)
                    {
                        Wellbores.Add(new WellboreRow
                        {
                            OriginId = originId,
                            WellboreId = $"WB-{originId}-{child}",
                            DrillingUWI = $"100-{well:0000}-W4",
                            LicenseNumber = $"LIC-{well:000000}",
                            TVD = 2500 + child * 25,
                            TMD = 3000 + child * 35,
                            WellType = child % 2 == 0 ? "Horizontal" : "Vertical"
                        });

                        Completions.Add(new CompletionRow
                        {
                            OriginId = originId,
                            CompletionId = $"CMP-{originId}-{child}",
                            CompletionUWI = $"100-{well:0000}-W4",
                            OnProductionDate =
                                new DateTime(2024, 1, 1).AddDays(child),
                            Status =
                                child % 3 == 0 ? "Suspended" : "Producing",
                            Reservoir =
                                reservoirs[child % reservoirs.Length]
                        });
                    }
                }
            }
        }
        public class ParentRow
        {
            public int WellOriginId { get; set; }
            public string? UWI { get; set; }
            public string? WellName { get; set; }
            public string? FieldName { get; set; }
            public string? Operator { get; set; }
            public string? Region { get; set; }
        }

        public class OriginRow
        {
            public int OriginId { get; set; }
            public int WellOriginId { get; set; }
            public string? SurfaceLocation { get; set; }
            public string? WellName { get; set; }
            public string? LicenseNumber { get; set; }
            public string? Operator { get; set; }
        }

        public class WellboreRow
        {
            public int OriginId { get; set; }
            public string? WellboreId { get; set; }
            public string? DrillingUWI { get; set; }
            public string? LicenseNumber { get; set; }
            public double TVD { get; set; }
            public double TMD { get; set; }
            public string? WellType { get; set; }
        }

        public class CompletionRow
        {
            public int OriginId { get; set; }
            public string? CompletionId { get; set; }
            public string? CompletionUWI { get; set; }
            public DateTime OnProductionDate { get; set; }
            public string? Status { get; set; }
            public string? Reservoir { get; set; }
        }
    }
}
