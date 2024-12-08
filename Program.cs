using System.Text.Json;

namespace Blue_Lagoon___Chaos_Edition {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }

    // I couldn't serialize a static class easily
    class StatisticsValues {
        public int settlersPlaced = 0;
        public int villagesPlaced = 0;

        public int serversJoined = 0;
        public int gamesPlayed = 0;

        public int explorationPhasesWon = 0;
        public int explorationPhasesLost = 0;

        public int settlementPhasesWon = 0;
        public int settlementPhasesLost = 0;
        public int settlementPhasesUnplayable = 0;
    }
    static class Statistics {
        #region Variables
        // Const refernences
        static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
        static readonly StatisticsValues values = File.Exists("statistics.json") ?  JsonSerializer.Deserialize<StatisticsValues>(File.ReadAllText("statistics.json"), new JsonSerializerOptions { IncludeFields = true }) 
                                                                                 ?? new StatisticsValues() 
                                                                                 :  new StatisticsValues();
        // References to variables (to use in updating)
        static unsafe int*[] pointers;
        static unsafe Statistics() { // beautiful
            fixed (int* p0 = &values.settlersPlaced,
                        p1 = &values.villagesPlaced,
                        p2 = &values.serversJoined,
                        p3 = &values.gamesPlayed,
                        p4 = &values.explorationPhasesWon,
                        p5 = &values.explorationPhasesLost,
                        p6 = &values.settlementPhasesWon,
                        p7 = &values.settlementPhasesLost,
                        p8 = &values.settlementPhasesUnplayable) {
                pointers = [p0, p1, p2, p3, p4, p5, p6, p7, p8];
            }
        }
        #endregion

        #region Statistics Increment & Store Function
        public static void IncrementStatistic(int type) {
            if (0 <= type && type < pointers.Length) {
                // Increment
                unsafe {
                    pointers[type]++;
                }

                // Save changes to file
                File.WriteAllText("statistics.json", JsonSerializer.Serialize(values, jsonOptions));
            }
        }
        #endregion
    }
}