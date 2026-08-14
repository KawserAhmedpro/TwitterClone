namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        
        private string _firstName;
        private string _lastName;
        private string _email;


        public User(): base(Guid.NewGuid())
        {
            
        }

       
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

       

    }
}