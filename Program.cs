using System.Text.Json;

namespace Blue_Lagoon___Chaos_Edition {
    internal static class Program {
        [STAThread]
        static void Main() {
            // no idea what you are
            ApplicationConfiguration.Initialize();

            // Setup statistics
            Statistics statistics = File.Exists("statistics.json") ?
                JsonSerializer.Deserialize<Statistics>(File.ReadAllText("statistics.json"), new JsonSerializerOptions { IncludeFields = true }) ?? new Statistics() 
                : new Statistics();
            Statistics.statistics = statistics;

            unsafe {
                // Setup statistics pointers
                fixed (int* p0 = &statistics.settlersPlaced,
                            p1 = &statistics.villagesPlaced,
                            p2 = &statistics.serversJoined,
                            p3 = &statistics.gamesPlayed,
                            p4 = &statistics.explorationPhasesWon,
                            p5 = &statistics.explorationPhasesLost,
                            p6 = &statistics.settlementPhasesWon,
                            p7 = &statistics.settlementPhasesLost,
                            p8 = &statistics.settlementPhasesUnplayable) {
                    Statistics.pointers = [p0, p1, p2, p3, p4, p5, p6, p7, p8];

                    // Main Menu, I choose you!
                    Application.Run(new MainMenu());
                }
            }
        }
    }

    // I couldn't serialize a static class easily so we have a mix here
    class Statistics {
        #region Static Variables
        // Const references
        static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
        public static Statistics statistics;

        // Pointers to statistical variables used in incrementing
        public static unsafe int*[] pointers;
        #endregion

        #region Statistics Variables
        public int settlersPlaced = 0;
        public int villagesPlaced = 0;

        public int serversJoined = 0;
        public int gamesPlayed = 0;

        public int explorationPhasesWon = 0;
        public int explorationPhasesLost = 0;

        public int settlementPhasesWon = 0;
        public int settlementPhasesLost = 0;
        public int settlementPhasesUnplayable = 0;
        #endregion

        #region Statistics Functions
        // Increment Statistic & Store Statistics
        public static void IncrementStatistic(int type) {
            if (0 <= type && type < pointers.Length) {
                // Increment variable
                unsafe {
                    (*pointers[type])++;
                }

                // Save changes to file
                File.WriteAllText("statistics.json", JsonSerializer.Serialize(statistics, jsonOptions));
            }
        }

        // Get statistic
        public static unsafe string GetStatistic(int type) => (*pointers[type]).ToString(); 
        #endregion
    }
}