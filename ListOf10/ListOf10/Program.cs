using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOf10
{
    public class UserDefined : Exception
    {
        public UserDefined(string errorMessage) : base(errorMessage)
        {

        }


        static void Main(string[] args)
        {

            try
            {
                List<User> instagrmUser = new List<User>();

                User userOne = new User();
                userOne.Comments = "You are funny!";
                userOne.UserId = 1;
                userOne.UserName = "Rodney";

                instagrmUser.Add(userOne);

                User userTwo = new User();
                userTwo.Comments = "Thank You!";
                userOne.UserId = 2;
                userOne.UserName = "Donny";

                instagrmUser.Add(userTwo);

                User userThree = new User();
                userThree.Comments = "You are blessed!";
                userThree.UserId = 3;
                userThree.UserName = "Donny";

                instagrmUser.Add(userThree);

                User userFour = new User();
                userFour.Comments = "You are the man!";
                userFour.UserId = 4;
                userFour.UserName = "Vernon";

                instagrmUser.Add(userFour);


                User userFive = new User();
                userFive.Comments = "You are the funnier!";
                userFive.UserId = 5;
                userFive.UserName = "Matthew";

                instagrmUser.Add(userFive);


                User userSix = new User();
                userSix.Comments = "You are fun to be around!";
                userSix.UserId = 6;
                userSix.UserName = "Tommy";

                instagrmUser.Add(userSix);


                User userSeven = new User();
                userSeven.Comments = "You are the funniest!";
                userSeven.UserId = 7;
                userSeven.UserName = "Thomas";

                instagrmUser.Add(userSeven);


                User userEight = new User();
                userEight.Comments = "You are the best at what you do!";
                userEight.UserId = 8;
                userEight.UserName = "Franny";

                instagrmUser.Add(userEight);


                User userNine = new User();
                userFour.Comments = "Big fan of Clemson!";
                userFour.UserId = 9;
                userFour.UserName = "Gus";

                instagrmUser.Add(userNine);


                User userTen = new User();
                userTen.Comments = "Great friend!";
                userTen.UserId = 10;
                userTen.UserName = "Yolanda";

                instagrmUser.Add(userTen);

                List<User> result = instagrmUser.Where(User => User.UserId==3).ToList();
                if (result.Count == 0)
                {
                    throw new UserDefined("I did find the user");
                }
                else
                {
                    foreach(var User in result)
                    {
                        Console.WriteLine(User.UserId);
                        Console.WriteLine(User.UserName);
                    }
                }
                catch (UserDefined exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("program is finished!");

            }




        }
    }
}
public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Comments { get; set; }

}
