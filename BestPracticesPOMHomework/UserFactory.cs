namespace BestPracticesPOMHomework
{
    public static class UserFactory
    {
        public static UserRegistration CreateValidUser()
        {
            return new UserRegistration
            {
                FirstName = "Sara",
                LastName = "Berg",
                Email = "someemail5611@gmail.com",
                Gender = (int)Gender.Female,
                Password = "Berg123",
                Date = "3",
                Month = "3",
                Year = "1989",
                PostFirstName = "Sara",
                PostLastName = "Berg",
                Address = "11201 N Tatum Blvd Ste 300, Phoenix, AZ 85028-6039, US",
                City = "Phoenix",
                State = "Arizona",
                PostCode = "85003",
                Phone = "77684849494",
                Alias = "Home"
            };
        }
    }
}

