namespace SelfieWookie.Core.Selfies.Domain
{
    /// <summary>
    /// Represente un selfie avec un wookie lié
    /// </summary>
    public class Selfie
    {
        #region Properties
        public int Id { get; set; }
        public String Title { get; set; }
        public Wookie Wookie { get; set; }
        public String ImagePath { get; set; }
        #endregion
    }
}
