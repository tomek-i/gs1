namespace TI.GS1.API
{
    /// <summary>
    /// Interface of a GS1 Item
    /// </summary>
    public interface IGS1Item
    {
        /// <summary>
        /// Unique Identifier of that item based of the GS1 specification
        /// </summary>
        string Id { get; }
        
        /// <summary>
        /// Description of that item based of the GS1 specification
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// The Value for that item
        /// </summary>
        string Value { get; }
    }

   
}