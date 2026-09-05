using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.JsonDataHandling;
public class JsonPractice
    {
        public void Question1()
        {

            StudentDH StudentDH = new StudentDH
            {
                Name = "Rahul",
                Age = 20,
                Subjects = new List<string>
                {
                    "Math",
                    "Science",
                    "English"
                }
            };

            string json = JsonConvert.SerializeObject(StudentDH, Formatting.Indented);

            Console.WriteLine(json);
        }

        public void Question2()
        {

            CarDH car = new CarDH
            {
                Brand = "Toyota",
                Model = "Fortuner",
                Year = 2024
            };

            string json = JsonConvert.SerializeObject(car, Formatting.Indented);

            Console.WriteLine(json);
        }

        public void Question3()
        {
            string json = File.ReadAllText("users.json");
            Console.WriteLine("JSON read from file:");
            Console.WriteLine(json);
            List<UserDH>? users = JsonConvert.DeserializeObject<List<UserDH>>(json);

            if (users == null)
            {
                Console.WriteLine("No users found.");
                return;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} - {user.Email}");
            }
        }

        public void Question4()
        {

            PersonDH person = new PersonDH
            {
                Name = "Rahul",
                Age = 25
            };

            AddressDH address = new AddressDH
            {
                City = "Delhi",
                Country = "India"
            };

            PersonDetailsDH details = new PersonDetailsDH
            {
                Name = person.Name,
                Age = person.Age,
                City = address.City,
                Country = address.Country
            };

            string json = JsonConvert.SerializeObject(details, Formatting.Indented);

            Console.WriteLine(json);
        }

        public void Question5()
        {

            string schemaJson = @"{
                'type':'object',
                'properties':
                {
                    'Name':{'type':'string'},
                    'Age':{'type':'integer'}
                },
                'required':['Name','Age']
            }";

            JSchema schema = JSchema.Parse(schemaJson);

            JObject student = JObject.Parse("""
                                            {
                                              "Name": "Rahul",
                                              "Age": 20}
                                            """);

            Console.WriteLine(student.IsValid(schema));
        }

        public void Question6()
        {

            List<EmployeeDH> employees = new List<EmployeeDH>
            {
                new EmployeeDH { Id = 1, Name = "Rahul" },
                new EmployeeDH { Id = 2, Name = "Amit" },
                new EmployeeDH { Id = 3, Name = "Neha" }
            };

            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);

            Console.WriteLine(json);
        }

        public void Question7()
        {
            string json = File.ReadAllText("users.json");

            List<UserDH>? users = JsonConvert.DeserializeObject<List<UserDH>>(json);

            if (users == null)
            {
                Console.WriteLine("No users found.");
                return;
            }

            var result = users.Where(u => u.Age > 25);

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
        }
    }