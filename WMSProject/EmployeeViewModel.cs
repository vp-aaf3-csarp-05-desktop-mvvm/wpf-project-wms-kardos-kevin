namespace WMSProject
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";

        /// <summary>
        /// Adószám
        /// </summary>
        public string TaxNumber { get; } = "12345678-1-42";

        /// <summary>
        /// Felhasznált szabadnapok száma
        /// </summary>
        public int DaysOff { get; } = 6;
    }
}
