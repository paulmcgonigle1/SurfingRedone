using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SurfingRedone;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurfsUp4 db = new SurfsUp4();//creating the DB

            using (db)
            {
                //create some objects
                Teacher t1 = new Teacher() { TeacherID = 1, TName = "Andy Irons", Image = "\\images\\Surf-Instructors\\andyIrons.jpg " };
                Teacher t2 = new Teacher() { TeacherID = 2, TName = "Kelly Slater", Image = "\\images\\Surf-Instructors\\kellySlater.jpg " };
                Teacher t3 = new Teacher() { TeacherID = 3, TName = "Rickson Gracie", Image = "\\images\\Surf-Instructors\\ricksonGracie.jpg " };


                Beach b1 = new Beach() { BeachID = 1, BName = "Culdaff", Image = "\\images\\Beaches\\culdaff-beach.jpg" };
                Beach b2 = new Beach() { BeachID = 2, BName = "Ballyliffin", Image = "\\images\\Beaches\\ballyliffinBeach.jpg" };
                Beach b3 = new Beach() { BeachID = 3, BName = "Leenan", Image = "\\images\\Beaches\\Leenan-Beach.jpg" };
                Beach b4 = new Beach() { BeachID = 4, BName = "Tullagh", Image = "\\images\\Beaches\\tullaghBeach.jpg" };
                

                

                

                Board board1 = new Board() { BoardID = 1, BoardName ="Board1", Colour = "Red", Type = "Short", Weight = 70, ImageURL = "\\images\\SurfBoards\\board1.png", Price = 150 };
                Board board2 = new Board() { BoardID = 2, BoardName = "Board2", Colour = "Blue", Type = "Long", Weight = 80, ImageURL = "\\images\\SurfBoards\\board2.png", Price = 200 };
                Board board3 = new Board() { BoardID = 3, BoardName = "Board3", Colour = "White", Type = "Mini", Weight = 60, ImageURL = "\\images\\SurfBoards\\board3.png", Price =250 };

                Lesson lesson1 = new Lesson() { LessonID = 1, Date = DateTime.Now, Length = "1 Hour", Teacher = t1, board = board1, Beach = b1 };


               
                User user1 = new User() { UserID = 1, FirstName = "Paul", Surname = "Mc Gonigle", UserName = "admin", Password = "123", ProfilePic = "\\images\\SurfBoards\\paul.jpg", Balance = 1000 };
                user1.Boards.Add(board1);
                user1.Lessons.Add(lesson1);

               
                //add to DB

                db.Teachers.Add(t1);
                db.Teachers.Add(t2);
                db.Teachers.Add(t3);

                Console.WriteLine("Added teams to DB");
                db.Beaches.Add(b1);
                db.Beaches.Add(b2);
                db.Beaches.Add(b3);
                db.Beaches.Add(b4);

                Console.WriteLine("Added Players to DB");

                db.Boards.Add(board1);
                db.Boards.Add(board2);
                db.Boards.Add(board3);
                Console.WriteLine("Added Boards");

                db.Users.Add(user1);
                Console.WriteLine("Added Users");

                db.Lessons.Add(lesson1);
                Console.WriteLine("Added Lessons");


                //save changes

                db.SaveChanges();

                Console.WriteLine("Saved changes to DB");

                Console.ReadLine();
            }
        }
    }
}
