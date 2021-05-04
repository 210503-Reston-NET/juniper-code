/// <summary>
/// Namespace for the models/custom data structures involved in Restaurant Reviews
/// </summary>
namespace RRModels
{
    /// <summary>
    /// Data structure used to define a restaurant
    /// </summary>
    public class Restaurant
    {
        // Class Members
        // 1. Constructor 
        // 2. Fields
        // 3. Methods 
        // 4. Properties - also known as smart fields, are accessor methods used to access private backing fields
        // *Note that properties are analogous to Java getter and setter
        //* Property naming convention uses PascalCase
        public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        public Restaurant()
        {
            
        }
        /// <summary>
        /// This describes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; }

        /// <summary>
        /// This describes the city of the restaurant location
        /// </summary>
        /// <value></value>
        public string City { get; }
        
        /// <summary>
        /// State location of the restaurant
        /// </summary>
        /// <value></value>
        public string State { get; }
        
        /// <summary>
        /// This contains the review of a particular restaurant
        /// </summary>
        /// <value></value>
        public Review Review { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} \t\n Location: {City}, {State} \t\n Review: {Review.ToString()}";
        }
    }
}